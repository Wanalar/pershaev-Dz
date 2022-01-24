using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pershaev_Dz
{
    internal class Data
    {
        public static ObservableCollection<Human> Humans = new ObservableCollection<Human>();
        public static ObservableCollection<Branch> Branchs = new ObservableCollection<Branch>();
        public static ObservableCollection<Position> Positions = new ObservableCollection<Position>();
    }
}