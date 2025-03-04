#if UNITY_WEBGL && !UNITY_EDITOR
// #if TRUE
using System;
using System.Runtime.InteropServices;

namespace UnityGram {
    public static partial class Telegram {
        #region Getters

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
        private static extern bool GetIsExpanded();

        [DllImport("__Internal")]
        private static extern float GetViewportHeight();

        [DllImport("__Internal")]
        private static extern float GetViewportStableHeight();

        #endregion

        #region Event Listeners

        [DllImport("__Internal")]
        private static extern void AddEmptyEventListener(string eventType, Action handler);

        [DllImport("__Internal")]
        private static extern void AddViewportChangedEventListener(Action<bool> handler);

        #endregion

        #region Functions

        [DllImport("__Internal")]
        public static extern bool IsVersionAtLeast(string v);

        [DllImport("__Internal")]
        public static extern void DisableVerticalSwipes();

        [DllImport("__Internal")]
        private static extern void RequestFullscreenPrivate();

        [DllImport("__Internal")]
        public static extern void Ready();

        [DllImport("__Internal")]
        public static extern void Expand();

        #endregion
    }
}

#endif