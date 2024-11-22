using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace T2_T2CalculadoraMasaCorporal
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
