using System.Collections.Generic;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Siemens adam asmacaya hoşgeldiniz!");
            Console.WriteLine("Lütfen oyunda tahmin etmek istediğiniz kelimeleri giriniz. Girdikten sonra ENTER tuşuna basınız...");

            List<string> words = new List<string>();

            while (true)
            {
                Console.WriteLine("Kelime gir!");
                string newWord = Console.ReadLine().ToLower();

                if (!String.IsNullOrEmpty(newWord))
                {
                    if (newWord == "start")
                    {
                        break;
                    }
                    else
                    {
                        words.Add(newWord);
                    }

                }

            }


            //Rastgele bir kelimeyi listeden seçiyorum!!
            Random random = new Random();
            int randomWord = random.Next(0, words.Count);


            //gameWord oyunda oynanacak kelime
            string gameWord = words[randomWord];

            List<char> gameWordChars = new List<char>();
            List<char> gameWordCharsBackup = new List<char>();
            char[] gameWordHidden = new char[gameWord.Length];

            for (int i = 0; i < gameWord.Length; i++)
            {
                gameWordChars.Add(gameWord[i]);
                gameWordCharsBackup.Add(gameWord[i]);
                gameWordHidden[i] = '_';
            }
            int hp = 5;

            while (hp > 0)
            {
                Console.WriteLine("Lütfen bir HARF giriniz");
                char userChar = Convert.ToChar(Console.ReadLine().ToLower());

                if (gameWordChars.Contains(userChar))
                {
                    for (int i = 0; i < gameWordHidden.Length; i++)
                    {
                        if (gameWordCharsBackup[i] == userChar)
                        {
                            gameWordHidden[i] = userChar;
                        }

                    }
                    while (gameWordChars.Remove(userChar)) { }

                    Console.WriteLine("{0}", new string(gameWordHidden));
                    if (gameWordChars.Count == 0)
                    {

                        Console.WriteLine("OYUNU KAZANDIN!! AMAN DA AMAN!");
                        break;
                    }
                }
                else
                {
                    hp--;
                    Console.WriteLine("Kalan hakkın: " + hp);

                }

            }

            if (hp == 0)
            {
                Console.WriteLine("ADAM ASILDI!!!");
            }


        }

    }

}


