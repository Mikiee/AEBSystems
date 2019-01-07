using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AEBSystems.Core.Models
{
    public class TRApplication :BaseEntity
    {
        public string PEL { get; set; }
        public string InitialApp { get; set; }
        public string InitialAppDateTime { get; set; }
        
    }
}