using System;
using Generated.Playground;
using Improbable.Gdk.Core;
using Playground.Scripts.UI;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Playground
{
    public class AttemptShootingSystem : ComponentSystem
    {
        private struct PlayerData
        {
            public readonly int Length;
            [ReadOnly] public ComponentDataArray<SpatialEntityId> SpatialEntity;
            [ReadOnly] private ComponentDataArray<Authoritative<SpatialOSPlayerInput>> PlayerInputAuthority;
            [ReadOnly] public ComponentDataArray<CommandRequestSender<SpatialOSServerShooting>> Sender;
            [ReadOnly] public ComponentDataArray<EventSender<SpatialOSClientShooting>> EventSender;
        }

        private struct ResponseData
        {
            public readonly int Length;

            [ReadOnly]
            public ComponentArray<CommandResponses<Generated.Playground.ServerShooting.AttemptShot.Response>> AttemptShotResponses;
        }

        [Inject] private PlayerData playerData;
        [Inject] private ResponseData responseData;

        protected override void OnUpdate()
        {
            for (var i = 0; i < playerData.Length; i++)
            {
                if (!Input.GetMouseButtonDown(0))
                {
                    continue;
                }

                var eventSender = playerData.EventSender[0];
                eventSender.SendShootEvent(new Generated.Playground.ShootDetails());

                var ray = Camera.main.ScreenPointToRay(UIComponent.Main.Reticle.transform.position);
                RaycastHit info;
                long? targetId;
                if (!Physics.Raycast(ray, out info) || info.rigidbody == null)
                {
                    targetId = null;
                }
                else
                {
                    var rigidBody = info.rigidbody;
                    targetId = rigidBody.gameObject.GetComponent<SpatialOSComponent>().SpatialEntityId;
                }

                var sender = playerData.Sender[0];
                var playerId = playerData.SpatialEntity[0].EntityId;

                sender.SendAttemptShotRequest(playerId, new Generated.Playground.ShotAttemptDetails
                {
                    Target = targetId
                });
            }

            for (var i = 0; i < responseData.Length; i++)
            {
                Debug.Log("Responses are not empty boy");
                var responses = responseData.AttemptShotResponses[i];

                foreach (var response in responses.Buffer)
                {
                    if (response.StatusCode != CommandStatusCode.Success)
                    {
                        continue;
                    }

                    var responsePayload = response.RawResponse;
                    var requestPayload = response.RawRequest;

                    if (responsePayload.HasValue && responsePayload.Value.Success)
                    {
                        Debug.Log("Shot was successful");
                    }
                }
            }
        }
    }
}
