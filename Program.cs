using System.Numerics;
using System.Runtime.CompilerServices;

namespace Week10ChallangeLabs
{
    

    internal class Program
    {

        static string FindUniqueChar(string s, string t)
        {
            char[] str = s.ToArray();
            char[] tStr = t.ToArray();

            Array.Sort(str);
            Array.Sort(tStr);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != tStr[i]) return tStr.ToString();
            }

            return tStr[^1].ToString();
        }

        static void GetUniqueChar()
        {
            Console.WriteLine("This Method takes two strings and show the difference!");
            
            string s1 = "abcd", t1 = "abcde";
            string s2 = "abcd", t2 = "aebcd";

            Console.WriteLine($"S = {s1} - T = {t1}\nUnique = {FindUniqueChar(s1,t1)}\n");

            Console.WriteLine($"S = {s2} - T = {t2}\nUnique = {FindUniqueChar(s2, t2)}\n\n");
        }

        static int[] MergeNumbers(int[] num1, int x, int[] num2, int y)
        {
            int count = 0;
            int count2 = 0;
            int total = num1.Length > num2.Length ? num1.Length : num2.Length;

            int[] newArray = new int[total];

            if (num1.Length == 0) return num2;
            if (num2.Length == 0) return num1;

            while(count < x)
            {
                newArray[count] = num1[count];
                count++;
            }
            
            while(count < total)
            {
                newArray[count] = num2[count2];
                count++;
                count2++;
            }

            return newArray;

        }

        static void PrintArray(int[] arr)
        {
            foreach (int str in arr) Console.Write(str + " ");
        }

        static void Merged(int[] num1, int x, int[] num2, int y)
        {
            int[] result = MergeNumbers(num1, x, num2, y);

            Console.Write("Items to merge: nums1 = ");
            PrintArray(num1);
            Console.Write($", m = {x}, nums2 = ");
            PrintArray(num2);
            Console.Write($", n = {y}");

            Console.Write("\nOut: ");
            PrintArray(result);

            Console.WriteLine();
        }

        static void GetMergeNumbers()
        {
            int[] num1 = { 1, 2, 3, 0, 0, 0 };
            int[] num2 = { 2, 5, 6 };
            int m1 = 3, n1 = 3;

            int[] num3 = { 1 };
            int[] num4 = { };
            int m2 = 1, n2 = 0;

            int[] num5 = { 0 };
            int[] num6 = { 1 };
            int m3 = 0, n3 = 1;

            Console.WriteLine("This method shows merged arrays for numbers!\n");

            Merged(num1, m1, num2, n1);
            Merged(num3, m2, num4, n2);
            Merged(num5, m3, num6, n3);
        }

        static void Print()
        {
            GetUniqueChar();
            GetMergeNumbers();
        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}
