using System;
using MultiValueDictionary.Interfaces;
using static MultiValueDictionary.Common.Constants;
using CommandLine;
using static System.Console;
using System.Linq;
namespace MultiValueDictionary.Commands
{
    [Verb("ADD", HelpText = "Add Key/Value pair to multi value dictionary or Adds new value to existing Key/Value pair")]
    public class Add: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            if (args?.Length < 2)
            {
                WriteLine(invalidArgsError);
                return;
            }
            string key = args[0];
            string value = args[1];
            if (!Dictionary.Keys.ToList().Contains(key))
            {
                Dictionary.Add(key, value);
                WriteLine($"Added KEY: {key} VALUE: {value}."); //C#6.0 String Interpolation
            }
            else if(!Dictionary[key].Split(valueDelimitter).Contains(value))
            {
                Dictionary[key] = string.Concat(Dictionary[key], valueDelimitter, value);
                WriteLine($"Value Added KEY: {key} VALUE: {value}.");
            }
            else
            {
                WriteLine(valueExistError);
            }
        }
    }
}
