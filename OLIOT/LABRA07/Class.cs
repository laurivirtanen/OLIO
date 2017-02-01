using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRA07
{
    [Serializable]
    public class TvOhjelma
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime  { get; set; }
        public string InfoText { get; set; }

        public TvOhjelma(string name, string channel, string stime, string etime, string info)
        {
            Name = name;
            Channel = channel;
            StartTime = stime;
            EndTime = etime;
            InfoText = info;
        }


    }
    
}
