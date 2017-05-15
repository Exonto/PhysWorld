using PhysWorld.PhysLogic.Bounding;
using PhysWorld.PhysLogic.Cartesian;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysWorld.PhysLogic.Rendering
{
	public class PhysRender
	{
		public PhysicsWorld World { get; set; }

		#region Constructors

		public PhysRender(PhysicsWorld world)
		{
			this.World = world;
		}

		#endregion

		#region StaticRendering

		static void FillCircle(Graphics g, Brush brush,
								  float centerX, float centerY, float radius)
		{
			g.FillEllipse(brush, centerX - radius, centerY - radius,
						  radius + radius, radius + radius);
		}

		#endregion

		#region Rendering

		public void RenderPolygons(Graphics graphics)
		{
			foreach (Polygon p in this.World.Polygons)
			{
				Vertex first = p.Vertices.ElementAt(0);
				Vertex previous = p.Vertices.ElementAt(0);
				Vertex current = null;
				for (int idx = 1; idx < p.Vertices.Count; idx++)
				{
					current = p.Vertices.ElementAt(idx);

					graphics.DrawLine(Pens.Black, (float)previous.X,
												  (float)previous.Y,
												  (float)current.X,
												  (float)current.Y);

					previous = current;
				}

				graphics.DrawLine(Pens.Black, (float)previous.X,
											  (float)previous.Y,
											  (float)first.X,
											  (float)first.Y);
			}
		}

		public void RenderVertices(Graphics graphics)
		{
			foreach (Polygon p in this.World.Polygons)
			{
				foreach (Vertex v in p.Vertices)
				{
					FillCircle(graphics, Brushes.Red, (float)v.X, (float)v.Y, 3);
				}
			}
		}

		#endregion
	}
}
