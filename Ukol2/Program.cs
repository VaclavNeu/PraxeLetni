
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Ucim_se
{
    internal class Program
    {

        public void test()
            {

            Console.WriteLine("Napis cislo: ");
            string line = Console.ReadLine();
            int value;

            if (int.TryParse(line, out value))
            {
                Console.WriteLine("tvoje cislo je: " + value);
            }
            else
            {
                Console.WriteLine("napsal si slovo");
            }
            Console.WriteLine("Tutok je tve cislo *10: " + value * 10);




        }

        static void Main(string[] args)
        {
            // string slovicka = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            //
            // string[] words = slovicka.Split(new[] { " " }, StringSplitOptions.None);
            //
            // string word = "";
            // int ctr = 0;  // pocet delky slova
            //
            // foreach (string s in words)
            // {
            //     if(s.Length > ctr)
            //     {
            //         word = s;
            //         ctr = s.Length;
            //     }
            //  
            //     
            //     
            // }
            //
            // Console.Write(word);

            // Console.WriteLine("Soucet prvnich 500 prvocisel je: " );
            //
            // int sum = 0;
            // int ctr = 0;
            // int n = 2;
            //
            // while (ctr < 500)
            // {
            //     if (isPrime(n))
            //     {
            //         sum += n;
            //         ctr++;
            //     }
            //     n++;
            // }
            //
            // Console.WriteLine(sum);

            //   int a = 35;
            //   int sum = 0;
            //
            //   while(a != 0)
            //   {
            //       sum += a % 10;
            //       a /= 10;
            //   }
            //
            //   Console.WriteLine(sum);


            //   string veta = "The quick brown fox";
            //
            //   string result = "";
            //   string[] words = veta.Split(new[] { " " }, StringSplitOptions.None);
            //  // List<string> list = new List<string>();
            //
            //   
            //   for (int i = words.Length - 1; i >= 0; i--)
            //   {
            //       result += words[i] + " ";
            //   }
            // //  list.Add(result);
            //
            //   // foreach (string s in list) {
            //   //     Console.WriteLine("\nReverse string: " + s);
            //   // }
            //   Console.WriteLine(result);


            // FileInfo f = new FileInfo("C:\\Users\\atakm\\Videos\\dro_client64.exe\\dro_client64.exe 2024.06.26 - 14.16.26.01.mp4");
            //
            //
            // Console.WriteLine("\nsize of a file is: " + f.Length.ToString() + " bytes");


            // string a = Console.ReadLine();
            //
            // int db = Convert.ToInt32(a, 16);
            //
            // Console.WriteLine(db);

            //  string str;
            //  int l = 0;
            //
            //  Console.WriteLine("Input string");
            //  str = Console.ReadLine();
            //
            //  if (str.Length > 4)
            //  {
            //      Console.WriteLine(str.Length < 4 ? str + str + str +str : str.Substring(str.Length -4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            //  }


            //  string str = "Ahoj Vaso, jak se mas?";
            //
            //
            //  string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            //  
            //  if (words[0] == "Ahoj")
            //  {
            //      Console.Write(words[1]);
            //  }


            // string str = "PHP tutor";
            // string[] letters = str.ToString().Split(' ');
            // 
            // var result = "";
            // 
            //
            // if (str.Length >= 1 && str[0] == 'P')
            // {
            //     result += str[0];
            //     result += str[1];
            //     Console.WriteLine(result);
            //     
            //  }


            //  string str = Console.ReadLine();
            //  
            //  var count = str.Count(s => s == 'w');
            //  
            //  Console.WriteLine(count >= 1 && count <= 3);

            //  string str = "PRVNI 4 PISMENA BUDOU MALA";
            //
            //  if (str.Length >= 4)
            //  {
            //      Console.WriteLine(str.Substring(0,4).ToLower() + str.Substring(4, str.Length - 4));
            //  }
            //  else
            //  {
            //      Console.WriteLine(str.ToLower());
            //  }


            //  string str = "wdwwwwafwga";
            //
            //  bool pocet;
            //
            //  Console.WriteLine(pocetW(str));
            //
            //  if (str[0] == 'w' && str[1] == 'w' && str[2] == 'w')
            //  {
            //      pocet = true;
            //      Console.WriteLine(pocet);
            //  }
            //  else
            //  {
            //      pocet = false;
            //      Console.WriteLine(pocet);
            //  }




            //  string str = "w3resource";
            //
            //
            //  var result = string.Empty;
            //
            //  for (int i = 0; i < str.Length - 1; i++) 
            //  {
            //      if (i % 2 == 1) 
            //      {
            //          result += str[i];
            //      }
            //  }
            //  
            //  Console.WriteLine(result);  



            //  int[] a = new int[] { 1, 7, 4, 2, 4, 5, 6, 7, 2, 1, 8, 4 };
            //  
            //  int ctr = 0;
            //
            //  for (int i = 0; i < a.Length; i++)
            //  {
            //      if (a[i] == 4)
            //      {
            //          ctr++;
            //      }
            //  }
            //
            //  Console.WriteLine(ctr);
            //
            //  int x = Convert.ToInt32(Console.ReadLine());
            //
            //  // Define an array of integers 'nums' with pre-defined values
            //  int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            //
            //  // Display a message indicating the number being searched for in the array
            //  Console.WriteLine("Number of " + x + " present in the said array:");
            //
            //  // Count the occurrences of the input integer 'x' in the 'nums' array and print the count
            //  Console.WriteLine(nums.Count(n => n == x));


            //   int[] array = new int[] { 1,54,86,68,4,13,54,8,1,354,8,9};
            //
            //   Console.WriteLine("Input an integer");
            //
            //   int x = Convert.ToInt32(Console.ReadLine());
            //
            //
            //   Console.WriteLine((array[0] == x) || (array[array.Length - 1] == x));


            //  int[] pica =  { 2, 2, 2 };
            //  int[] picb =  { 1, 8, 1 };
            //
            //  Console.WriteLine(pica[0].Equals(picb[0]) || pica[pica.Length - 1].Equals(picb[picb.Length - 1]));
            //
            //  Console.WriteLine( "[{ 0}]",string.Join(", " , picb));


            // int[] num = {1 , 2 , 3 };
            //
            // var temp = num[0];
            //
            // for (int i = 0; i < num.Length - 1; i++)
            // {
            //     num[i] = num[i + 1];
            // }
            //
            // num[num.Length - 1] = temp;
            //
            // Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", num));



            //  int[] num = { 6, 2, 3 };
            //
            //  if (num[0] < num[num.Length - 1])
            //  {
            //      Console.WriteLine(num[num.Length - 1] + " is the bigger number");
            //  }
            //  else
            //  {
            //      Console.WriteLine(num[0] + " is the bigger number");
            //  }


            //  int[] a = { 1, 2, 3 };
            //  int[] b = { 2,4,6 };
            //  int[] c = { 3,6,8 };
            //
            //  int[] d = { a[1], b[1], c[1] };
            //
            //
            //  Console.WriteLine("Toto pole obsahuje: [{0}]", string.Join(", ", d));



            // string a = "kajak";
            // string b = "abcs";
            //
            //
            //
            //
            // Console.WriteLine(palindrom(a));
            // Console.WriteLine(palindrom(b));


            //  Console.WriteLine(Doplnovani(new int[] { -5, 10 }));
            //  Console.WriteLine(Doplnovani(new int[] {1,2,5,8,9}));




            // Console.WriteLine(matrix(new int[][] { new int[] { 1, 7, 0, 2 }, new int[] { 1, 2, 8, 1 }, new int[] { 5, 0, 1, 3 } }));



            var GameList = new List<Game>
            {
                new Game{Name = "Valheim", ReleaseDate = new DateTime(2019,11,9), SteamScore = 9}
            };


















        }

        public static bool isPrime(int n) { 
        
            int x = (int)Math.Floor(Math.Sqrt(n));  
            
            if (n == 1) { return false; }
            if (n == 2) { return true;  }

            for (int i = 2; i <= x; ++i)
            {
                if(n % i == 0)
                {
                    return false;
                }
               
            
            }
            return true;

        }

        public static bool pocetW(string str)
        {
            var ctr = 0;

            for(int i = 0; i < str.Length - 1; ++i)
            {
                if (str[i].Equals('w'))
                {
                    ctr++;
                }
                if(str.Substring(i,2).Equals("ww") && ctr > 2)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool palindrom(string a)
        {
            
            

            char[] letters = a.ToCharArray();
            char[] result = new char[letters.Length];

            for(int i = 0;i < letters.Length; ++i)
            {
                result[i] += letters[letters.Length - i - 1];
            }
            return new string(result).Equals(a);
            
        }

        public static int Doplnovani(int[] inputArray)
        {
            Array.Sort(inputArray);

            int ctr = 0;
            Console.WriteLine("Toto pole obsahuje: [{0}]", string.Join(", ", inputArray));

            for (int i = 0;i < inputArray.Length - 1; i++)
            {
                ctr = inputArray[i + 1] - inputArray.Length;
            }
            if (inputArray[0] <= 0)
            {
                ctr -= inputArray[0] - 1;
            }
            return ctr;
        }

        public static int matrix(int[][] sum)
        {

            int x = 0;

            for (int i = 0; i < sum[0].Length; i++)
            {
                for (int j = 0; j < sum.Length && sum[j][i] > 0; j++)
                {
                    x += sum[j][i];
                }
            }
            return x;
        }

      


    }
 }
