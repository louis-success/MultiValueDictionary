using System;
using MultiValueDictionary.Interfaces;
using static MultiValueDictionary.Common.Constants;
using CommandLine;
using static System.Console;
using System.Linq;

namespace MultiValueDictionary.Commands
{
    [Verb("ITEMS", HelpText = "List all the values of multi value dictionary.")]
    public class Items: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            WriteLine("******ITEMS******");
            foreach (var item in Dictionary)
            {
                var values = item.Value.Split(valueDelimitter);
                foreach (var value in values)
                {
                    WriteLine($"{item.Key} : {value}");
                }

            }
        }
    }
}
