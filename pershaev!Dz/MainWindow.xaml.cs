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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pershaev_Dz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Human selectedHuman;

        public ObservableCollection<Human> Humans
        {
            get => Data.Humans;
        }
        public static ObservableCollection<Branch> Branchs
        {
            get => Data.Branchs;
        }
        public static ObservableCollection<Position> Positions
        {
            get => Data.Positions;
        }

        public Human SelectedHuman
        {
            get => selectedHuman;
            set
            {
                selectedHuman = value;
                Signal();
            }
        }
       

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AddHuman(object sender, RoutedEventArgs e)
        {
            Humans.Add(new Human
            {
                LastName = "Новый рабочий",
                Birthday = DateTime.Today
            });
        }

        private void DeleteHuman(object sender, RoutedEventArgs e)
        {
            if (SelectedHuman == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранного работника?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Humans.Remove(SelectedHuman);
                SelectedHuman = null;
            }
        }

        private void OpenPosition(object sender, RoutedEventArgs e)
        {
            PositionWin win = new PositionWin();
            win.ShowDialog();
        }

        private void OpenBranch(object sender, RoutedEventArgs e)
        {
            BranchWin win = new BranchWin();
            win.ShowDialog();
        }
    }
}

   