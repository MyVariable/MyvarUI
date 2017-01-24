using MyVarUI.Drawing;

namespace MyVarUI.Window.Controls
{
    public class Lable : Control
    {
        public string Text { get; set; } = "Lable";
        public int FontSize { get; set; } = 15;
        public Color FontColor { get; set; } = Color.White;

        public Lable()
        {
            X = 10;
            Y = 10;
        }
        public override void Draw(Graphics g)
        {
            g.DrawText(Text, X, Y, "", FontSize, FontColor);
        }
    }
}