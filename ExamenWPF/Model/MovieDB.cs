using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWPF.Model
{
    public class MovieDB
    {
        private static MovieDB _context;
        public static MovieDB Context => _context ?? (_context = new MovieDB());
        private MovieDB()
        {

        }
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>()
        {
            new Movie(){Name = "Зеленая миля", Teg= "Драма", YearOfRelease = 1999, Description = "В тюрьме для смертников появляется заключенный с божественным даром.\n Мистическая драма по роману Стивена Кинга",
                CountryOfIssue = "США", FilmCompany = "Castle Rock Entertainment"},
            new Movie(){Name = "Назад в будущее", Teg= "Фантастика", YearOfRelease = 1985, Description = "Безумный ученый и 17-летний оболтус тестируют машину времени, наводя шороху в 1950-х.\n Классика кинофантастики",
                CountryOfIssue = "США", FilmCompany = "Юниверсал Пикчерс"},
            new Movie(){Name = "Иван Васильевич меняет профессию ", Teg= "Комедия", YearOfRelease = 1973, Description = "Иван Грозный отвечает на телефон, пока его тезка-пенсионер сидит на троне.\n Советский хит о липовом государе",
                CountryOfIssue = "СССР", FilmCompany = "Мосфильм"},

        };

    }
}
