using PhysWorld.PhysLogic.Bounding;
using PhysWorld.PhysLogic.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysWorld.PhysLogic
{
	public class PhysicsWorld
	{
		public PhysRender Render { get; set; }
		public List<Polygon> Polygons = new List<Polygon>();

		#region Constructors

		public PhysicsWorld()
		{
			this.Render = new PhysRender(this);
		}

		#endregion
	}
}
