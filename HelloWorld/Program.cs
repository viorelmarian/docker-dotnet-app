using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .Configure(app => app.Run(context =>
                {
                    var response = String.Format("Hello, Universe! It is {0}", DateTime.Now);
                    return context.Response.WriteAsync(response);
                }))
                .Build();

            host.Run();
        }
    }
}