using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khakimov_17prakt_1and2
{
    class Program
    {
        static void Main(string[] args)
        { 
            //1 задание
            StreamReader stream = File.OpenText("file.txt");
            string s = stream.ReadLine();

            Console.WriteLine("Введите слово ");
            string slovo = Console.ReadLine();
            string[] mas = s.Split(' ');
            stream.Close();

            List<string> list = new List<string>();

            for (int i = 0; i < mas.Length; i++)
                list.Add(mas[i]);


            list = list.Select(x => x.ToLower()).ToList();
            Console.WriteLine("Было найдено {0} вхождения(ий) поискового запроса {1}", list.Where(x => x == slovo).Count(), slovo);
            Console.ReadKey();


            //2 задание

            Console.WriteLine("Введите 10 строк:");
            string[] arr = new string[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine();

            int chet = 0;
            string number = "";

            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (numbers.Contains(arr[i][j]))
                    {
                        chet++;
                        number += arr[i][j] + " ";
                    }
                }
            }
            Console.WriteLine("Количество цифр: " + chet + "  Цифры: " + number);


            StreamWriter sw = File.CreateText("file2.txt");
            bool proverka = false, vivod=false;
            for (int i = 0; i < 10; i++)
            {
               
                if (proverka == true) break;
                for (int j = 0; j < arr[i].Length; j++)
                {

                    if (arr[i][j] != '/')
                    {
                        Console.Write(arr[i][j]);
                        sw.Write(arr[i][j]);
                    }

                    else
                    {
                        proverka = true;
                        break;
                    }
                }
                Console.WriteLine();
            }



            proverka = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    vivod = false;
                    if (arr[i][j] == '/')
                    {
                        proverka = true;
                        vivod = true;
                        sw.Write(arr[i][j].ToString());
                        Console.Write(arr[i][j].ToString());
                        continue;
                    }
 

                    if ( proverka == true)
                    {
                       
                        if (arr[i][j].ToString() == arr[i][j].ToString().ToLower())
                        {
                            vivod = true;
                            sw.Write(arr[i][j].ToString().ToUpper());
                            Console.Write(arr[i][j].ToString().ToUpper());

                        }
                        else
                        {
                            vivod = true;
                            Console.Write(arr[i][j].ToString().ToLower());
                            sw.Write(arr[i][j].ToString().ToLower());
                        }
                    }
                }
                if(vivod != false) Console.WriteLine();
            }

            sw.Close();
            Console.ReadKey();
        }
    }
}
