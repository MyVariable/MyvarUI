using MyVarUI.SDL;

namespace MyVarUI.Drawing
{
    public class Graphics
    {
        private ISDL displayPort;

        public Graphics(ISDL displayport)
        {
            displayPort = displayport;
        }

        public void Clear(Color c)
        {
            displayPort.Clear(c);
        }

        public void SetPixel(int x, int y, Color c)
        {
            displayPort.SetPixel(x, y, c);
        }

        public void DrawText(string text, int x, int y, string font, int sizept, Color c)
        {
            displayPort.DrawText(text, x, y, "", sizept, c);
        }

        public Size CalulateTextSize(string text, string font, int sizept)
        {
            return displayPort.CalulateTextSize(text, font, sizept);
        }


        public void DrawLine(int x, int y, int x2, int y2, Color color)
        {
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = w;
            int shortest = h;
            if (!(longest > shortest))
            {
                longest = h;
                shortest = w;
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                SetPixel(x, y, color);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }

        public void DrawRectangle(int x, int y, int w, int h, Color c)
        {
            DrawLine(x, y, x + w, y, c);
            DrawLine(x, y, x, y + h, c);
            DrawLine(x, y + h, x + w, y + h, c);
            DrawLine(x + w, y, x + w, y + h, c);
        }

        public void DrawFillRectangle(int x, int y, int w, int h, Color c)
        {
            for (int x1 = x; x1 < x + w; x1++)
            {
                for (int y1 = y; y1 < y + h; y1++)
                {
                    SetPixel(x1, y1, c);
                }
            }
        }

    }
}