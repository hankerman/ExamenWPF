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
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }
        public void UpdateListMovie()
        {
            Movies = MovieDB.Context.Movies.Where(x => _searchText == String.Empty || _searchText == null
                            || (int.TryParse(_searchText, out int year) && x.YearOfRelease == year)
                            || (x.Name.ToLower().Contains(_searchText.ToLower()))
                            || (x.Description.ToLower().Contains(_searchText.ToLower()))
                            || (x.CountryOfIssue.ToLower().Contains(_searchText.ToLower()))
                            || (x.FilmCompany.ToLower().Contains(_searchText.ToLower()))
                            || (x.Teg.ToLower().Contains(_searchText.ToLower()))).ToList();
            OnPropertyChanged(nameof(Movies));
            
        }
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
