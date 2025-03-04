#if !(UNITY_WEBGL && !UNITY_EDITOR)

// #if FALSE
using System;

namespace UnityGram {
    public static partial class Telegram {
        #region Getters

        private static string GetInitData() => "";

        private static string GetInitDataUnsafe() => "{}";

        private static string GetVersion() => "6.0";

        private static string GetPlatform() => "unknown";

        private static string GetColorScheme() => "light";

        private static bool GetIsExpanded() => true;

        private static float GetViewportHeight() => 0;

        private static float GetViewportStableHeight() => GetViewportHeight();

        #endregion

        #region Event Listeners

        private static void AddEmptyEventListener(string eventType, Action handler) { }
        private static void AddViewportChangedEventListener(Action<bool> handler) { }

        #endregion

        #region Functions

        public static bool IsVersionAtLeast(string _) => false;
        public static void DisableVerticalSwipes() { }
        private static void RequestFullscreenPrivate() { }
        public static void Ready() { }
        public static void Expand() { }

        #endregion
    }
}

#endif