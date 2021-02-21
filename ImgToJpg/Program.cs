using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ImgToJpg
{
	static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if(args!=null)
				Application.Run(new ImgToJpg(args));
			else
				Application.Run(new ImgToJpg());

		}
	}
}
