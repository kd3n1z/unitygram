using System;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming
namespace UnityGram {
    /// <summary>
    /// This object contains data that is transferred to the Mini App when it is opened. It is empty if the Mini App was launched from a <a href="https://core.telegram.org/bots/webapps#keyboard-button-mini-apps">keyboard button</a> or from <a href="https://core.telegram.org/bots/webapps#inline-mode-mini-apps">inline mode.</a>
    /// </summary>
    [Serializable]
    public class WebAppInitData {
        /// <summary>
        /// <i>Optional.</i> A unique identifier for the Mini App session, required for sending messages via the answerWebAppQuery method
        /// </summary>
        [CanBeNull] public string query_id;
        /// <summary>
        /// <i>Optional.</i> An object containing data about the current user.
        /// </summary>
        [CanBeNull] public WebAppUser user;
        /// <summary>
        /// <i>Optional.</i> An object containing data about the chat partner of the current user in the chat where the bot was launched via the attachment menu. Returned only for private chats and only for Mini Apps launched via the attachment menu.
        /// </summary>
        [CanBeNull] public WebAppUser receiver;
        /// <summary>
        /// <i>Optional.</i> An object containing data about the chat where the bot was launched via the attachment menu. Returned for supergroups, channels and group chats – only for Mini Apps launched via the attachment menu.
        /// </summary>
        [CanBeNull] public WebAppChat chat;
        /// <summary>
        /// <i>Optional.</i> Type of the chat from which the Mini App was opened. Can be either “sender” for a private chat with the user opening the link, “private”, “group”, “supergroup”, or “channel”. Returned only for Mini Apps launched from direct links.
        /// </summary>
        [CanBeNull] public string chat_type;
        /// <summary>
        /// <i>Optional.</i> Global identifier, uniquely corresponding to the chat from which the Mini App was opened. Returned only for Mini Apps launched from a direct link.
        /// </summary>
        [CanBeNull] public string chat_instance;
        /// <summary>
        /// <i>Optional.</i> The value of the <b>startattach</b> parameter, passed via link. Only returned for Mini Apps when launched from the attachment menu via link.
        /// <br/><br/>
        /// The value of the start_param parameter will also be passed in the GET-parameter tgWebAppStartParam, so the Mini App can load the correct interface right away.
        /// </summary>
        [CanBeNull] public string start_param;
        /// <summary>
        /// <i>Optional.</i> Time in seconds, after which a message can be sent via the <a href="https://core.telegram.org/bots/api#answerwebappquery">answerWebAppQuery</a> method.
        /// </summary>
        public long can_send_after;
        /// <summary>
        /// Unix time when the form was opened.
        /// </summary>
        public long auth_date;
        /// <summary>
        /// A hash of all passed parameters, which the bot server can use to <a href="https://core.telegram.org/bots/webapps#validating-data-received-via-the-mini-app">check their validity</a>.
        /// </summary>
        public string hash;
        /// <summary>
        /// A signature of all passed parameters (except hash), which the third party can use to <a href="https://core.telegram.org/bots/webapps#validating-data-received-via-the-mini-app">check their validity</a>.
        /// </summary>
        public string signature;
    }
}