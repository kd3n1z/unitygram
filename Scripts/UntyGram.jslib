mergeInto(LibraryManager.library, {
  // Getters
  GetInitData: function () {
    return stringToNewUTF8(window.Telegram.WebApp.initData);
  },
  GetInitDataUnsafe: function () {
    return stringToNewUTF8(JSON.stringify(window.Telegram.WebApp.initDataUnsafe));
  },
  GetVersion: function () {
    return stringToNewUTF8(window.Telegram.WebApp.version);
  },
  GetPlatform: function () {
    return stringToNewUTF8(window.Telegram.WebApp.platform);
  },
  GetColorScheme: function () {
    return stringToNewUTF8(window.Telegram.WebApp.colorScheme);
  },
  GetIsExpanded: function() {
    return window.Telegram.WebApp.isExpanded === true;
  },
  GetViewportHeight: function() {
    return window.Telegram.WebApp.viewportHeight;
  },
  GetViewportStableHeight: function() {
    return window.Telegram.WebApp.viewportStableHeight;
  },
  
  // Event Listeners
  AddEmptyEventListener: function(eventType, callback) {
    window.Telegram.WebApp.onEvent(UTF8ToString(eventType), () => {
      {{{ makeDynCall('v', 'callback') }}} (buffer);
    });
  },
  AddViewportChangedEventListener: function(callback) {
    window.Telegram.WebApp.onEvent("viewportChanged", (data) => {
      {{{ makeDynCall('vb', 'callback') }}} (data.isStateStable);
    });
  },

  // Functions
  IsVersionAtLeast: function (version) {
    return window.Telegram.WebApp.isVersionAtLeast(UTF8ToString(version));
  },
  DisableVerticalSwipes: function () {
    window.Telegram.WebApp.disableVerticalSwipes();
  },
  RequestFullscreenPrivate: function () {
    window.Telegram.WebApp.requestFullscreen();
  },
  Ready: function () {
    window.Telegram.WebApp.ready();
  },
  Expand: function () {
    window.Telegram.WebApp.expand();
  },
});