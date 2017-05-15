using PhysWorld.PhysLogic.Cartesian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysWorld.PhysLogic.Bounding
{
	/// <summary>
	/// A polygon is defined by multiple vertices connected together to form
	/// a shape. A polygon must have at least three vertices to be valid.
	/// </summary>
	public class Polygon
	{
		public List<Vertex> Vertices;

		#region Constructors

		/// <summary>
		/// Defaults to having a single vertex at (0, 0).
		/// </summary>
		public Polygon()
		{
			this.Vertices = new List<Vertex>();
			this.Vertices.Add(new Vertex(0, 0));
		}

		public Polygon(List<Vertex> vertices)
		{
			this.Vertices = vertices;
		}

		public Polygon(params Vertex[] vertices)
		{
			this.Vertices = new List<Vertex>(vertices);
		}

		#endregion

		#region Simple Operations

		/// <summary>
		/// A polygon is not considered valid unless it has three vertices.
		/// </summary>
		/// <returns>Whether the polygon has three or more vertices.</returns>
		public bool IsValid()
		{
			return this.Vertices.Count > 2;
		}

		#endregion
	}
}
