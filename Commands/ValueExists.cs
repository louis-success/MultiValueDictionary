using System;
using static System.Console;
using static MultiValueDictionary.Common.Constants;
using MultiValueDictionary.Interfaces;
using CommandLine;
using System.Linq;

namespace MultiValueDictionary.Commands
{
    [Verb("VALUEEXISTS", HelpText = "Identify specified key/value exist in multi value dictionary.")]
    public class ValueExists: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            if (args?.Length != 2)
            {
                WriteLine(invalidArgsError);
                return;
            }
            string key = args[0];
            string value = args[1];
            bool valueExist = false;
            if (Dictionary.Keys.ToList().Contains(key) && Dictionary[key].IndexOf(value) >= 0)
            {
                valueExist = true;
            }
            WriteLine($"VALUE Exist: {valueExist}");
        }
    }
}
