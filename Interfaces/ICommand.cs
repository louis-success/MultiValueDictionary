using System;

namespace MultiValueDictionary.Interfaces
{
    public interface ICommand
    {        
        public void Execute(string[] args);
    }
}
