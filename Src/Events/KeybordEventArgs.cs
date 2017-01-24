namespace MyVarUI.Events
{
    public class KeybordEventArgs : Event
    {
        public KeybordState State { get; set; }
        public char[] Input { get; set; }
    }
}