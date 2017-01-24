using MyVarUI.Drawing;
using MyVarUI.Events;

namespace MyVarUI.Window.Controls
{
    public class TextBox : Control
    {
        public string Text { get; set; } = "";

        public TextBox()
        {
            X = 10;
            Y = 10;

            Width = 100;
            Height = 25;
        }

        public override void FireKeybordEvents(KeybordEventArgs args)
        {

            if(args.State == KeybordState.TextInput)
            {
              /*  foreach(var c in args.Input)
                {
                    Text += c;
                }*/
                Text += args.Input[0];
            }

            base.FireKeybordEvents(args);
        }

        public override void Draw(Graphics g)
        {

            //draw white box where button should be
            g.DrawFillRectangle(X, Y, Width, Height, Color.White);

            if (!string.IsNullOrEmpty(Text))
            {
                //draw text
                g.DrawText(Text, X, Y, "", 15, Color.Black);
            }

            if (Focused)
            {
                g.DrawRectangle(X, Y, Width - 1, Height - 1, Color.Blue);
            }
        }
    }
}