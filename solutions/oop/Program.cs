

namespace Oop1
{
    class Prog
    {

        static void Main()
        {
            FilmManager filmManager = new FilmManager();
            var films = filmManager.GetFilms();
            
            Console.WriteLine("Bir film adi girin ve biz size hangi yila ait oldugunu soyleyelim:");
            string filmName = Console.ReadLine();
            int res = filmManager.GetYearOfFilm(filmName);
            Console.WriteLine($"{filmName} filmi {res} yilina ait.");

            Console.WriteLine("bir yil girin ve o yila ait butun filmleri size gosterelim:");
            int year = int.Parse(Console.ReadLine());
            var yearFilms = filmManager.GetFilmsOfYear(year);
            foreach(var f in yearFilms)
                Console.WriteLine("{0} / {1}", f.Name, f.Year);


            Console.WriteLine("iki yil girin ve o iki yil arasinda vizyona girmis butun filmleri gosterelim:");
            int startY = int.Parse(Console.ReadLine());
            int endY = int.Parse(Console.ReadLine());
            var rangeYears = filmManager.GetFilmWithYearRange(startY, endY);
            foreach(var f in rangeYears)
            {
                Console.WriteLine("{0} / {1}", f.Name, f.Year);
            }
        
        
        }

    }

}


