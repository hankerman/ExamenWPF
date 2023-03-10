using ExamenWPF.Model;
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
using System.Windows.Shapes;

namespace ExamenWPF.ViewModel
{
    /// <summary>
    /// Логика взаимодействия для WindowCRUD.xaml
    /// </summary>
    public partial class WindowCRUD : Window
    {
        private MovieCRUD_VM _vm;
        public WindowCRUD(Movie movie = null)
        {
            InitializeComponent();
            _vm = new MovieCRUD_VM(movie);
            this.DataContext = _vm;
            this.Title = "Добавление";
            GenreBox.ItemsSource = MovieDB.Context.Genre;
            if (movie != null)
            {
                NameTextBox.IsReadOnly = true;
                this.Title = "Изменение";
            }
        }
        
        private void Clouse_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_vm.IsValid())
            {
                _vm.SaveMovie();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "ERROR", MessageBoxButton.OK);
            }
            
        }
    }
}
