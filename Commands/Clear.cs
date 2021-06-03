using MultiValueDictionary.Interfaces;
using static MultiValueDictionary.Common.Constants;
using CommandLine;
using static System.Console;
using System.Collections.Generic;

namespace MultiValueDictionary.Commands
{
    [Verb("CLEAR", HelpText = "Clear all the items in multi value dictionary.")]
    public class Clear: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            Dictionary = new Dictionary<string, string>();
            WriteLine(cleared);
        }
    }
}
