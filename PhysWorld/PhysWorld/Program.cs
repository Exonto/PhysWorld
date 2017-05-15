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
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new PhysWorldForm());

			//PhysLogic.Clock.Start();
			Vector v = new Vector(3, -4);
			v.Magnitude = 6;
			Logger.Log(v.Y);
		}
	}
}
