using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;
using System.Net;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            #region AddExceptionHandler
            //app.UseExceptionHandler(exceptionHandlerApp =>
            //{
            //    exceptionHandlerApp.Run(async context =>
            //    {
            //        context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            //        // using static System.Net.Mime.MediaTypeNames;
            //        context.Response.ContentType = Text.Plain;

            //        await context.Response.WriteAsync("There is Error check");

            //    });
            //});
            #endregion

            #region Middlewares
            //app.UseAuthentication();
            //app.UseAuthorization();
            #endregion

            #region Endpoints - Routing
            // Endpoints routes 

            //app.UseRouting();

            //app.MapGet("/", () => "Hello World!");

            //app.MapGet("/H/{id:int?}", async(context) => {
            //    var id = context.Request.RouteValues["id"];
            //    //throw new Exception();
            //    await context.Response.WriteAsync ($"Hello World with ID {id}");
            //    });

            //app.MapGet("/optional/{id?}", async (context) =>
            //{
            //    await context.Response.WriteAsync($"Hello Optional with ID {context.Request.RouteValues["id"]}");
            //});


            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/hello2", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World 2");
            //    });
            //});

            // we know that here is just a pipeline
            // if no requests matches the endpoint it will execute it
            // the order there is really important

            //app.Run(async (HttpContext) =>
            //{
            //    HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;
            //    await HttpContext.Response.WriteAsync("Your Requested Page Not Found");
            //});
            #endregion

            app.UseStaticFiles();


            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home", Action = "Index" }
                );

            app.Run();
        }
    }
}
