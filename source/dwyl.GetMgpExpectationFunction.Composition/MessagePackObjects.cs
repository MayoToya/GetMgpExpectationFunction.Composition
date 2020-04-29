using MessagePack;
using System.Collections.Generic;

namespace dwyl.GetMgpExpectationFunction.Composition
{
    [MessagePackObject]
    public class V2
    {
        [Key(0)]
        public KeyValuePair<string, (double Mean, double Median, (ushort value, double probability) Worst)>[] Result
        {
            get;
            set;
        }
    }
}
