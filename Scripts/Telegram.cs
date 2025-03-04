using AOT;
using System;
using UnityEngine;

namespace UnityGram {
    public static partial class Telegram {
        private static readonly bool Version8;

        // ReSharper disable InconsistentNaming

        #region Fields

        public static readonly string initData;

        public static readonly WebAppInitData initDataUnsafe;

        public static readonly string version;

        public static readonly string platform;

        public static string colorScheme { get; private set; }

        public static bool isActive { get; private set; }

        public static bool isExpanded => GetIsExpanded();

        public static float viewportHeight { get; private set; }
        public static float viewportStableHeight { get; private set; }

        #endregion

        // ReSharper restore InconsistentNaming

        #region Function Wrappers

        public static void RequestFullscreen() {
            if (!Version8) {
                throw new Exception("WebAppMethodUnsupported");
            }

            RequestFullscreenPrivate();
        }

        #endregion

        #region Events

        public static event Action OnActivated;
        public static event Action OnDeactivated;
        public static event Action OnThemeChanged;
        public static event Action<bool> OnViewportChanged;

        #endregion

        #region Helpers

        private static void UpdateColorScheme() {
            colorScheme = GetColorScheme();
        }

        private static void UpdateViewportHeight() {
            viewportHeight = GetViewportHeight();
            viewportStableHeight = GetViewportStableHeight();
        }

        #endregion

        #region Callbacks

        [MonoPInvokeCallback(typeof(Action))]
        private static void CallbackActivated() {
            isActive = true;
            OnActivated?.Invoke();
        }

        [MonoPInvokeCallback(typeof(Action))]
        private static void CallbackDeactivated() {
            isActive = false;
            OnDeactivated?.Invoke();
        }

        [MonoPInvokeCallback(typeof(Action))]
        private static void CallbackThemeChanged() {
            UpdateColorScheme();
            OnThemeChanged?.Invoke();
        }

        [MonoPInvokeCallback(typeof(Action<bool>))]
        private static void CallbackViewportChanged(bool isStateStable) {
            UpdateViewportHeight();
            OnViewportChanged?.Invoke(isStateStable);
        }

        #endregion

        static Telegram() {
            initData = GetInitData();
            initDataUnsafe = JsonUtility.FromJson<WebAppInitData>(GetInitDataUnsafe());

            version = GetVersion();
            platform = GetPlatform();

            Version8 = IsVersionAtLeast("8.0");

            if (Version8) {
                AddEmptyEventListener("activated", CallbackActivated);
                AddEmptyEventListener("deactivated", CallbackDeactivated);
            }

            AddEmptyEventListener("themeChanged", CallbackThemeChanged);
            AddViewportChangedEventListener(CallbackViewportChanged);
        }
    }
}