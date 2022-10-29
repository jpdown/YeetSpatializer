using SiraUtil.Affinity;
using UnityEngine;

namespace YeetSpatializer.Patches
{
    public class DisableSpatializerPatch : IAffinity
    {
        [AffinityPatch(typeof(DisableSpatializerOnOldWindows), nameof(DisableSpatializerOnOldWindows.Awake))]
        internal void Postfix(AudioSource ____audioSource)
        {
            ____audioSource.spatialize = false;
        }
    }
}