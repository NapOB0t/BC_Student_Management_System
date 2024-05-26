using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGProject
{
    internal class Module
    {
        public Module(int modCo, string modName, string modDescription, string modLink)
        {
            ModCode = modCo;
            ModName = modName;
            ModDescription = modDescription;
            ModLink = modLink;
        }

        public int ModCode { get; set; }
        public string ModName { get; set; }
        public string ModDescription { get; set; }
        public string ModLink { get; set; }
    }
}
