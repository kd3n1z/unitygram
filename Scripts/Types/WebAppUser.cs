using System;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming
namespace UnityGram {
    [Serializable]
    public class WebAppUser {
        public long id;
        public bool is_bot;
        public string first_name;
        [CanBeNull] public string last_name;
        [CanBeNull] public string username;
        [CanBeNull] public string language_code;
        public bool is_premium;
        public bool added_to_attachment_menu;
        public bool allows_write_to_pm;
        [CanBeNull] public string photo_url;
    }
}