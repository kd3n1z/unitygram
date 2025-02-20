# unitygram

UnityGram is a JavaScript wrapper that enables Unity to interact with the Telegram Web App API.

## Installation

-   Open Package Manager
-   Add package from git URL:
    `https://github.com/kd3n1z/unitygram.git`

## Usage

In general, I’ve aimed to make the wrapper as close to the original as possible - names are identical, except for using `Telegram` instead of `window.Telegram.WebApp`.

API reference:
[https://core.telegram.org/bots/webapps#initializing-mini-apps](https://core.telegram.org/bots/webapps#initializing-mini-apps)

> [!IMPORTANT]
> UnityGram is still under development, so not all features of the original API are available yet.

> [!NOTE]
> During the `OnPostprocessBuild` process, the library injects a link to the Telegram JS script into `index.html` and modifies Unity's built-in script to enforce fullscreen mode, bypassing the default user-agent check. It also includes a basic visual loader by default, which can be disabled by defining `UNITYGRAM_NO_LOADER` in Unity.

Example:

```csharp
using UnityEngine;
using UnityGram;

public class Test : MonoBehaviour {
    private void OnGUI() {
        GUI.Label(new Rect(20, 20, 400, 1000), $@"- UnityGram Test -
initData: {Telegram.initData}
version: {Telegram.version}
platform: {Telegram.platform}
colorScheme: {Telegram.colorScheme}
isActive: {Telegram.isActive}
isExpanded: {Telegram.isExpanded}"
        );
    }
}
```

## License

This project is licensed under the MIT license. See the [LICENSE.md](LICENSE.md) file for details.
