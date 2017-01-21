using System.Collections.Generic;
using System.Runtime.InteropServices;
using MyvarUI.Drawing;
using MyvarUI.Events;
using MyvarUI.SDL;
using static MyvarUI.SDL.LinuxSdl;

namespace MyvarUI.Window
{
    public class Form
    {
        private ISDL displayPort;
        public Graphics Graphics { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

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


        public List<Control> Controls { get; set; } = new List<Control>();

        public Form()
        {
            X = 100;
            Y = 100;

            W = 800;
            H = 600;

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
        }

        public void Show()
        {
            Hidden = false;
            displayPort.CreateWindow(Title, X, Y, W, H);

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


            var mLoc = displayPort.GetMouseLocation();
            var mState = displayPort.GetMouseState();

            bool mouseWasOverControl = false;
            //draw controls
            for (int c = 0; c < Controls.Count; c++)
            {
                var i = Controls[c];
                //calualte Keybord events

                //calulate mouse events
                if (mLoc.X >= i.X && mLoc.X <= i.X + i.W)
                {
                    if (mLoc.Y >= i.Y && mLoc.Y <= i.Y + i.H)
                    {
                        mouseWasOverControl = true;
                        if (mState != MouseState.None)
                        {
                            foreach (var ctrl in Controls)
                            {
                                ctrl.Focused = false;
                            }

                            i.Focused = true;
                        }

                        i.FireMouseEvents(new MouseEventArgs() { MouseState = mState, X = mLoc.X, Y = mLoc.Y });
                    }

                }


                if (!i.Hidden)
                {
                    //draw our lovley control
                    i.Draw(Graphics);
                }
            }

            if (!mouseWasOverControl)
            {
                foreach (var ctrl in Controls)
                {
                    if (mState != MouseState.None)
                    {
                        ctrl.Focused = false;
                    }
                }
            }

            //swap buffer
            displayPort.SwapBuffer();
        }
    }
}