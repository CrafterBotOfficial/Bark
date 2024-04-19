using Bark.Gestures;
using GorillaExtensions;
using HarmonyLib;

namespace Bark.Patches
{
    [HarmonyPatch(typeof(VRRig), "Awake")]
    public static class VRRigPatch
    {
        private static void Postfix(VRRig __instance)
        {
            if (__instance.isOfflineVRRig)
            {
                GestureTracker.localRigPath = __instance.transform.GetPath() + "/";
            }
        }
    }
}
