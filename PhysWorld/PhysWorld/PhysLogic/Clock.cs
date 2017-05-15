using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PhysWorld.PhysLogic
{
	static class Clock
	{
		static long UPDATE_CAP = 10;

		private static long GetCurrentTimeMS()
		{
			return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
		}

		public static void Start()
		{
			double previous = GetCurrentTimeMS();

			double accumulated = 0.0;
			
			while (true)
			{
				double current = GetCurrentTimeMS();

				double elapsed = current - previous;

				accumulated += elapsed;

				previous = current;

				while (accumulated >= UPDATE_CAP)
				{
					UpdateGame(UPDATE_CAP);

					accumulated -= UPDATE_CAP;
				}
			}
		}

		static void UpdateGame(long elapsed)
		{
			PhysLogic.PhysSim.UpdateWorlds(elapsed);
		}
	}
}
