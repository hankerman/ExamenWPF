using ExamenWPF.Model;
using ExamenWPF.Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ExamenWPF.ViewModel
{
    public class MovieVM : NotifyClass
    {
        public MovieVM()
        {
            Movies = MovieDB.Context.Movies.ToList();
        }
        public List<Movie> Movies { get; set; }
        public List<Movie> SelectedMovies { get; set; }
        public void DeleteMovies()
        {
            foreach (var r in SelectedMovies)
            {
                MovieDB.Context.Movies.Remove(r);
            }
            Movies = MovieDB.Context.Movies.ToList();
            SelectedMovies.Clear();
            OnPropertyChanged(nameof(Movies));
        }
        public void ModifiMovies()
        {
            Movies = MovieDB.Context.Movies.ToList();
            OnPropertyChanged(nameof(Movies));
        }
    }
}
