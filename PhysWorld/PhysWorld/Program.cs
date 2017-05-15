using PhysWorld.PhysLogic;
using PhysWorld.PhysLogic.Bounding;
using PhysWorld.PhysLogic.Cartesian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysWorld
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Vertex v1 = new Vertex(30, 30);
			Vertex v2 = new Vertex(400, 125);
			Vertex v3 = new Vertex(300, 150);
			Vertex v4 = new Vertex(250, 150);
			Vertex v5 = new Vertex(40, 35);

			Polygon poly = new Polygon(v1, v2, v3, v4);
			Logger.Log(poly.IsConvex());

			PhysicsWorld world = new PhysicsWorld();
			world.Polygons.Add(poly);

			//PhysWorldForm physForm = new PhysWorldForm(world);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PhysWorldForm(world));

			//PhysLogic.Clock.Start();
			//Vector v = new Vector(3, -4);
			//v.Magnitude = 6;
			//Logger.Log(v.Y);
		}
	}
}
