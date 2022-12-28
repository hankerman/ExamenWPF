using ExamenWPF.Model;
using ExamenWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ExamenWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MovieVM _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MovieVM();
            this.DataContext = _vm;
        }

        private void DeleteMovie_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedMovies = MoviesLV.SelectedItems.Cast<Movie>().ToList();
            _vm.DeleteMovies();
            
        }

        private void ModifyMovie_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedMovies = MoviesLV.SelectedItems.Cast<Movie>().ToList();
            Movie movie = _vm.SelectedMovies.FirstOrDefault();
            if (movie != null)
            {
                WindowCRUD windowCRUD = new WindowCRUD(movie);
                windowCRUD.ShowDialog();
                _vm.ModifiMovies();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WindowCRUD windowCRUD = new WindowCRUD();
            windowCRUD.ShowDialog();
            _vm.ModifiMovies();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            _vm.UpdateListMovie();
        }

        
    }
}
