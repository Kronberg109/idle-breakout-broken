using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using IronOcr;

namespace IdleBreakoutBroken
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void ReadText()
        {
            var ocr = new IronTesseract();

            using (var Input = new OcrInput(@"C:\Users\leohed02\source\repos\IdleBreakoutBroken\temps\grayscreenshot.png"))
            {
                var Result = ocr.Read(Input);
                Console.Write(Result.Text);
            }
        }

        private void TakeScreenshot(int xPos, int yPos, int xSize, int ySize)
        {
            Bitmap bitmap = new Bitmap(xSize,ySize);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(xPos, yPos, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            bitmap.Save(@"C:\Users\leohed02\source\repos\IdleBreakoutBroken\temps\screenshot.png");

            Bitmap c = new Bitmap(@"C:\Users\leohed02\source\repos\IdleBreakoutBroken\temps\screenshot.png");
            int x, y;

            // Loop through the images pixels to reset color.
            for (x = 0; x < c.Width; x++)
            {
                for (y = 0; y < c.Height; y++)
                {
                    Color pixelColor = c.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.R, pixelColor.R);
                    c.SetPixel(x, y, newColor); // Now greyscale
                }
            }

            c.Save(@"C:\Users\leohed02\source\repos\IdleBreakoutBroken\temps\grayscreenshot.png");
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void btn_screen_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakeScreenshot(1117, 101, 130, 26);
            ReadText();
            this.Show();
        }

        private async void btn_spam_Click(object sender, EventArgs e)
        {
            this.Hide();

            int[] coorX = new int[] { 388, 457, 520, 581, 651, 702, 769, 829, 896, 965, 1016, 1076, 1136, 1204, 1260 };
            int[] coorY = new int[] { 200, 229, 259, 288, 326, 359, 386, 418, 448, 482, 515, 543, 572, 607, 640, 667, 695, 732, 760, 789 };

            TakeScreenshot(0, 0, 1920, 1080);
            Bitmap k = new Bitmap(@"C:\Users\leohed02\source\repos\IdleBreakoutBroken\temps\screenshot.png");

            foreach (int x in coorX)
            {
                foreach (int y in coorY)
                {
                    var pc = k.GetPixel(x, y);
                    if(pc.R != 244 || pc.G != 238 || pc.B != 215)
                    {
                        SetCursorPos(x, y);
                        uint dx = (uint)x;
                        uint dy = (uint)y;
                        await Task.Delay(10);
                        for (int i = 0; i < 10; i++)
                        {
                            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, dx, dy, 0, 0);
                        }
                    }
                }
            }
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
    }
}