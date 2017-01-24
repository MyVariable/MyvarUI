using System;

namespace MyVarUI.SDL
{
    public interface ISDL
    {
        Action<SDL_EventType> HookEvents { get; set; }

        void Init();
        void CreateWindow(string name, int x, int y, int width, int height);

        void Clear(Color c);

        void SetPixel(int x, int y, Color c);

        void SetTitle(string title);

        void DrawText(string text, int x, int y, string font, int sizept, Color c);

        Point GetMouseLocation();

        MouseState GetMouseState();

        char[] KeyPresses();

        Size CalulateTextSize(string text, string font, int sizept);

        void SwapBuffer();
    }
}