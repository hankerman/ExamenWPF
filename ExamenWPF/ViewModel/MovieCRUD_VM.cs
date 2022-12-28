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
    public class MovieCRUD_VM : NotifyClass
    {
        public MovieCRUD_VM(Movie movie = null)
        {
            _currentMovie = new Movie();
            if(movie != null)
            {
                _currentMovie.Name = movie.Name;
                _currentMovie.Teg = movie.Teg;
                _currentMovie.YearOfRelease = movie.YearOfRelease;
                _currentMovie.Description = movie.Description;
                _currentMovie.CountryOfIssue = movie.CountryOfIssue;
                _currentMovie.FilmCompany = movie.FilmCompany;
                _currentMovie.Genre = movie.Genre;
            }
        }
        private Movie _currentMovie;
        public Movie CurrentMovie
        {
            get => _currentMovie;
            private set { _currentMovie = value; }
        }
        public string Name
        {
            get => _currentMovie.Name;
            set
            {
                _currentMovie.Name = value;
                OnPropertyChanged();
            }
        }
        public string Teg 
        {
            get => _currentMovie.Teg;
            set
            {
                _currentMovie.Teg = value;
                OnPropertyChanged();
            }
        }
        public int YearOfRelease 
        {
            get => _currentMovie.YearOfRelease;
            set
            {
                _currentMovie.YearOfRelease = value;
                OnPropertyChanged();
            }
        }
        public string Description 
        {
            get => _currentMovie.Description;
            set
            {
                _currentMovie.Description = value;
                OnPropertyChanged();
            }
        }
        public string CountryOfIssue 
        {
            get => _currentMovie.CountryOfIssue;
            set
            {
                _currentMovie.CountryOfIssue = value;
                OnPropertyChanged();
            }
        }
        public string FilmCompany 
        {
            get => _currentMovie.FilmCompany;
            set
            {
                _currentMovie.FilmCompany = value;
                OnPropertyChanged();
            }
        }
        public string Genre
        {
            get => _currentMovie.Genre;
            set
            {
                _currentMovie.Genre = value;
                OnPropertyChanged();
            }
        }
        private List<string> _genres;
        public List<string> Genres 
        { get => _genres;
            set
            {
                _genres = value;
                OnPropertyChanged();
            }
        }

        public void SaveMovie()
        {
            //gproverka filma

            //if okay valid

            //if (MovieDB.Context.Movies.FirstOrDefault(x=>x.Name == CurrentMovie.Name) == null)
            //{
            //    MovieDB.Context.Movies.Add(CurrentMovie);
            //}
            //else { 
            //}
            for(int i = 0; i < MovieDB.Context.Movies.Count; i++)
            {
                if(MovieDB.Context.Movies[i].Name == _currentMovie.Name)
                {
                    MovieDB.Context.Movies[i].Teg = _currentMovie.Teg;
                    MovieDB.Context.Movies[i].Description = _currentMovie.Description;
                    MovieDB.Context.Movies[i].YearOfRelease = _currentMovie.YearOfRelease;
                    MovieDB.Context.Movies[i].CountryOfIssue = _currentMovie.CountryOfIssue;
                    MovieDB.Context.Movies[i].FilmCompany = _currentMovie.FilmCompany;
                    MovieDB.Context.Movies[i].Genre = _currentMovie.Genre;
                    return;
                }
                else
                {

                }
            }
            MovieDB.Context.Movies.Add(_currentMovie);
            
        }
        public bool IsValid()
        {
            if((CurrentMovie.Name == ""
                || CurrentMovie.Teg == ""
                || CurrentMovie.Description == ""
                || CurrentMovie.CountryOfIssue == ""
                || CurrentMovie.FilmCompany == "") 
                || (CurrentMovie.Name == null
                || CurrentMovie.Teg == null
                || CurrentMovie.Description == null
                || CurrentMovie.CountryOfIssue == null
                || CurrentMovie.FilmCompany == null))
            {
                return false;
            }
            return true;
        }

    }
}
