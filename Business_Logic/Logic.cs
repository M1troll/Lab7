using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Domain;
using GalaSoft.MvvmLight.Command;
using System.Runtime.CompilerServices;

namespace Business_Logic
{
    public class Logic:INotifyPropertyChanged
    {
        public delegate bool IsCanAddTeacher(string name);
        public Teacher NewTeacher { get; set; } 
        public List<Service> ServList { get; set; } 
        public List<Institute> InstList { get; set; }
        public ObservableCollection<Teacher> Teachers { get; set; }
        private ObservableCollection<CountService> _topServicea { get; set; }
        public ObservableCollection<CountService> TopServices
        {
            get { return _topServicea; }
            set
            {
                _topServicea = value;
                OnPropertyChanged("TopServices");
            }
        }
        public Logic()
        {
            NewTeacher = new Teacher();
            Teachers = new ObservableCollection<Teacher> {
                        new Teacher{Name="Арапов Андрей Анатольевич",ShortName="Арапов А.А.",Service=StaticItems.Discord,Institute=StaticItems.IKIT},
                        new Teacher{Name="Бокр Борис Байдакович",ShortName="Бокр Б.Б.",Service=StaticItems.OK,Institute=StaticItems.LI},
                        new Teacher{Name="Виденин Сергей Александрович",ShortName="Виденин С.А.",Service=StaticItems.Zoom,Institute=StaticItems.IKIT},
                        new Teacher{Name="Гном Герасим Генальевич",ShortName="Гном Г.Г,",Service=StaticItems.SFU,Institute=StaticItems.IOG},
                        new Teacher{Name="Дурсль Дадли Динисович",ShortName="Дурсль Д.Д.",Service=StaticItems.Skype,Institute=StaticItems.IPPS},
                        new Teacher{Name="Тушко Тамара Урсуловна",ShortName="Тушко Т.У.",Service=StaticItems.Pigeon_Post,Institute=StaticItems.LI},
                        new Teacher{Name="Ёжиков Дио Маврович",ShortName="Ёжиков Д.М.",Service=StaticItems.Microsoft_Team,Institute=StaticItems.IKIT},
                        new Teacher{Name="Занудин Дмитрий Петрович",ShortName="Занудин Д.П.",Service=StaticItems.Telegram,Institute=StaticItems.IKIT}
                        };
            ServList = new List<Service> { StaticItems.Discord, StaticItems.Microsoft_Team, StaticItems.OK, StaticItems.Pigeon_Post, StaticItems.SFU, StaticItems.Skype, StaticItems.Telegram, StaticItems.Zoom };
            InstList = new List<Institute> { StaticItems.IKIT, StaticItems.GI, StaticItems.PI, StaticItems.IOG, StaticItems.LI, StaticItems.IPPS };
        } 
        public void AddTeaher()
        {
            IsCanAddTeacher CheckName1 = (Name) => !Teachers.Select(t => t.Name).Contains(NewTeacher.Name);
            if (CheckName1(NewTeacher.Name))       
            {
                //NewTeacher = NewTeacher.ToShortForm(); - экстенсион метод
                if (NewTeacher.Name != null && NewTeacher.Service != null && NewTeacher.Institute != null && NewTeacher.ShortName != null)
                {
                    Teachers.Add(new Teacher() { Name=NewTeacher.Name,Institute=NewTeacher.Institute,Service=NewTeacher.Service}); //для extension metod нужно добавить ShortName=NewTeacher.ShortName
                }
            }
        }
        public void WriteTop()
        {
            var top = Teachers
                .GroupBy(p => p.Service)
                .Select(x => new CountService()
                {
                    Name = x.Key.Name,
                    Count = x.Count(),
                    URL = x.Key.URL,
                })
                .OrderByDescending(x => x.Count)
                .Take(3)
                .ToList();
            if(top[0]!=null)top[0].Medal = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\medals\medal_gold.ico";
            if (top[1] != null) top[1].Medal = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\medals\medal_silver.ico";
            if (top[2] != null) top[2].Medal = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\medals\medal_bronze.ico";
            TopServices =new ObservableCollection<CountService>(top);
        }
        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new RelayCommand(AddTeaher));
            }
        }
        private ICommand _topCommand;
        public ICommand TopCommand
        {
            get
            {
                return _topCommand ?? (_topCommand = new RelayCommand(WriteTop));
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
