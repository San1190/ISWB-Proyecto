using GestAca.Services;

namespace GestAcaGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IGestAcaService service = new GestAcaService(new GestAca.Persistence.EntityFrameworkDAL(new GestAca.Persistence.GestAcaDbContext()));
            service.DBInitialization();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GestAcaAPP(service));
        }
    }
}