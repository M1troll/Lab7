using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Teacher
    {
        private string _name { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (value != null && !_name.Contains('.'))
                {
                    string[] str = value.Split(' ');
                    if (str.Length == 3)
                    {
                        ShortName = str[0] + ' ' + str[1][0] + '.' + str[2][0] + '.';
                    }
                    else { ShortName = null; _name = null; }
                }
            }
        }
        public string ShortName { get; set; }
        public Institute Institute { get; set; }
        public Service Service { get; set; }
    }
}
