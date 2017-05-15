using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysWorld.PhysLogic.Cartesian
{
	/// <summary>
	/// A vertex is used to define a single point or "corner" of some two
	/// dimensional polygon.
	/// </summary>
	public class Vertex
	{
		public Vector Pos { get; set; }
		public double X
		{
			get
			{
				return this.Pos.X;
			}

			set
			{
				this.Pos.X = value;
			}
		}
		public double Y
		{
			get
			{
				return this.Pos.Y;
			}

			set
			{
				this.Pos.Y = value;
			}
		}


		private Vector[] _adjacent = new Vector[2];

		#region Constructors

		public Vertex()
		{
			this.Pos = new Vector(); 
		}

		public Vertex(double x, double y)
		{
			this.Pos = new Vector(x, y);
		}

		public Vertex(Vector v)
		{
			this.Pos = v;
		}

		#endregion



		#region Getters/Setters

		

		#endregion
	}
}
