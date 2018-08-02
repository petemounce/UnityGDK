using Generated.Playground;
using Improbable.Gdk.Core;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Playground
{
    [UpdateAfter(typeof(AttemptShootingSystem))]
    public class ProcessShootingAttemptsSystem : ComponentSystem
    {
        private struct AttemptShootCommandData
        {
            public readonly int Length;
            [ReadOnly] public EntityArray Entity;
            public ComponentDataArray<SpatialOSServerShooting> Shooter;

            [ReadOnly] public ComponentArray<CommandRequests<Generated.Playground.ServerShooting.AttemptShot.Request>>
                CommandRequests;

            [ReadOnly] public ComponentDataArray<CommandRequestSender<SpatialOSCanBeShot>> Sender;
        }

        private struct HitCommandData
        {
            public readonly int Length;
            [ReadOnly] public ComponentDataArray<SpatialOSCanBeShot> Shottable;

            [ReadOnly]
            public ComponentArray<CommandRequests<Generated.Playground.CanBeShot.Hit.Request>> CommandRequests;

            [ReadOnly] public ComponentDataArray<EventSender<SpatialOSCanBeShot>> EventSender;
        }

        [Inject] private AttemptShootCommandData attemptShootCommandData;
        [Inject] private HitCommandData hitCommandData;

        protected override void OnUpdate()
        {
            // Handle Shooting Commands from players. Only allow hits if on target and ammo available.
            for (var i = 0; i < attemptShootCommandData.Length; i++)
            {
                var sender = attemptShootCommandData.Sender[i];
                var shooter = attemptShootCommandData.Shooter[i];
                var ammoLeft = shooter.Ammo;

                if (ammoLeft < 1)
                {
                    return;
                }

                var requests = attemptShootCommandData.CommandRequests[i].Buffer;
                var j = 0;
                while (ammoLeft > 0 && j < requests.Count)
                {
                    var info = requests[j].RawRequest;
                    var resp = new Generated.Playground.ValidationResponse { Success = true };
                    requests[j].SendAttemptShotResponse(resp);
                    if (info.Target.HasValue)
                    {
                        // Validate if this is legit
                        sender.SendHitRequest(info.Target.Value, new Generated.Playground.HitDetails
                            {
                                Damage = 1
                            }
                        );
                    }

                    Debug.Log($"{ammoLeft}");
                    ammoLeft -= 1;
                    j++;
                }

                shooter.Ammo = ammoLeft;

                if (ammoLeft < 1)
                {
                    // TODO: Add reloading tag to automatically reload
                    // PostUpdateCommands.AddComponent(attemptShootCommandData.Entity[i], new Reloading());
                }

                attemptShootCommandData.Shooter[i] = shooter;
            }

            // Handle Hit Commands
            for (var i = 0; i < hitCommandData.Length; i++)
            {
                var eventSender = hitCommandData.EventSender[i];
                foreach (var request in hitCommandData.CommandRequests[i].Buffer)
                {
                    var info = request.RawRequest;
                    eventSender.SendTookDamageEvent(new Generated.Playground.HitDetails {
                        Damage = info.Damage
                    });
                    WorkerRegistry.GetWorkerForWorld(World).View.LogDispatcher.HandleLog(LogType.Warning,
                        new LogEvent($"Dat player took {info.Damage} DMG"));
                }
            }
        }
    }
}
