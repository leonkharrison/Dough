using Dough.Database;
using Dough.Services.BankAccountService;
using Dough.Services.IncomeService;
using Dough.Services.OutgoingService;
using Dough.UI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Dough
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode( HighDpiMode.SystemAware );
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run( ServiceProvider.GetRequiredService<MainForm>() );
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices( ( context, services ) =>
            {
                services.AddDbContext<DoughDbContext>();
                services.AddTransient<MainForm>();
                services.AddTransient<BankAccountDetailsForm>();
                services.AddTransient<OutgoingDetailsForm>();
                services.AddScoped<IBankAccountService, BankAccountService>();
                services.AddScoped<IIncomeService, IncomeService>();
                services.AddScoped<IOutgoingService, OutgoingService>();
            } );
        }
    }
}