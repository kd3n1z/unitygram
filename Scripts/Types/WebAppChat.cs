using System;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming
namespace UnityGram {
    /// <summary>
    /// This object represents a chat.
    /// </summary>
    [Serializable]
    public class WebAppChat {
        /// <summary>
        /// Unique identifier for this chat. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        public long id;
        /// <summary>
        /// Type of chat, can be either “group”, “supergroup” or “channel”
        /// </summary>
        public string type;
        /// <summary>
        /// Title of the chat
        /// </summary>
        public string title;
        /// <summary>
        /// <i>Optional.</i> Username of the chat
        /// </summary>
        [CanBeNull] public string username;
        /// <summary>
        /// <i>Optional.</i> URL of the chat’s photo. The photo can be in .jpeg or .svg formats. Only returned for Mini Apps launched from the attachment menu.
        /// </summary>
        [CanBeNull] public string photo_url;
    }
}