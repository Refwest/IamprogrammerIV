// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesI;

class Program
{
    static void Main(string[] args)
    {
        //    ////!Array
        //    Console.WriteLine("1.\n");

        //    int[] array = new int[4];
        //    array[0] = 1;
        //    array[1] = 3;
        //    array[2] = 5;
        //    array[3] = 7;

        //    int[] array2 = { 1, 3, 5, 7 };

        //    int[] array3 = new int[5] { 1, 3, 5, 7, 9 };
        //    int[] array4 = new int[] { 1, 3, 5, 7, 9 };

        //    Console.WriteLine(array[0] + array[3]);
        //    Console.WriteLine(array2[0] + array2[3]);
        //    Console.WriteLine(array3[0] + array3[3]);
        //    Console.WriteLine(array4[0] + array4[3]);

        //    ////!Loops with arrays

        //Console.WriteLine("\n2.\n");

        //int[] studentPoints = { 53, 65, 74, 49, 89, 79, 64, 55, 76, 41, 58 };
        //studentPoints[0] += 3;
        //studentPoints[1] += 3;
        //studentPoints[2] += 3;
        //studentPoints[3] += 3;
        //studentPoints[4] += 3;
        //studentPoints[5] += 3;
        //Console.WriteLine("Student 1 points +3 equals {0}\n", studentPoints[0]);

        //for (int i = studentPoints.Length - 1; i >= 0; i--)
        //{
        //    studentPoints[i] -= 3;
        //    Console.WriteLine("Student {1} points equals {0}", studentPoints[i], i);
        //}

        ////    ////!Foreach - loop
        //Console.WriteLine("\n3.\n");
        //foreach (int score in studentPoints)
        //{
        //    Console.WriteLine("\n" + score);
        //    int score2 = score + 3;
        //    Console.WriteLine(score2);
        //}

        //    ////!Array with loop - looking for student
        //Console.WriteLine("\n4.\n");
        //string[] students = new string[5] { "Jędrek", "Mieszko", "Antoni", "Henryk", "Amadeusz" };
        //int[] grades = new int[5] { 5, 4, 4, 5, 3 };
        //bool presence = false;
        //int studentGrade = 0;

        //string name = Console.ReadLine();
        //for (int i = 0; i < students.Length; i++)
        //{
        //    if (name == students[i])
        //    {
        //        presence = true;
        //        studentGrade = grades[i];
        //        break;
        //    }
        //}
        //if (presence)
        //{
        //    Console.WriteLine("{0} is presnent", name);
        //    Console.WriteLine("{0} got {1} from exam", name, studentGrade);
        //}
        //else
        //{
        //    Console.WriteLine("Student absent");
        //}


        //    ////!Useful array methods
        //    ///Binary search - Numbers in array must be in order! 

        //int[] myArray = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 };
        //Console.WriteLine("Enter number to check");

        //int searching = int.Parse(Console.ReadLine());
        //int occurrence = Array.BinarySearch(myArray, searching);
        //if (occurrence >= 0)
        //{
        //    Console.WriteLine("This number is in the array it is on the {0} position", occurrence);
        //}
        //else if (occurrence < 0)
        //{
        //    Console.WriteLine("This number isn't in array");
        //}

        ////!Array sort method

        //int[] myArray = { 60, 15, 30, 25, 10, 55, 40, 45, 35, 5, 20, 50};
        //Array.Sort(myArray);
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    Console.WriteLine(myArray[i]);
        //}


        //////I am programmer IV revise
        //Console.WriteLine("\n 1. \n");

        //int[] myArray = new int[5];
        //myArray[0] = 5;
        //myArray[1] = 10;
        //myArray[2] = 15;
        //myArray[3] = 20;
        //myArray[4] = 25;


        //for (int showArray = 0; showArray < myArray.Length; showArray = showArray+1)
        //{
        //    Console.WriteLine(myArray[showArray]);
        //}

        //Console.WriteLine("\n 2. \n");

        //int[] yourArray = new int[6] {1, 2, 3, 4, 5, 6 };

        //int[] yourArray2 = {5, 10, 15, 20, 25, 30};

        //for (int i = 0; i < yourArray.Length; i++)
        //{
        //    Console.WriteLine(yourArray2[i]);
        //}
        //Console.WriteLine("\n 3.\n");
        //string[] students = new string[5] { "Jędrek", "Mieszko", "Antoni", "Henryk", "Amadeusz" };
        //int[] grades = new int[5] { 5, 4, 4, 5, 3 };

        //Console.WriteLine("To verify grades of kid write his name:");
        //string yourKid = Console.ReadLine();

        //for (int x = 0; x < students.Length; x++)
        //{
        //    if (yourKid == students[x])
        //    {
        //        Console.WriteLine(yourKid + " is present, his grade is {0}", grades[x]);
        //        break;
        //    }
        //    else if (x == students.Length - 1)
        //    {
        //        Console.WriteLine(yourKid + " is absent");
        //    }
        //}


        ////rectangular array
        int[,] rectangularArray = new int[3, 4] {{1, 2, 3, 4}, {5, 6, 7, 8},
        { 9, 10, 11, 12} };

        for (int a = 0; a < 3; a++)
        {
            for (int b = 0; b < 4; b++)
            {
                Console.WriteLine(rectangularArray[a,b]);
            }
        }


        Console.WriteLine("\n");



        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[4] { 4, 5, 6, 7 };
        jaggedArray[1] = new int[5] { 4, 5, 6, 7, 8};
        jaggedArray[2] = new int[3] { 4, 5, 6 };

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine(jaggedArray[i][j]);
            }
            Console.WriteLine();
        }
    }
}





