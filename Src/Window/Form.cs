using System.Collections.Generic;
using System.Runtime.InteropServices;
using MyVarUI.Drawing;
using MyVarUI.Events;
using MyVarUI.SDL;

namespace MyVarUI.Window
{
    public class Form
    {
        private ISDL displayPort;
        public Graphics Graphics { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Hidden { get; set; } = true;

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                displayPort.SetTitle(value);
            }
        }

        public ControlContainer Controls { get; private set; }

        public Form()
        {
            X = 100;
            Y = 100;

            Width = 800;
            Height = 600;

            bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            if(isLinux)
            {
                 displayPort = new LinuxSdl();
            }
            else if(isWindows)
            {
                 displayPort = new WindowsSdl();
            }
           
            displayPort.Init();
            Graphics = new Graphics(displayPort);
            Controls = new FormControlsContainer(this, displayPort)
            {
                X = 0,
                Y = 0,
                Width = Width,
                Height = Height
            };
        }

        public void Show()
        {
            Hidden = false;
            displayPort.CreateWindow(Title, X, Y, Width, Height);

            displayPort.HookEvents = (x) =>
            {
                if (x == SDL_EventType.SDL_KEYUP
                || x == SDL_EventType.SDL_TEXTINPUT
                || x == SDL_EventType.SDL_KEYDOWN)
                {
                    var kState = displayPort.KeyPresses();

                    foreach (var i in Controls)
                    {
                        var kbst = new KeybordEventArgs();

                        switch (x)
                        {
                            case SDL_EventType.SDL_KEYUP:
                                kbst.State = KeybordState.KeyUp;
                                break;
                            case SDL_EventType.SDL_TEXTINPUT:
                                kbst.State = KeybordState.TextInput;
                                break;
                            case SDL_EventType.SDL_KEYDOWN:
                                kbst.State = KeybordState.KeyDown;
                                break;
                        }

                        if (kState.Length != 0)
                        {
                            kbst.Input = kState;

                            i.FireKeybordEvents(kbst);
                        }
                    }
                }
            };
        }

        public void Draw()
        {
            //clear displayPort
            displayPort.Clear(Color.Gray);

            Controls.Draw(Graphics);

            //swap buffer
            displayPort.SwapBuffer();
        }
    }
}