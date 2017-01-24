using System;
using System.Runtime.InteropServices;

namespace MyVarUI.SDL.Wrappers
{
    public unsafe class LinuxSDLWrapper
    {
        public const string _libsdl = "./Libs/Linux/libSDL2-2.0.so.0.4.0";
        public const string _libsdl_ttf = "./Libs/Linux/libSDL2_ttf-2.0.so.0.14.0";

        [DllImport(_libsdl)]
        public static extern byte* SDL_GetKeyboardState(ref int numkeys);


        [DllImport(_libsdl)]
        public static extern uint SDL_GetMouseState(ref int x, ref int y);


        [DllImport(_libsdl_ttf)]
        public static extern void* TTF_RenderGlyph_Solid(void* font, ushort ch, ColorStruct fg);

        [DllImport(_libsdl)]
        public static extern int SDL_BlitSurface(void* src, void* srcrect, void* dst, void* dstrect);


        [DllImport(_libsdl)]
        public static extern void* SDL_RWFromFile([MarshalAs(UnmanagedType.LPStr)] string file, [MarshalAs(UnmanagedType.LPStr)] string mode);

        [DllImport(_libsdl)]
        public static extern int SDL_SaveBMP_RW(void* surface, void* io, int freedst);



        [DllImport(_libsdl)]
        public static extern int SDL_SaveBMP(void* surface, string file);

        [DllImport(_libsdl)]
        public static extern int SDL_SetRenderTarget(void* renderer, void* texture);


        [DllImport(_libsdl)]
        public static extern int SDL_RenderCopy(void* renderer, void* texture, SDL_Rect* srcrect, SDL_Rect* dstrect);

        [DllImport(_libsdl)]
        public static extern string SDL_GetBasePath();

        [DllImport(_libsdl_ttf)]
        public static extern int TTF_Init();

        [DllImport(_libsdl_ttf)]
        public static extern void* TTF_RenderText_Shaded(void* font, [MarshalAs(UnmanagedType.LPStr)] string text, ColorStruct fg, ColorStruct bg);

        [DllImport(_libsdl)]
        public static extern void* SDL_CreateTextureFromSurface(void* renderer, void* surface);

        [DllImport(_libsdl)]
        public static extern short* SDL_GetError();

        [DllImport(_libsdl_ttf)]
        public static extern void* TTF_RenderText_Solid(void* font, [MarshalAs(UnmanagedType.LPStr)] string text, ColorStruct fg);

        [DllImport(_libsdl_ttf)]
        public static extern void* TTF_OpenFont(string filename, int ptsize);

        [DllImport(_libsdl)]
        public static extern int SDL_Init(UInt32 flags);

        [DllImport(_libsdl)]
        public static extern int SDL_CreateWindowAndRenderer(int width, int height, uint window_flags, void** window, void** renderer);

        [DllImport(_libsdl)]
        public static extern int SDL_RenderDrawPoint(void* renderer, int x, int y);

        [DllImport(_libsdl)]
        public static extern void SDL_RenderPresent(void* renderer);

        [DllImport(_libsdl)]
        public static extern void SDL_SetWindowTitle(void* window, string title);

        [DllImport(_libsdl)]
        public static extern int SDL_SetRenderDrawColor(void* renderer, byte r, byte g, byte b, byte a);

        [DllImport(_libsdl)]
        public static extern int SDL_RenderClear(void* renderer);


        [DllImport(_libsdl)]
        public static extern int SDL_PollEvent(byte* aEvent);

        [DllImport(_libsdl)]
        public static extern void SDL_DestroyRenderer(void* renderer);

        [DllImport(_libsdl)]
        public static extern void SDL_DestroyWindow(void* renderer);

        [DllImport(_libsdl)]
        public static extern void SDL_Quit();

        [DllImport(_libsdl)]
        public static extern void* SDL_CreateRenderer(void* window, int index, uint flags);

        [DllImport(_libsdl)]
        public static extern void* SDL_CreateWindow(string title, int x, int y, int w, int h, uint flags);

    }
}