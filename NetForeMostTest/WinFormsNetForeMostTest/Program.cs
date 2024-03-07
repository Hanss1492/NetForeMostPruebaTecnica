using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WinFormsNetForeMostTest.DataAcess.Utils;

namespace WinFormsNetForeMostTest
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
            // Obtener la cadena de conexión desde tu archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["NetForeMostTestContext"].ConnectionString;

            // Inicializar la configuración de la aplicación
            AppConfig.Initialize(connectionString);
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }
    }
}