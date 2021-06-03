using System;
using MultiValueDictionary.Interfaces;
using static MultiValueDictionary.Common.Constants;
using CommandLine;
using static System.Console;
using System.Linq;

namespace MultiValueDictionary.Commands
{
    [Verb("KEYS", HelpText = "List all the keys of multi value dictionary.")]
    public class Keys: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            WriteLine("******KEYS******");
            if(Dictionary.Keys.Count == 0)
            {
                WriteLine(emptySet);
                return;
            }
            foreach (var key in Dictionary.Keys)
            {
                WriteLine(key);
            }
        }
    }
}
