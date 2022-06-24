// See https://aka.ms/new-console-template for more information
using Hangfire;
using Hangfire.Logging;
using Hangfire.Logging.LogProviders;
using Hangfire.MemoryStorage;
using Hangfire.SqlServer;
using Hangfire.Storage.SQLite;

GlobalConfiguration.Configuration.UseSQLiteStorage("Datfaasdd409.db"); 
RecurringJob.AddOrUpdate(() => Console.WriteLine("Hello world"), Cron.Minutely);

using (new BackgroundJobServer())
{
    Console.WriteLine("Hangfire Server started. Press ENTER to exit...");
    Console.ReadLine();
}