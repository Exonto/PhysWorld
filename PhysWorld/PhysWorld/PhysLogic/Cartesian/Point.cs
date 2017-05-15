using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysWorld.PhysLogic.Cartesian
{
	/// <summary>
	/// This is used to define a single cartesian point on a 2D grid.
	/// </summary>
	class Point
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Point()
		{
			X = 0;
			Y = 0;
		}

		public Point(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		public Point Add(Point p)
		{
			return new Point(this.X + p.X, this.Y + p.Y);
		}

		public Point Add(double x, double y)
		{
			return new Point(this.X + x, this.Y + y);
		}
	}
}
