using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterBlurConvolution : Convolution
    {
        public FilterBlurConvolution() : base()
        {
            this.matrizParametros = new int[3, 3];
            this.complemento = 30;
            this.divisor = 9;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrizParametros[x, y] = 1;
                }
            }
        }
        
    }
}