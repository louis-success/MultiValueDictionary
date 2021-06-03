using System;
using MultiValueDictionary.Interfaces;
using static MultiValueDictionary.Common.Constants;
using CommandLine;
using static System.Console;
using System.Linq;

namespace MultiValueDictionary.Commands
{
    [Verb("MEMBERS", HelpText = "List all the values of multi value dictionary for a given key.")]
    public class Members: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            WriteLine("******MEMBERS******");
            if (args?.Length != 1)
            {
                WriteLine(invalidArgsError);
                return;
            }
            string key = args[0];
            if (!Dictionary.Keys.ToList().Contains(key))
            {
                WriteLine(keyNotExistError);
                return;
            }
            else
            {
                var values = Dictionary[key].Split(valueDelimitter);
                foreach (var value in values)
                {
                    WriteLine(value);
                }
            }
        }
    }
}
