using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //syntax 1
            //int[] num = new int[3];
            //num[0] = 5;
            //num[1] = 2;
            //num[2] = 7;
            ////Console.WriteLine(num[2]);
            //foreach(int i in num) 
            //{
            //    Console.WriteLine(i);
            //}

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "blue";
            //colors[2] = "green";
            //colors[3] = "yellow";

            //Console.WriteLine(colors[1]);
            //foreach (string i in colors)
            //{
            //    Console.WriteLine(i);
            //}

            //2nd syntax
            //int[] num = new int[3] { 3, 9, 1 };
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(num[1]);

            //string[] colors = new string[4] {"red","black","blue","green"};
            //foreach (string i in colors)
            //{
            //    Console.WriteLine(i);
            //}


            //MULTI DIMENSIONAL ARRAY
            //Rectangular array
            int[,] nums = new int[2, 3]
            {
                { 2 , 3 , 7 },
                { 1 , 6 , 8 }
            };
            //Console.WriteLine(nums[1, 0]);
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "   ");
                }
                Console.WriteLine();
            }

            string[][] brands = new string[3][];
            brands[0] = new string[] { "HP", "Dell", "Lenovo", "Tushiba", "Acer", "Asus" };
            brands[1] = new string[] { "Haier", "Dawlance", "Pel", "Orient", "Gree", "Kenwood", "Changhongruba", "Panasonic" };
            brands[2] = new string[] { "J.", "Zara", "Outfitters", "Gucci", "Nike", "Addidas","Diners","polo","LV" };

            for(int i = 0; i < brands.Length; i++)
            {
                for(int j = 0; j < brands[i].Length; j++) 
                {
                    Console.Write(brands[i][j] + "   ");
                }
                Console.WriteLine();
            }

        }
    }
}
