namespace amlWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.Map("/", () => "Hello World!");
            app.MapControllerRoute(name: "role", pattern: "{controller=Role}/{action=rolesList}");
            app.Run();
        }
    }
}