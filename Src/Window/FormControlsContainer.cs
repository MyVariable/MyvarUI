using MyVarUI.Drawing;
using MyVarUI.Events;
using MyVarUI.SDL;

namespace MyVarUI.Window
{
    internal class FormControlsContainer : ControlContainer
    {
        private ISDL _displayPort;
        private Form _form;

        public FormControlsContainer(Form form, ISDL displayPort)
        {
            this._form = form;
            this._displayPort = displayPort;
        }

        public override void Draw(Graphics g)
        {
            var mLoc = _displayPort.GetMouseLocation();
            var mState = _displayPort.GetMouseState();

            bool mouseWasOverControl = false;
            int count = Controls.Count;

            for (int c = 0; c < count; c++)
            {
                if (c > Controls.Count) break; //Prevent index out of range exceptions if the controls change.
                var i = Controls[c];
                //calualte Keybord events

                //calulate mouse events
                if (mLoc.X >= i.X && mLoc.X <= i.X + i.Width)
                {
                    if (mLoc.Y >= i.Y && mLoc.Y <= i.Y + i.Height)
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

            base.Draw(g);
        }
    }
}
