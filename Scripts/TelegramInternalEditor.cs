#if !(UNITY_WEBGL && !UNITY_EDITOR)

// #if FALSE
namespace UnityGram {
    public static partial class Telegram {
        private static string GetInitData() => "";

        private static string GetInitDataUnsafe() => "{}";

        private static string GetVersion() => "6.0";

        private static string GetPlatform() => "unknown";

        private static string GetColorScheme() => "light";

        private static bool GetIsActive() => true;

        private static bool GetIsExpanded() => true;
    }
}

#endif