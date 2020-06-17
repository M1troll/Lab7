using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Business_Logic
{
    public class CountService : INotifyPropertyChanged
    {
        private string _name { get; set; }
        private int _count { get; set; }
        public string URL { get; set; }
        private string _medal { get; set; }
        public string Medal { get; set; }
        public string Result
        {
            get
            {
                return $"{Name} : {Count}";
            }
        }
        public string Name
        {
            get 
            {
                return _name; 
            }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                OnPropertyChanged("Count");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
