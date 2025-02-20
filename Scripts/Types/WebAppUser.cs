using System;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming
namespace UnityGram {
    /// <summary>
    /// This object contains the data of the Mini App user.
    /// </summary>
    [Serializable]
    public class WebAppUser {
        /// <summary>
        /// A unique identifier for the user or bot. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. It has at most 52 significant bits, so a 64-bit integer or a double-precision float type is safe for storing this identifier.
        /// </summary>
        public long id;
        /// <summary>
        /// <i>Optional.</i> True, if this user is a bot. Returns in the receiver field only.
        /// </summary>
        public bool is_bot;
        /// <summary>
        /// First name of the user or bot.
        /// </summary>
        public string first_name;
        /// <summary>
        /// <i>Optional.</i> Last name of the user or bot.
        /// </summary>
        [CanBeNull] public string last_name;
        /// <summary>
        /// <i>Optional.</i> Username of the user or bot.
        /// </summary>
        [CanBeNull] public string username;
        /// <summary>
        /// <i>Optional.</i> <a href="https://en.wikipedia.org/wiki/IETF_language_tag">IETF language tag</a> of the user's language. Returns in user field only.
        /// </summary>
        [CanBeNull] public string language_code;
        /// <summary>
        /// <i>Optional.</i> True, if this user is a Telegram Premium user.
        /// </summary>
        public bool is_premium;
        /// <summary>
        /// <i>Optional.</i> True, if this user added the bot to the attachment menu.
        /// </summary>
        public bool added_to_attachment_menu;
        /// <summary>
        /// <i>Optional.</i> True, if this user allowed the bot to message them.
        /// </summary>
        public bool allows_write_to_pm;
        /// <summary>
        /// <i>Optional.</i> URL of the user’s profile photo. The photo can be in .jpeg or .svg formats.
        /// </summary>
        [CanBeNull] public string photo_url;
    }
}