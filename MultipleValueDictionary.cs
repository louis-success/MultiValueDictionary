using System;
using System.Collections.Generic;
using static MultiValueDictionary.Common.Constants;

namespace MultiValueDictionary
{
    public abstract class MultipleValueDictionary
    {
        public static Dictionary<string, string> Dictionary { get; set; } = new Dictionary<string, string>();
    }
}
