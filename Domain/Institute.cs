using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Institute
    {
        public string Title { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
