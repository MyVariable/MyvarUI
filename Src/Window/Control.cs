using MyVarUI.Drawing;
using MyVarUI.Events;

namespace MyVarUI.Window
{
    public abstract class Control
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Focused { get; set; } = false;
        public bool Hidden { get; set; }

        public Control Parent { get; set; }

        public delegate void MouseClickEvent(object sender, MouseEventArgs args);
        public delegate void MouseUpEvent(object sender, MouseEventArgs args);
        public delegate void MouseDownEvent(object sender, MouseEventArgs args);
        public delegate void MouseHoverEvent(object sender, MouseEventArgs args);
        public event MouseClickEvent MouseClick;
        public event MouseUpEvent MouseUp;
        public event MouseDownEvent MouseDown;
        public event MouseHoverEvent MouseHover;

        private MouseState _lastState = MouseState.None; // click even should only fire once
        
        
        public virtual void FireKeybordEvents(KeybordEventArgs args)
        {
            
        }

        public void FireMouseEvents(MouseEventArgs args)
        {
            if (MouseHover != null)
            {
                MouseHover(this, args);
            }

            switch (args.MouseState)
            {
                case MouseState.Left:

                    if (MouseDown != null)
                    {
                        MouseDown(this, args);
                    }

                    break;
                case MouseState.None:
                    if (_lastState != MouseState.None)
                    {
                        if (MouseUp != null)
                        {
                            MouseUp(this, args);
                        }

                        if (MouseClick != null)
                        {
                            MouseClick(this, args);
                        }
                    }

                    break;
                default:
                    if (MouseDown != null)
                    {
                        MouseDown(this, args);
                    }
                    break;

            }
            _lastState = args.MouseState;
        }

        public abstract void Draw(Graphics g);
    }
}