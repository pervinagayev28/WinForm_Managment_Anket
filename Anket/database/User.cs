using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket.database
{
    internal class User
    {
        public static int staticId = 1;
        public int Id { get; set; }
        public User()
        {
            Id = staticId++;
        }
        public string username { get; set; }
        public string surname { get; set; }
        public string phone { get; set; }
        public string gmail { get; set; }
        public DateTime birtdhdate { get; set; }
        public string gender { get; set; }

      
    }
}
