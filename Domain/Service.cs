using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Service
    {
        public string Name {set;get;}
        public string URL { get; set; }
        public override string ToString()
        {
            return Name;
        } 
        //public int CountUsers { get; set; }
        //public Service()
        //{
        //    CountUsers++;
        //}
    }
}
