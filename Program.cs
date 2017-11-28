using System;

namespace Test
{
    class Program
    {
        static void arrPrint(int[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        static void arrPrint(object[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            print1to255();
            Console.WriteLine();
            printOdd();
            Console.WriteLine();
            printSum();
            Console.WriteLine();
            iterArray(new int[]{1, 5, 74, 312, -5, 27});
            Console.WriteLine();
            findMax(new int[]{1, 5, 74, 312, -5, 27});
            Console.WriteLine();
            findAverage(new int[]{1, 5, 74, 312, -5, 27});
            Console.WriteLine();
            arrPrint(oddArray());
            Console.WriteLine();
            Console.WriteLine(greaterThanY(new int[]{1, 5, 74, 312, -5, 27}, 10));
            Console.WriteLine();
            arrPrint(squareArray(new int[]{1, 5, 74, 312, -5, 27}));
            Console.WriteLine();
            arrPrint(elimNegatives(new int[]{1, 5, 74, 312, -5, 27}));
            Console.WriteLine();
            minMaxAvg(new int[]{1, 5, 74, 312, -5, 27});
            Console.WriteLine();
            shiftFront(new int[]{1, 5, 74, 312, -5, 27});
            Console.WriteLine();
            arrPrint(negToString(new object[]{1, 5, 74, 312, -5, 27}));
        }

        static void print1to255()
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void printOdd()
        {
            for(int i = 1; i <= 255; i+=2)
            {
                Console.WriteLine(i);
            }
        }

        static void printSum()
        {
            int sum = 0;
            for(int i = 1; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine("New: " + i + ", Sum: " + sum);
            }
        }

        static void iterArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void findMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }

        static void findAverage(int[] arr)
        {
            int sum = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum / arr.Length);
        }

        static int[] oddArray()
        {
            int[] y = new int[128];
            for(int i = 0; i < 128; i++)
            {
                y[i] = 1 + (2 * i);
            }
            return y;
        }

        static int greaterThanY(int[] arr, int y)
        {
            int greater = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > y)
                {
                    greater ++;
                }
            }
            return greater;
        }

        static int[] squareArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            return arr;
        }

        static int[] elimNegatives(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            return arr;
        }

        static void minMaxAvg(int[] arr)
        {
            int min, max, sum;
            min = max = arr[0];
            sum = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                else if(arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine("Min: " + min + ", Max: " + max + ", Average: " + (sum / arr.Length));
        }

        static void shiftFront(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = 0;
        }

        static object[] negToString(object[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if((int) arr[i] < 0)
                {
                    arr[i] = "Dojo";
                }
            }
            return arr;
        }

    }
}

