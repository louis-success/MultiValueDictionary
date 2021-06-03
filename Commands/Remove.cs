using System;
using static System.Console;
using static MultiValueDictionary.Common.Constants;
using MultiValueDictionary.Interfaces;
using CommandLine;
using System.Linq;

namespace MultiValueDictionary.Commands
{
    [Verb("REMOVE", HelpText = "Remove item with specified key")]
    public class Remove: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            if (args?.Length < 1)
            {
                WriteLine(invalidArgsError);
                return;
            }
            string key = args[0];
            if (args.Length == 1)
            {                
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
            else
            {
                string value = args[1];
                if (value != string.Empty)
                {
                    var valueIndex = Dictionary[key].IndexOf(value);
                    if (valueIndex == -1)
                    {
                        WriteLine(valueNotExistError);
                        return;
                    }
                    Dictionary[key] = Dictionary[key].Replace(value,string.Empty).Replace(",,",string.Empty).Trim(valueDelimitter,' ');
                    if(Dictionary[key] == "")
                    {
                        Dictionary.Remove(key);
                    }
                    WriteLine($"Removed VALUE: {value}.");
                }
            }
        }
    }
}
