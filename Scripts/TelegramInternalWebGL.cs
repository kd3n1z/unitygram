#if UNITY_WEBGL && !UNITY_EDITOR
// #if TRUE
using System.Runtime.InteropServices;

namespace UnityGram {
    public static partial class Telegram {
        [DllImport("__Internal")]
        private static extern string GetInitData();

        [DllImport("__Internal")]
        private static extern string GetInitDataUnsafe();

        [DllImport("__Internal")]
        private static extern string GetVersion();

        [DllImport("__Internal")]
        private static extern string GetPlatform();

        [DllImport("__Internal")]
        private static extern string GetColorScheme();

        [DllImport("__Internal")]
        private static extern bool GetIsActive();

        [DllImport("__Internal")]
        private static extern bool GetIsExpanded();
    }
}

#endif