using System;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming
namespace UnityGram {
    [Serializable]
    public class WebAppChat {
        public long id;
        public string type;
        public string title;
        [CanBeNull] public string username;
        [CanBeNull] public string photo_url;
    }
}