using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNILS_LIBRARY
{
    public class SNILS_CLASS
    {
        public bool CheckPersonakCode(string textString)
        {
            if (string.IsNullOrEmpty(textString))
            {
                return false;
            }
            foreach (char c in textString)
            {
                if (!char.IsDigit(c)) 
                {
                    return false;
                };
            }
            if (textString.Length != 11)
            {
                return false;
            } 
            int[] mas = new int[11];
            for (int i = 0; i < mas.Length-2;i++)
            {
                mas[i] = Convert.ToInt32(Char.GetNumericValue(textString[i]));
            }
            int sum = Convert.ToInt32(textString.Substring(9,2));
            int[] pos = new int[9] { mas[0] * 9, mas[1] * 8, mas[2] * 7, mas[3] * 6, mas[4] * 5, mas[5] * 4, mas[6] * 3, mas[7] * 2, mas[8] * 1, };
            int possum = 0;
            for (int i =0; i < pos.Length;i++)
            {
                possum+= pos[i];
            }
            if (possum > 101)
            {
                possum = possum % 101;
            }
            int asum = 0;
            if (sum == 0)
            {
                sum = 100;
                asum = 101;
            }
            if (possum > 101)
            {
                possum = possum % 101;
            }
            if (possum == sum || possum == asum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
