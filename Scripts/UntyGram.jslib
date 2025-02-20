mergeInto(LibraryManager.library, {
  GetInitData: function () {
    const returnStr = window.Telegram.WebApp.initData;
    const bufferSize = lengthBytesUTF8(returnStr) + 1;
    const buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },
  GetInitDataUnsafe: function () {
    const returnStr = JSON.stringify(window.Telegram.WebApp.initDataUnsafe);
    const bufferSize = lengthBytesUTF8(returnStr) + 1;
    const buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },
  GetVersion: function () {
    const returnStr = window.Telegram.WebApp.version;
    const bufferSize = lengthBytesUTF8(returnStr) + 1;
    const buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },
  GetPlatform: function () {
    const returnStr = window.Telegram.WebApp.platform;
    const bufferSize = lengthBytesUTF8(returnStr) + 1;
    const buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },
  GetColorScheme: function () {
    const returnStr = window.Telegram.WebApp.colorScheme;
    const bufferSize = lengthBytesUTF8(returnStr) + 1;
    const buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },
  GetIsActive: function() {
    return window.Telegram.WebApp.isActive === true;
  },
  GetIsExpanded: function() {
    return window.Telegram.WebApp.isExpanded === true;
  },
});