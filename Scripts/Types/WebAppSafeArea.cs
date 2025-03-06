using System;

namespace UnityGram {
    [Serializable]
    public struct WebAppSafeArea {
        public int top;
        public int bottom;
        public int left;
        public int right;

        public WebAppSafeArea(int top, int bottom, int left, int right) {
            this.top = top;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
        }

        public static WebAppSafeArea operator +(WebAppSafeArea a, WebAppSafeArea b) {
            return new WebAppSafeArea(
                a.top + b.top,
                a.bottom + b.bottom,
                a.left + b.left,
                a.right + b.right
            );
        }

        public static WebAppSafeArea operator -(WebAppSafeArea a, WebAppSafeArea b) {
            return new WebAppSafeArea(
                a.top - b.top,
                a.bottom - b.bottom,
                a.left - b.left,
                a.right - b.right
            );
        }

        public override string ToString() {
            return $"({top},{bottom},{left},{right})";
        }
    }
}