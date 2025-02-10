namespace middlewares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.Use(async(httpcontext, next) =>
            {
                await httpcontext.Response.WriteAsync("bar bar use hota hai \n");
                await next(httpcontext);
            });
            app.Use(async(context, next) =>
            {
                await context.Response.WriteAsync("mzeed next \n");
                await next(context);
            }); 

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("hamza");
            });

            app.Run();
        }
    }
}
