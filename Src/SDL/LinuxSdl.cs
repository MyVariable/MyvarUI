using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MyVarUI.SDL.Wrappers;

namespace MyVarUI.SDL
{
    public unsafe class LinuxSdl : ISDL
    {

        public Action<SDL_EventType> HookEvents { get; set; } = (x) =>
        {
            Console.WriteLine("Event: " + x.ToString());
        };

        private void* window;
        private void* renderer;

        public void Clear(Color c)
        {
            LinuxSDLWrapper.SDL_SetRenderDrawColor(renderer, c.R, c.G, c.B, c.A);
            LinuxSDLWrapper.SDL_RenderClear(renderer);
        }

        public void CreateWindow(string name, int x, int y, int width, int height)
        {
            void* w = window, r = renderer;
            LinuxSDLWrapper.SDL_CreateWindowAndRenderer(width, height, 0, &w, &r);
            LinuxSDLWrapper.SDL_SetWindowTitle(w, name);
            window = w; renderer = r;
            DumpErrors();
        }

        public void Init()
        {
            var init = LinuxSDLWrapper.TTF_Init();
            if (LinuxSDLWrapper.SDL_Init((UInt32)SdlInit.SDL_INIT_VIDEO) < 0)
            {
                DumpErrors();
                Console.WriteLine("SDL or TTF Init Failed");

            }
        }

        public void SetPixel(int x, int y, Color c)
        {
            LinuxSDLWrapper.SDL_SetRenderDrawColor(renderer, c.R, c.G, c.B, c.A);
            LinuxSDLWrapper.SDL_RenderDrawPoint(renderer, x, y);
        }

        public void SwapBuffer()
        {
            LinuxSDLWrapper.SDL_RenderPresent(renderer);

            /* TODO: Implment a real event system*/
            byte[] buf = new byte[200];

            fixed (byte* ptr = buf)
            {
                /*
                This is super hackey but i chould not get it to work normal way,
                if some one know how to make this work in a non hack way pleae fix it
                */
                if (LinuxSDLWrapper.SDL_PollEvent(ptr) == 1)
                {
                    var type = BitConverter.ToUInt32(buf, 0);

                    HookEvents((SDL_EventType)type);

                    if (type == (uint)SDL_EventType.SDL_QUIT)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }


        private void DumpErrors()
        {
            int loopc = 1;

            while (loopc > 0)
            {
                var error = LinuxSDLWrapper.SDL_GetError();
                int indch = 0;
                var chr = error[indch++];
                var byts = new List<Byte>();
                while (chr != 0)
                {
                    byts.AddRange(BitConverter.GetBytes(chr));
                    chr = error[indch++];
                }
                loopc = chr;
                Console.WriteLine(Encoding.ASCII.GetString(byts.ToArray()));
                //Console.WriteLine(SDL_GetBasePath());
            }
        }

        public void SetTitle(string title)
        {
            LinuxSDLWrapper.SDL_SetWindowTitle(window, title);
        }

        public void DrawText(string text, int x, int y, string font, int sizept, Color c)
        {

            var afont = LinuxSDLWrapper.TTF_OpenFont(Path.GetFullPath("./Fonts/SourceCodePro.ttf"), sizept);

            var surface = LinuxSDLWrapper.TTF_RenderText_Solid(afont, text, c);
            SDL_Surface WHRef = (SDL_Surface)Marshal.PtrToStructure(new IntPtr(surface), typeof(SDL_Surface));
            var texture = LinuxSDLWrapper.SDL_CreateTextureFromSurface(renderer, surface);
            var rect = new SDL_Rect()
            {
                w = WHRef.w,
                h = WHRef.h,
                x = x,
                y = y
            };

            var res = LinuxSDLWrapper.SDL_RenderCopy(renderer, texture, null, &rect);

        }

        public Size CalulateTextSize(string text, string font, int sizept)
        {
            var afont = LinuxSDLWrapper.TTF_OpenFont(Path.GetFullPath("./Fonts/SourceCodePro.ttf"), sizept);

            var surface = LinuxSDLWrapper.TTF_RenderText_Solid(afont, text, Color.White);
            SDL_Surface WHRef = (SDL_Surface)Marshal.PtrToStructure(new IntPtr(surface), typeof(SDL_Surface));


            return new Size(WHRef.w, WHRef.h);
        }

        public char[] KeyPresses()
        {
            var re = new List<char>();

            int lenth = 0;
            var state = LinuxSDLWrapper.SDL_GetKeyboardState(ref lenth);

            for (var i = 0; i < lenth; i++)
            {
                if (state[i] == 1)
                {
                    var scancode = (SDL_Scancode)i;
                    re.Add(scancode.ToString().Split('_').Last().ToLower()[0]);
                }
            }

            return re.ToArray();
        }

        public Point GetMouseLocation()
        {
            int x = 0, y = 0;

            LinuxSDLWrapper.SDL_GetMouseState(ref x, ref y);

            return new Point(x, y);
        }

        public MouseState GetMouseState()
        {

            int x = 0, y = 0;

            var mask = LinuxSDLWrapper.SDL_GetMouseState(ref x, ref y);

            return (MouseState)SDL_BUTTON(mask);
        }

        private int SDL_BUTTON(uint x) => (int)(1 << ((int)x - 1));
    }
}