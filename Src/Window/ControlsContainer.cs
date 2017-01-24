using System.Collections;
using System.Collections.Generic;
using MyVarUI.Drawing;

namespace MyVarUI.Window
{
    public class ControlContainer : Control, IContainerControl, IEnumerable<Control>
    {
        private Control _activeControl;
        private object _activeLock = new object();

        protected List<Control> Controls { get; }
        public ControlContainer()
        {
            Controls = new List<Control>();
        }

        public Control ActiveControl
        {
            get
            {
                return _activeControl;
            }
            set { ActivateControl(value); }
        }

        public bool ActivateControl(Control active)
        {
            if (!this.Controls.Contains(active)) return false;
            lock (_activeLock)
            {
                _activeControl.Focused = false;
                active.Focused = true;
                _activeControl = active;
            }
            return true;
        }

        public bool Contains(Control control)
        {
            return Controls.Contains(control);
        }

        public void Add(Control control)
        {
            Controls.Add(control);
        }

        public bool Remove(Control control)
        {
            return Controls.Remove(control);
        }

        public override void Draw(Graphics g)
        {
            int count = Controls.Count;
            
            for (int c = 0; c < count; c++)
            {
                if (c > Controls.Count) break; //Prevent index out of range exceptions if the controls change.
                var i = Controls[c];

                i.Draw(g);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Control> GetEnumerator()
        {
            Control[] controls = Controls.ToArray();
            foreach (var i in controls)
            {
                yield return i;
            }
        }
    }
}
