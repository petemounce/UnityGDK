using Unity.Entities;
using UnityEngine;

namespace Improbable.Gdk.Core.MonoBehaviours
{
    public class SpatialOSComponent : MonoBehaviour
    {
        public long SpatialEntityId;
        public Entity Entity;
        public World World;
    }
}
