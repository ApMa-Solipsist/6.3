using System;

namespace _6._3
{
    internal class Program
    {
        static double[] averageTemp(sbyte[,] temperature)
        {
            double[] avTemp = new double[12];
            for (int i = 0; i < 12; i++)
            {
                int sum = 0;
                double average = 0;
                for (int j = 0; j < 30; j++)
                {
                    sum += temperature[i, j];
                    
                }
                avTemp[i] = sum / 30;
            }
            return avTemp;
        }
        static double[] averageTempSorted(double[] avTemp)
        {
            int m = avTemp.Length;
            for (int n =0; n < m - 1; n++)
            {
                for (int j = 0; j < m - 1 - n; j++)
                {
                    if (avTemp[j] > avTemp[j + 1])
                    {
                        (avTemp[j], avTemp[j + 1]) = (avTemp[j + 1], avTemp[j]);
                    }
                }
            }
            return avTemp;
        }
        static void Main(string[] args)
        {
            sbyte[,] temperature = new sbyte[12, 30];
            Random ran = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = (sbyte)ran.Next(-50, 66);
                }
            }

            double average = 0;
            double[] avTemp = averageTemp(temperature);
            double[] avTempSort = averageTempSorted(avTemp);
            for (int i = 0;i < 12; i++)
            {
                Console.WriteLine(avTempSort[i]);
            }
            
        }
    }
}
