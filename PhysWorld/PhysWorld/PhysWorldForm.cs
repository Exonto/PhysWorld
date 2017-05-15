using PhysWorld.PhysLogic;
using PhysWorld.PhysLogic.Bounding;
using PhysWorld.PhysLogic.Cartesian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysWorld
{
	public partial class PhysWorldForm : Form
	{
		public PhysicsWorld World { get; set; }
		public PhysWorldForm(PhysicsWorld activeWorld)
		{
			this.World = activeWorld;

			InitializeComponent();
		}

		void Render()
		{
			System.Drawing.Graphics graphics = this.CreateGraphics();

			this.World.Render.RenderPolygons(graphics);
			//this.World.Render.RenderVertices(graphics);

			graphics.Dispose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Render();
		}
	}
}
