using System;
using static System.Console;
using static MultiValueDictionary.Common.Constants;
using MultiValueDictionary.Interfaces;
using CommandLine;
using System.Linq;

namespace MultiValueDictionary.Commands
{
    [Verb("REMOVEALL", HelpText = "Remove item with specified key")]
    public class RemoveAll: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            if (args?.Length != 1)
            {
                WriteLine(invalidArgsError);
                return;
            }
            string key = args[0];
            if (!Dictionary.Keys.ToList().Contains(key))
            {
                WriteLine(keyNotExistError);
            }
            else
            {
                Dictionary.Remove(args[0]);
                WriteLine($"Removed KEY: {key}.");
            }

        }
    }
}
