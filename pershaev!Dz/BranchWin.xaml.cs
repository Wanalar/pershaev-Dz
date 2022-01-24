using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pershaev_Dz
{
    /// <summary>
    /// Логика взаимодействия для BranchWin.xaml
    /// </summary>
    public partial class BranchWin : Window, INotifyPropertyChanged
    {
        private Branch selectedBranch;

        public Branch SelectedBranch
        {
            get => selectedBranch;
            set
            {
                selectedBranch = value;
                Signal();
            }
        }

        public ObservableCollection<Branch> Branchs
        {
            get => Data.Branchs;
        }


        public BranchWin()
        {
            InitializeComponent();
            DataContext = this;
        }




        void Signal([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;



        private void AddBranch(object sender, RoutedEventArgs e)
        {
            Branchs.Add(new Branch { Title = "Новая должность" });
        }

        private void DeleteBranch(object sender, RoutedEventArgs e)
        {
            if (SelectedBranch == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранную должноть?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Branchs.Remove(SelectedBranch);
            }
        }
    }
}
