using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelArrays
{
    public class ArrayHelper
    {
        public static int CountDifferentFrom(int[] elements, int value)
        {
            // TODO - Tel hoeveel getallen verschillen in elements van de waarde 'value'
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] != value)
                {
                    counter++;
                }
            }

            // TODO - Return het resultaat
            return counter;
        }

        public static int[] SumByElements(int[] first, int[] second)
        {
            // TODO - Maak een nieuwe array aan ter grootte van first of second
            // Je mag er hier van uit gaan dat beide array dezelfde grootte hebben.

            int[] result = new int[first.Length];

            // TODO - Maak de element-gewijze som van first en second en plaats het
            // resultaat op dezelfde index in de nieuwe array

            for (int i = 0; i < first.Length; i++)
            {
                result[i] = first[i] + second[i];
            }

            // TODO - Return de resulterende array
            return result;
        }

        public static int[] DoubleInSize(int[] numbers)
        {
            // TODO - Maak een nieuwe array die dubbel zo groot is als `numbers`.
            int[] doubleNumbers = new int[2 * numbers.Length];


            // TODO - Kopieerd de getallen van `numbers` naar de nieuwe array
            // (startend vanaf het begin)
            for (int i = 0; i < numbers.Length; i++)
            {
                doubleNumbers[i] = numbers[i];
            }


            // TODO - Return de nieuwe array als resultaat
            return doubleNumbers;
        }
    }
}
