// See https://aka.ms/new-console-template for more information
using Hangfire;
using Hangfire.Storage.SQLite;

GlobalConfiguration.Configuration.UseSQLiteStorage("EnailService.db"); 
RecurringJob.AddOrUpdate(() => EmailJob.SendEmail(), Cron.Minutely);

using (new BackgroundJobServer())
{
    Console.WriteLine("Hangfire Server started. Press ENTER to exit...");
    Console.ReadLine();
}

static class EmailJob
{
    public static void SendEmail()
    {
        Console.WriteLine($"Hello world {DateTime.Now}");
    }
}