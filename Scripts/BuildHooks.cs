#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;

namespace UnityGram {
    public static class BuildHooks {
        private const string ModuleName = nameof(UnityGram);
        private const string HtmlComment = "<!-- " + ModuleName + " -->";

        private const string PreInject = @"<script src=""https://telegram.org/js/telegram-web-app.js?56""></script>";
        private const string PostInject = @"<script>
      function _unityGramCreateLoader() {
        const unityCanvasStyle = document.getElementById('unity-canvas').style;
        document.body.style.setProperty('background', unityCanvasStyle.getPropertyValue('background'));
        unityCanvasStyle.setProperty('background', 'transparent');

        document.head.appendChild(document.createElement('style')).sheet.insertRule('@keyframes spin { from {transform: rotateZ(0deg)} to {transform: rotateZ(360deg)} }');

        const loaderDiv = document.createElement('div');
        loaderDiv.innerHTML = 'Loading...<svg class=""spinner"" xmlns=""http://www.w3.org/2000/svg"" height=""24px"" viewBox=""0 -960 960 960"" width=""24px"" fill=""currentColor""><path d=""M480-80q-82 0-155-31.5t-127.5-86Q143-252 111.5-325T80-480q0-83 31.5-155.5t86-127Q252-817 325-848.5T480-880q17 0 28.5 11.5T520-840q0 17-11.5 28.5T480-800q-133 0-226.5 93.5T160-480q0 133 93.5 226.5T480-160q133 0 226.5-93.5T800-480q0-17 11.5-28.5T840-520q17 0 28.5 11.5T880-480q0 82-31.5 155t-86 127.5q-54.5 54.5-127 86T480-80Z""/></svg>';
        loaderDiv.style = 'color: white; position: fixed; z-index: -100; top: 50%; left: 50%; transform: translate(-50%, -50%); display: flex; flex-direction: column; align-items: center; font-family: system-ui, -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, Ubuntu, ""Helvetica Neue"", Oxygen, Cantarell, sans-serif; gap: 4px; pointer-events: none';
        loaderDiv.lastChild.style = 'width: 48px; height: 48px; animation: spin 1s linear infinite';
        document.body.appendChild(loaderDiv);
      }

      _unityGramCreateLoader();
    </script>";

        [PostProcessBuild(1)]
        public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) {
            if (target != BuildTarget.WebGL) {
                return;
            }

            string indexPath = Path.Combine(pathToBuiltProject, "index.html");

            File.WriteAllText(indexPath,
                File.ReadAllText(indexPath)
                    .Replace("if (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)) {", "if (true) { // " + ModuleName) // always use full screen
                    .Replace("</title>\n  </head>", "</title>\n    " + PreInject + " " + HtmlComment + "\n  </head>") // Pre-inject
#if !UNITYGRAM_NO_LOADER
                    .Replace("</script>\n  </body>", "</script>\n    " + PostInject + "\n    " + HtmlComment + "\n  </body>") // Post-inject
#endif
            );
        }
    }
}

#endif