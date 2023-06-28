using System;
using System.IO;
namespace lab03
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChooseFunction();
        }

        public static void ChooseFunction()
        {
            Console.WriteLine("Choose The Number OF Function Please");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Multiply First 3 Number Function : 1");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Average Function : 2");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Draw Diamond Stars : 3");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Duplicate Element In Array : 4");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Maximum Element In Array : 5");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Input Text : 6");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Print Text : 7");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Remove Text : 8");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Number Character In Each Word : 9");
            Console.WriteLine("-------------------------------------");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    Console.WriteLine("Insert 3 Digit");
                    string digits = Console.ReadLine();
                    Console.WriteLine(MultiplyFirst3(digits));
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;

                case "2":
                    try
                    {
                        Console.WriteLine("Please enter number between 2-10");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arrNum = new int[size];
                        if (size > 2 && size < 10)
                        {
                            for (int i = 0; i < size; i++)
                            {
                                Console.WriteLine($"{i + 1} of {size} - Enter a number:");
                                arrNum[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine($"the average is {Average(size, arrNum)}");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("please add the real number");
                    }
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;

                case "3":
                    Console.WriteLine("Diamond Starts ");
                    Diamond();
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;


                case "4":
                    Console.WriteLine("Most Duplicate Element In Array ");
                    int[] arr = { 1, 1, 3, 5, 3, 6, 3, 4, 3 };
                    Console.WriteLine(DuplicateArr(arr));
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;
                case "5":
                    Console.WriteLine("Maximum Element In Array :");
                    int[] array = { 5, 25, 99, 123, 78, 96, 555, 108, 4000 };
                    Console.WriteLine(MaxElement(array));
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;
                case "6":
                    string path = "../../../TextFile1.txt";
                    InputWord();
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;

                case "7":
                    PrintFileText();
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;

                case "8":
                    string words = "Hello Friend";
                    ReWriteText(words);
                    Console.WriteLine("It will be rewrite on text file");
                    break;
                    ChooseFunction();
                    break;

                case "9":
                    Console.WriteLine("Number Of Character For Every Word :");
                    string str = "This is a sentence about important things";
                    string[] arr2 = (NumbersOfWord(str));
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        Console.Write(arr2[i] + " ");
                    }
                    Console.WriteLine("");
                    ChooseFunction();
                    break;
                default:
                    Console.WriteLine("Insert Valid Option");
                    Console.WriteLine("******************************");
                    ChooseFunction();
                    break;
                    
            }
        }

        public static void ReWriteText(string words)
        {
            string path = "../../../TextFile1.txt";
            string content = File.ReadAllText(path);
            content = content.Replace(words, "");
            File.WriteAllText(path, content);
        }

        public static int MultiplyFirst3(string digit)
        {
            string[] arr = digit.Split(' ');
            if (arr.Length < 3)
            {
                return 0;
            }
            int multiply = 1;
            for (int i = 0; i < 3; i++)
            {
                int strConvertNum;
                try
                {

                    strConvertNum = int.Parse(arr[i]);


                    multiply *= strConvertNum;
                }
                catch (FormatException)
                {
                    multiply *= 1;
                }

            }

            return multiply;
        }
        public static int Average(int size, int[] num)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += num[i];
            }
            int avg = sum / size;
            return avg;
        }
        public static void Diamond()
        {
            int i, j, rows = 5;
            int stars = 1, spaces = rows - 1;
            for (i = 1; i < rows * 2; i++)
            {
                for (j = 1; j <= spaces; j++)
                    Console.Write(" ");

                for (j = 1; j < stars * 2; j++)
                    Console.Write("*");

                Console.WriteLine();

                if (i < rows)
                {
                    spaces--;
                    stars++;
                }
                else
                {
                    spaces++;
                    stars--;
                }
            }
        }
        public static int DuplicateArr(int []arr)
        {
            
            if (arr.Length == 0)
            {
                return 0;
            }
            int freq = 0, maxFreq = 0;
            int mostFreq = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                freq = 0;
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j])
                        freq++;

                }
                if (freq > maxFreq)
                {
                    maxFreq = freq;
                    mostFreq = arr[i];

                }
                if (maxFreq == 0)
                {
                    mostFreq = arr[0];
                }


            }
            return mostFreq;

        }
        public static int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            return max;
        }
        public static string[] NumbersOfWord(string str)
        {
            string[] newStr = str.Split(' ');
            string[] arrStr = new string[newStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
            {
                arrStr[i] = ($"{newStr[i]}: {newStr[i].Length}");
            }
            return arrStr;
        }
        public static void InputWord()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            string path = "../../../TextFile1.txt";
         
           
            File.WriteAllText(path, word);

        }
        public static void PrintFileText()
        {
            string path = "../../../TextFile1.txt";
            string dataFromFile = File.ReadAllText(path);
            Console.WriteLine(dataFromFile);
        }
    }
}