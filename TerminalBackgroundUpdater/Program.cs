using System;
using System.CommandLine;

namespace TerminalBackgroundUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = new Argument<string>().FromAmong();
            Console.WriteLine("Hello World!");
            var rootCommand = new RootCommand
            {
                new Option<string>(aliases: new []{"-p", "--profile"}, description: "The terminal profile to change "),
                new Option<string>()
            };
        }
    }
}
