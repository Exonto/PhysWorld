using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysWorld.PhysLogic
{
	class PhysSim
	{
		public List<PhysWorld> PhysWorlds { get; }

		public static void UpdateWorlds(long elapsed)
		{
			Logger.Log(elapsed);
		}
	}
}
