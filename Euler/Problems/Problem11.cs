using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Euler.Problems
{
    public class Problem11
    {
        int sizeOfRow = 4;
        int biggestSum = 0;

        public int FindBiggestProductOf2DArray(string numbers, int cols, int rows)
        {
            int[,] numbersTable = ConvertStringToArray(numbers, cols, rows);

            int biggestProd = FindBiggestProductOf2DArray(numbersTable);

            return 0;
        }


        public int[,] ConvertStringToArray(string rowOfNumbers, int cols, int rows)
        {
            string[] numbers = rowOfNumbers.Split(' ');
            int[,] numbers2DArray = new int[cols, rows];
            if (numbers.Length != cols * rows)
            {
                throw new Exception("Amount of numbers does not equal to size of 2D array");
            }
            int counter = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    numbers2DArray[i, j] = Convert.ToInt32(numbers[counter]);
                    counter++;
                }
            }
            return numbers2DArray;
        }

        public int FindBiggestProductOf2DArray(int[,] numbersTable)
        {
            BiggestHorizontalProduct(numbersTable);
            BiggestVerticalProduct(numbersTable);
            BiggestDigonoalProductTopToBot(numbersTable);
            throw new NotImplementedException();
        }

        public int BiggestHorizontalProduct(int[,] numbersTable)
        {
            int currentSum = 0;

            List<int> mostRecentNumbers = new List<int>();

            for (int i = 0; i < numbersTable.GetLength(0); i++)
            {
                for (int j = 0; j < numbersTable.GetLength(1); j++)
                {
                    if (mostRecentNumbers.Count < sizeOfRow)
                    {
                        mostRecentNumbers.Add(numbersTable[i, j]);
                    }

                    if (mostRecentNumbers.Count == sizeOfRow)
                    {
                        currentSum = ProductOfList(mostRecentNumbers);

                        if (biggestSum < currentSum)
                        {
                            biggestSum = currentSum;
                            currentSum = 0;
                        }

                        mostRecentNumbers.RemoveAt(0);
                        mostRecentNumbers.Add(numbersTable[i, j]);
                    }
                }
                mostRecentNumbers.Clear();
            }
            return biggestSum;
        }

        public int BiggestVerticalProduct(int[,] numbersTable)
        {
            int currentSum = 0;

            List<int> mostRecentNumbers = new List<int>();

            for (int i = 0; i < numbersTable.GetLength(0); i++)
            {
                for (int j = 0; j < numbersTable.GetLength(1); j++)
                {
                    if (mostRecentNumbers.Count < sizeOfRow)
                    {
                        mostRecentNumbers.Add(numbersTable[j, i]);
                    }

                    if (mostRecentNumbers.Count == sizeOfRow)
                    {
                        currentSum = ProductOfList(mostRecentNumbers);

                        if (biggestSum < currentSum)
                        {
                            biggestSum = currentSum;
                            currentSum = 0;
                        }

                        mostRecentNumbers.RemoveAt(0);
                        mostRecentNumbers.Add(numbersTable[i, j]);
                    }
                }
                mostRecentNumbers.Clear();
            }
            return biggestSum;
        }

        public int BiggestDigonoalProductTopToBot(int[,] numbersTable)
        {
            throw new NotImplementedException();
        }

        public int BiggestDigonalProductBotToTop(int[,] numbersTable)
        {
            throw new NotImplementedException();
        }

        public int ProductOfList(List<int> numbers)
        {
            int product = 1;
            foreach (int number in numbers)
            {
                product = product * number;
            }
            return product;
        }
    }
}
