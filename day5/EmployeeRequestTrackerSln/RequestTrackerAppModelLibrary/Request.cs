using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerAppModelLibrary
{
    public class Request
    {
        public int RequestId {  get; set; }
        public string RequestTitle { get; set; }
        public string RequestDescription { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int Eid { get; set; }
        //public Employee Employee { get; set; }

    }
}
