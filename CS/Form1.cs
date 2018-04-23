using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
// ...

namespace BrickStyles {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            printingSystem1.Begin();

            // Specify the style definitions.
            BrickStyle column_style1 = new BrickStyle(BorderSide.Left | BorderSide.Bottom | BorderSide.Top, 2,
                Color.Gold, Color.Navy, Color.DodgerBlue, new Font("Arial", 6, FontStyle.Bold |
                FontStyle.Italic), new BrickStringFormat(StringAlignment.Near, StringAlignment.Near));
            BrickStyle column_style2 = new BrickStyle(BorderSide.Top | BorderSide.Bottom, 2,
                Color.Navy, Color.DodgerBlue, Color.Gold, new Font("Arial", 6, FontStyle.Bold |
                FontStyle.Italic), new BrickStringFormat(StringAlignment.Center, StringAlignment.Center));
            BrickStyle column_style3 = new BrickStyle(BorderSide.Right | BorderSide.Bottom | BorderSide.Top, 2,
                Color.DodgerBlue, Color.Gold, Color.Navy, new Font("Arial", 6, FontStyle.Bold |
                FontStyle.Italic), new BrickStringFormat(StringAlignment.Far, StringAlignment.Far));

            BrickGraphics gr = printingSystem1.Graph;
            gr.Modifier = BrickModifier.Detail;
            string s = "XtraPrinting Library";
            TextBrick t_brick = new TextBrick();

            // Draw the first column and apply the style.
            for(int i = 0; i < 3; i++) {
                t_brick = gr.DrawString(s, new RectangleF(0, 20 * i, 100, 20));
                t_brick.Style = column_style1;
            }

            // Draw the second column and apply the style.
            for(int i = 0; i < 3; i++) {
                t_brick = gr.DrawString(s, new RectangleF(100, 20 * i, 100, 20));
                t_brick.Style = column_style2;
            }

            // Draw the first column and apply the style.
            for(int i = 0; i < 3; i++) {
                t_brick = gr.DrawString(s, new RectangleF(200, 20 * i, 100, 20));
                t_brick.Style = column_style3;
            }

            printingSystem1.End();
            printingSystem1.PreviewFormEx.Show();
        }

    }
}