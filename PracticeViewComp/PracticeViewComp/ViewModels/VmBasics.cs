using PracticeViewComp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeViewComp.ViewModels
{
    public class VmBasics
    {
        public List<Setting> Settings { get; set; }
        public List<Social> Socials { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
