using System.Collections.Generic;
using System.Linq;

namespace Oop1
{
    class FilmManager
    {
        public List<Film> GetFilms()
        {
            List<Film> films = new List<Film>();


            using (var webClient = new System.Net.WebClient())
            {
                string result = webClient.DownloadString("https://www.imdb.com/chart/top/");

                string tBody = "<tbody class=\"lister-list\">";
                int tbodyStartIndex = result.IndexOf(tBody);

                int tBodyEndIndex = result.IndexOf("</tbody>");


                int tbodyLength = result.Length - tbodyStartIndex;

                string tBodyContent = result.Substring(tbodyStartIndex + tBody.Length, (tBodyEndIndex - tbodyStartIndex));

                string[] trList = tBodyContent.Split("</tr>");



                foreach (var item in trList)
                {
                    Film film = new Film();
                    string[] tdList = item.Split("</td>");

                    if (tdList.Length > 3)
                    {
                        for (int i = 0; i < tdList.Length; i++)
                        {
                            //i == 1 se yani 2. hücreye geçtiysem ( Film ismini oradan alacağım.)
                            if (i == 1)
                            {
                                string tdContent = tdList[i];

                                int parantezIndex = tdContent.LastIndexOf('(');

                                string year = tdContent.Substring(parantezIndex + 1, 4);

                                int aEnd = tdContent.IndexOf("</a>");

                                string filmSubContent = tdContent.Substring(0, aEnd);
                                int upperLastIndex = filmSubContent.LastIndexOf(">") + 1;


                                string filmTitle = filmSubContent.Substring(upperLastIndex, filmSubContent.Length - upperLastIndex);



                                film.Name = filmTitle;
                                film.Year = Convert.ToInt32(year);


                            }

                            else if (i == 2)
                            {
                                string tdContent = tdList[i];

                                int startIndex = tdContent.IndexOf("ratings\">");

                                string rating = tdContent.Substring(startIndex + 9, 3);

                                film.Rating = Convert.ToDouble(rating);



                            }
                        }

                        films.Add(film);
                    }
                }

            }

            return films;
        }
        // ﻿1) Dışarıdan bir film adı alan ve bu filmin hangi yıla ait olduğunu bana dönen metot
        public int GetYearOfFilm(string filmName)
        {
            var films = GetFilms();
            var film = films.FirstOrDefault(v => v.Name.ToLower() == filmName.ToLower());
            if (film == null)
            {
                return 0;
            }
            return film.Year;
        }

        // 2) Dışarıdan yıl alan ve o yıla ait filmleri bana veren metot
        public List<Film> GetFilmsOfYear(int year)
        {
            var films = GetFilms();
            var filteredList = films.Where(v => v.Year == year).ToList();
            return filteredList;
        }

        // 3) Dışarıdan 2 yıl alan ve o 2 yıl arasındaki filmleri bana veren metot
        public List<Film> GetFilmWithYearRange(int startYear, int endYear)
        {
            var films = GetFilms();
            var filteredFilms = films.Where(v => v.Year > startYear && v.Year < endYear).ToList();
            return filteredFilms;
        }



        List<Film> GetFilmsWithRangeInRating(double minRating, double maxRating)
        {
            var films = GetFilms();
            var filteredFilms = films.Where(v => v.Rating >= minRating && v.Rating <= maxRating).ToList();
            return filteredFilms;
        }

        List<Film> GetOrderedByRating(double minRating, double maxRating)
        {
            var ordereds = GetFilmsWithRangeInRating(minRating, maxRating).OrderByDescending(v => v.Rating).ToList();
            return ordereds;
        }

    }
}