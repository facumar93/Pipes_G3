using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterSharpenConvolution : Convolution
    {
        public FilterSharpenConvolution() : base()
        {
            this.matrizParametros = new int[3, 3];
            this.complemento = 0;
            this.divisor = 8;
            matrizParametros[0,0] = -1;
            matrizParametros[0,1] = -1;
            matrizParametros[0,2] = -1;
            matrizParametros[1,0] = -1;
            matrizParametros[1,1] = -16;
            matrizParametros[1,2] = -1;
            matrizParametros[2,0] = -1;
            matrizParametros[2,1] = -1;
            matrizParametros[2,2] = -1;
            
        }
        
    }
}