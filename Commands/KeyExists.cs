using System;
using MultiValueDictionary.Interfaces;
using static MultiValueDictionary.Common.Constants;
using CommandLine;
using static System.Console;
using System.Linq;
namespace MultiValueDictionary.Commands
{
    [Verb("KEYEXISTS", HelpText = "Identify specified key exist in multi value dictionary.")]
    public class KeyExists: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            if (args?.Length != 1)
            {
                WriteLine(invalidArgsError);
                return;
            }
            var keyExist = Dictionary.Keys.ToList().Contains(args[0]);
            WriteLine($"KEY Exist: {keyExist}");
        }
    }
}
