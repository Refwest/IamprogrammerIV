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
        ////!Array
        Console.WriteLine("1.\n");

        int[] array = new int[4];
        array[0] = 1;
        array[1] = 3;
        array[2] = 5;
        array[3] = 7;

        int[] array2 = { 1, 3, 5, 7 };

        int[] array3 = new int[5] { 1, 3, 5, 7, 9 };
        int[] array4 = new int[] { 1, 3, 5, 7, 9 };

        Console.WriteLine(array[0] + array[3]);
        Console.WriteLine(array2[0] + array2[3]);
        Console.WriteLine(array3[0] + array3[3]);
        Console.WriteLine(array4[0] + array4[3]);

        ////!Loops with arrays

        Console.WriteLine("\n2.\n");

        int[] studentPoints = { 53, 65, 74, 49, 89, 79, 64, 55, 76, 41, 58 };
        studentPoints[0] += 3;
        studentPoints[1] += 3;
        studentPoints[2] += 3;
        studentPoints[3] += 3;
        studentPoints[4] += 3;
        studentPoints[5] += 3;
        Console.WriteLine("Student 1 points +3 equals {0}\n", studentPoints[0]);

        for (int i = studentPoints.Length - 1; i >= 0; i--)
        {
            studentPoints[i] -= 3;
            Console.WriteLine("Student {1} points equals {0}", studentPoints[i], i);
        }

        ////!Foreach - loop
        Console.WriteLine("\n3.\n");
        foreach (int score in studentPoints)
        {
            Console.WriteLine("\n" + score);
            int score2 = score + 1;
            Console.WriteLine(score2);
        }

        ////!Array with loop - looking for student
        Console.WriteLine("\n4.\n");
        string[] students = new string[5] { "Jędrek", "Mieszko", "Antoni", "Henryk", "Amadeusz" };
        bool presence = false;

        string name = Console.ReadLine();
        for (int i = 0; i < students.Length; i++)
        {
            if (name == students[i])
            { 
                presence = true; 
            }

        }
        if (presence)
        {
            Console.WriteLine("{0} is presnent", name);
        }
        else
        {
            Console.WriteLine("Student absent");
        }




    }
}





