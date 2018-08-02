using System.Runtime.InteropServices.ComTypes;
using Generated.Playground;
using Improbable.Gdk.Core;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Playground
{
    [UpdateAfter(typeof(AttemptShootingSystem))]
    public class ProcessShootingEventsSystem : ComponentSystem
    {
        private struct AttemptShootingEventData
        {
            public readonly int Length;
            [ReadOnly] public ComponentArray<Rigidbody> RigidBody;
            [ReadOnly] public ComponentArray<EventsReceived<ShootEvent>> ShootEventReceived;
        }

        private struct HandleShotEventData
        {
            public readonly int Length;
            [ReadOnly] public ComponentArray<Rigidbody> Rigidbody;
            [ReadOnly] public ComponentArray<EventsReceived<TookDamageEvent>> TookDamageEventReceived;
        }

        [Inject] private AttemptShootingEventData attemptShootingEventData;
        [Inject] private HandleShotEventData handleShotEventData;

        protected override void OnUpdate()
        {
            for (int i = 0; i < attemptShootingEventData.Length; i++)
            {
                Debug.Log("Received shoot event");
                // attemptShootingEventData.RigidBody[i].gameObject.SetActive(false);
            }

            for (var i = 0; i < handleShotEventData.Length; i++)
            {
                Debug.Log("Received hit event");
                handleShotEventData.Rigidbody[i].gameObject.SetActive(false);
            }
        }
    }
}
