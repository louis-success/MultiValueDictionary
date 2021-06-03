using System;
using MultiValueDictionary.Interfaces;
using static MultiValueDictionary.Common.Constants;
using CommandLine;
using static System.Console;
using System.Linq;

namespace MultiValueDictionary.Commands
{
    [Verb("ALLMEMBERS", HelpText = "List all the values of multi value dictionary.")]
    public class AllMembers: MultipleValueDictionary, ICommand
    {
        public void Execute(string[] args)
        {
            WriteLine("******ALL MEMBERS******");
            foreach (var values in Dictionary.Values)
            {
                foreach (var value in values.Split(valueDelimitter))
                {
                    WriteLine(value);
                }

            }
        }
    }
}
