﻿using Microsoft.Extensions.DependencyInjection;
using System;
using static System.Console;

namespace DependencyInjectionWithOptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegisterServices();
            UseOptions();
        }

        private static void UseOptions()
        {
            var controller = Container.GetService<HelloController>();

            string greeting = controller.Action("Stephanie");

            WriteLine(greeting);
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddOptions();

            services.AddTransient<HelloController>();

            services.AddGreetingService(options =>
            {
                options.From = "Christian";
            });

            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
