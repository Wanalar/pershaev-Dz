using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pershaev_Dz
{
    public class Human
    {
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public double Heigth { get; set; }
        public double Weigth { get; set; }

        public Branch Branch { get; set; }

        public Position Position { get; set; }


    }
}