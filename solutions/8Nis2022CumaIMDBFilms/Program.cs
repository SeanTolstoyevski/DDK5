using System.Collections.Generic;
using System.Linq;

namespace IMDBFilms
{
    class Program
    {
        static void Main()
        {
            string htmlBody = "";

            using (var webClient = new System.Net.WebClient())
            {
                htmlBody = webClient.DownloadString("https://www.imdb.com/chart/top/");
            }

            var trs = GetTRList(htmlBody);
            var films = CreateFilmsList(trs);

            Console.WriteLine("Filmler yila gore siralaniyor...");
            OrderByYear(films);


        }

        static string[] GetTRList(string htmlBody)
        {
            string tBody = "<tbody class=\"lister-list\">";
            int tBodyStartOffset = htmlBody.IndexOf(tBody);
            int tBodyEndOffset = htmlBody.IndexOf("</tbody>");
            int tableLength = htmlBody.Length - tBodyStartOffset;
            string tableContent = "";
            tableContent = htmlBody.Substring(tBodyStartOffset + tableContent.Length, tBodyEndOffset - tBodyStartOffset);
            return tableContent.Split("</tr>");
        }

        static List<string> CreateFilmsList(string[] trs)
        {
            List<string> films = new List<string>();
            foreach (var tr in trs)
            {
                string[] tds = tr.Split("</td>");
                if (tds.Length > 3)
                {
                    string row2 = tds[0];
                    int titleTagIndex = row2.IndexOf(" alt=\"");
                    if (titleTagIndex < 0)
                        continue;

                    string afterTitleTag = row2.Substring(titleTagIndex);

                    string filmTitle = afterTitleTag.Substring(6);
                    int firstGreaterSymbolIndex = filmTitle.IndexOf("\"/>");
                    filmTitle = filmTitle.Substring(0, firstGreaterSymbolIndex);
                    int yearStartOfset = tr.IndexOf("<span class=\"secondaryInfo\">(");
                    string yearStr = tr.Substring(yearStartOfset + 29, 4);

                    filmTitle += " / " + yearStr;

                    films.Add(filmTitle);

                }
            }
            return films;
        }


        static void OrderByYear(List<string> films)
        {
            var orderedList = films.OrderBy(v => int.Parse(v.Split(" / ")[1])).ToList();
            foreach(var i in orderedList)
            {
                Console.WriteLine(i);
            }

        }

    } // class
}