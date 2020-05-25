using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace HightApp
{
    [Serializable]
    public class User // Класс, который хранит регистрационные данные.
    {
        public int UserId { get; set; }
        public string Logins { get; set; } // Логин.
        public string Passwords { get; set; } // Пароль.
        public string Fio { get; set; }
        public int AssesLvl { get; set; }

        override
        public string ToString() {
            return UserId.ToString() + Logins + Passwords + Fio + AssesLvl;
        }

       
    }




}
