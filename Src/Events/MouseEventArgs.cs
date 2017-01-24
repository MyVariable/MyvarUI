namespace MyVarUI.Events
{
    public class MouseEventArgs : Event
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MouseState MouseState { get; set; }
    }
}