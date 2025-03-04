using System;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming
namespace UnityGram {
    [Serializable]
    public class WebAppInitData {
        [CanBeNull] public string query_id;
        [CanBeNull] public WebAppUser user;
        [CanBeNull] public WebAppUser receiver;
        [CanBeNull] public WebAppChat chat;
        [CanBeNull] public string chat_type;
        [CanBeNull] public string chat_instance;
        [CanBeNull] public string start_param;
        public long can_send_after;
        public long auth_date;
        public string hash;
        public string signature;
    }
}