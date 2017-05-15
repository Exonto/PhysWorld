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
		/// Defaults to having three vertices at (0,0) (1,1) (2,2)
		/// </summary>
		public Polygon()
		{
			this.Vertices = new List<Vertex>();
			this.Vertices.Add(new Vertex(0, 0));
			this.Vertices.Add(new Vertex(1, 1));
			this.Vertices.Add(new Vertex(2, 2));
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

		#region Polygon Operations

		/// <summary>
		/// A polygon is not considered valid unless it has three vertices.
		/// </summary>
		/// <returns>Whether the polygon has three or more vertices.</returns>
		public bool IsPolygon()
		{
			return this.Vertices.Count > 2;
		}

		/// <summary>
		/// Determines if this polygon is convex.
		/// A convex polygon is defined as having no internal angles greater
		/// than 180 degrees.
		/// </summary>
		/// <returns>Whether this polygon is convex.</returns>
		public bool IsConvex()
		{
			bool foundNegative = false;
			bool foundPositive = false;

			int totalVertices = this.Vertices.Count;

			int B;
			int C;
			for (int A = 0; A < totalVertices; A++)
			{
				B = (A + 1) % totalVertices;
				C = (B + 1) % totalVertices;

				Vertex vertA = this.Vertices.ElementAt(A);
				Vertex vertB = this.Vertices.ElementAt(B);
				Vertex vertC = this.Vertices.ElementAt(C);
				
				Vector vecAB = vertA.Pos.Subtract(vertB.Pos);
				Vector vecBC = vertB.Pos.Subtract(vertC.Pos);
				Vector crossProduct = vecAB.CrossProduct(vecBC);
				double zLength = crossProduct.Z;
				Logger.Log("Z = " + zLength);

				if (zLength < 0)
				{
					foundNegative = true;
				}
				else
				{
					foundPositive = true;
				}

				if (foundNegative && foundPositive)
				{
					return false;
				}
			}

			return true;
		}

		public bool IsConcave()
		{
			return !IsConvex();
		}

		#endregion
	}
}
