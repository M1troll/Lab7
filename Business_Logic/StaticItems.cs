using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Business_Logic
{
    public static class StaticItems
    {
        public static Service Discord = new Service { Name = "Дискорд", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\Discord.ico" };
        public static Service Microsoft_Team = new Service { Name = "Майкрософт Тим", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\Microsoft_Teams.ico" };
        public static Service OK = new Service { Name = "Одноклассники", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\OK.ico" };
        public static Service Pigeon_Post = new Service { Name = "Голубиная Почта", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\Pigeon_Post.ico" };
        public static Service SFU = new Service { Name = "еКурсы/Сфу", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\SFU.ico" };
        public static Service Skype = new Service { Name = "Skype", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\Skype.ico" };
        public static Service Telegram = new Service { Name = "Telegram", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\Telegram.ico" };
        public static Service Zoom = new Service { Name = "Zoom", URL = @"C:\Users\orochi\source\repos\DE_Service\DE_Service\images\Zoom.ico" };

        public static Institute IKIT = new Institute { Title = "ИКИТ" };  //ИКИТ
        public static Institute GI = new Institute { Title = "ГИ" };       //Гуманитарный институт
        public static Institute PI = new Institute { Title = "Политех" };    //Политехнический институт 
        public static Institute IOG = new Institute { Title = "ИНиГ" };    //Институт нефти и газа
        public static Institute LI = new Institute { Title = "ЮИ" };    //Юридический институт (Law Institute)
        public static Institute IPPS = new Institute { Title = "ИППС" };  //Институт педагогики, психологии и социологии

        //extension metod
        //public static Teacher ToShortForm(this Teacher teacher) 
        //{
        //    if (teacher.Name != null && !teacher.Name.Contains('.'))
        //    {
        //        string[] str = teacher.Name.Split(' ');
        //        if (str.Length == 3)
        //        {
        //            teacher.ShortName = str[0] + ' ' + str[1][0] + '.' + str[2][0] + '.';
        //        }
        //        else { teacher.ShortName = null; teacher.Name = null; }
        //    }
        //    return teacher;
        //}
    }
}
