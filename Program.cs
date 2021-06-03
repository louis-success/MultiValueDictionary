using System.Linq;
using CommandLine;
using MultiValueDictionary.Commands;
using MultiValueDictionary.Interfaces;
using static System.Console;
using static MultiValueDictionary.Common.Constants;//C#6.0 Using static syntax

namespace MultiValueDictionary
{
    class Program
    {
        /// <summary>
        /// Multi-Value dictionary application entry point. Type Exit + Enter Key to exit the application.
        /// </summary>
        static void Main()
        {
            WriteLine("******Welcome to Multi-Value Dictionary Application******");
            string command = ReadLine();
            do
            {
                command = MainApp(command.Split(' '));

            } while (command.ToUpper() != "EXIT");

            //C#7.0 Local Function
            //this local function is using CommanLineParser to parse the args and execute the corresponding commands
            string MainApp(string[] args)
            {
                //C#6.0 Null conditional operator
                if (args?.Length < 1)
                {
                    //C#6.0 Using static syntax
                    WriteLine(invalidArgsError);
                    return ReadLine();
                }
                var arguments = args.Skip(1).ToArray();
                args[0] = args[0].ToUpper(); //To provide capability to app to accept command in any case.
                Parser.Default.ParseArguments<Add, Remove, Keys, Members, RemoveAll, Clear, KeyExists, ValueExists, AllMembers, Items>(args)
                    .WithParsed<ICommand>(c => c.Execute(arguments));
                return ReadLine();
            }
        }
        
    }
}
