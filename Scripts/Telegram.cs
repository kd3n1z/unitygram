using UnityEngine;

namespace UnityGram {
    public static partial class Telegram {
        // ReSharper disable InconsistentNaming
        /// <summary>
        /// A string with raw data transferred to the Mini App, convenient for <a href="https://core.telegram.org/bots/webapps#validating-data-received-via-the-mini-app">validating data</a>.<br/>
        /// <b>WARNING:</b> <a href="https://core.telegram.org/bots/webapps#validating-data-received-via-the-mini-app">Validate data</a> from this field before using it on the bot's server.
        /// </summary>
        public static readonly string initData;

        /// <summary>
        /// An object with input data transferred to the Mini App.<br/>
        /// <b>WARNING:</b> Data from this field should not be trusted. You should only use data from initData on the bot's server and only after it has been <a href="https://core.telegram.org/bots/webapps#validating-data-received-via-the-mini-app">validated.</a>
        /// </summary>
        public static readonly WebAppInitData initDataUnsafe;

        /// <summary>
        /// The version of the Bot API available in the user's Telegram app.
        /// </summary>
        public static readonly string version;

        /// <summary>
        /// The name of the platform of the user's Telegram app.
        /// </summary>
        public static readonly string platform;

        /// <summary>
        /// The color scheme currently used in the Telegram app. Either “light” or “dark”.
        /// </summary>
        public static string colorScheme => GetColorScheme();

        /// <summary>
        /// <b>Bot API 8.0+</b> <i>True</i>, if the Mini App is currently active. <i>False</i>, if the Mini App is minimized.
        /// </summary>
        public static bool isActive => GetIsActive();

        /// <summary>
        /// <i>True</i>, if the Mini App is expanded to the maximum available height. <i>False</i>, if the Mini App occupies part of the screen and can be expanded to the full height using the <b>expand()</b> method.
        /// </summary>
        public static bool isExpanded => GetIsExpanded();

        // ReSharper restore InconsistentNaming

        static Telegram() {
            initData = GetInitData();
            initDataUnsafe = JsonUtility.FromJson<WebAppInitData>(GetInitDataUnsafe());

            version = GetVersion();
            platform = GetPlatform();
        }
    }
}