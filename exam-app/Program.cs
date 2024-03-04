namespace exam_app
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
<<<<<<< HEAD
			//Application.Run(new Form1());
			//Application.Run(new StartExamForm(1,117));
			Application.Run(new Form1());
=======

			Application.Run(new LoginForm());
>>>>>>> 78d2846f74b3d8c2dfc1a28f0d295cfe7f004b44


		}
	}
}