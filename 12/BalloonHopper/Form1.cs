using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            for (int balloon = 30; balloon <= 330; balloon = balloon + 60)
            {
                graphics.FillEllipse(Brushes.Violet, balloon, 50, 46, 66);
            }

            for (int thread = 53; thread <= 353; thread = thread + 60)
                graphics.DrawLine(Pens.BlueViolet, thread, 116, 210, 300); 

			// бобр
			DrawHopper(208, 240);
		}

		private void DrawHopper(int x, int y) {
			Image img = Image.FromFile("../../Hopper-Jumping.png");
			graphics.DrawImage(img, x, y);
		}
	}
}
