using AnicStockControl.Data;
using AnicStockControl.Screens;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AnicStockControl
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Application.StartupPath).Build();

            services.AddDbContext<AnicStockControlContext>(options => options.UseMySQL(configuration.GetConnectionString("MySQLConnectionString")));

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new StartupScreen());
        }
    }
}
