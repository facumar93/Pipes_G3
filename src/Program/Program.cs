using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("../faceImage.jpg");

            IFilter filterGreyscale= new FilterGreyscale();
            IFilter filterNegative = new FilterNegative();
            IFilter filterProvider = new FilterProvider();
            IFilter filterTwiter = new FilterTwitter();
            IFilter filterConditional = new FilterConditional();
            IFilter filterBlurConvolution = new FilterBlurConvolution();
            IFilter filterSharpenConvolution = new FilterSharpenConvolution();
            
            //EJERCICIO 1

            IPipe pipeNull_ej1 = new PipeNull();  
            IPipe pipeSerial2_ej1 = new PipeSerial(filterNegative,pipeNull_ej1);
            IPipe pipeSerial1_ej1 = new PipeSerial(filterGreyscale,pipeSerial2_ej1);
            
            pipeSerial1_ej1.Send(pic);

            //EJERCICIO 2
            
            IPipe pipeNull_ej2 = new PipeNull();
            IPipe pipeProvider2_ej2 = new PipeSerial(filterProvider, pipeNull_ej2);
            IPipe pipeSerial2_ej2 = new PipeSerial(filterNegative,pipeProvider2_ej2);
            IPipe pipeProvider1_ej2 = new PipeSerial(filterProvider,pipeSerial2_ej2);
            IPipe pipeSerial1_ej2 = new PipeSerial(filterGreyscale,pipeProvider1_ej2);
            
            pipeSerial1_ej2.Send(pic);
          

            //EJERCICIO 3
                
            IPipe pipeNull_ej3 = new PipeNull();
            IPipe pipeTwiter2_ej3 = new PipeSerial(filterTwiter, pipeNull_ej3);
            IPipe pipeProvider2_ej3 = new PipeSerial(filterProvider, pipeTwiter2_ej3);
            IPipe pipeSerial2_ej3 = new PipeSerial(filterNegative,pipeProvider2_ej3);
            IPipe pipeTwiter1_ej3 = new PipeSerial(filterTwiter,pipeSerial2_ej3);
            IPipe pipeProvider1_ej3 = new PipeSerial(filterProvider, pipeTwiter1_ej3);
            IPipe pipeSerial1_ej3 = new PipeSerial(filterGreyscale,pipeProvider1_ej3);
        
            pipeSerial1_ej3.Send(pic);
            

            //EJERCICIO 4

            IPipe pipeNull_ej4 = new PipeNull();
            IPipe pipeProvider2_ej4 = new PipeSerial(filterProvider, pipeNull_ej4);
            IPipe pipeSerial2_ej4 = new PipeSerial(filterNegative, pipeProvider2_ej4);
            IPipe pipeTwiter1_ej4 = new PipeSerial(filterTwiter, pipeNull_ej4);
            IPipe pipeConditionalFork1_ej4 = new PipeConditionalFork(filterConditional, pipeTwiter1_ej4, pipeSerial2_ej4);
            IPipe pipeProvider1_ej4 = new PipeSerial(filterProvider, pipeConditionalFork1_ej4);
            IPipe pipeSerial1_ej4 = new PipeSerial(filterGreyscale, pipeProvider1_ej4);

            pipeSerial1_ej4.Send(pic);
            

            //EJERCICIO BONUS

            IPipe pipeNull_ejB = new PipeNull();
            IPipe pipeProvider2_ejB = new PipeSerial(filterProvider,pipeNull_ejB);
            IPipe pipeSerial2_ejB = new PipeSerial(filterSharpenConvolution,pipeProvider2_ejB);
            IPipe pipeProvider1_ejB = new PipeSerial(filterProvider,pipeSerial2_ejB);
            IPipe pipeSerial1_ejB = new PipeSerial(filterBlurConvolution,pipeProvider1_ejB);

            pipeSerial1_ejB.Send(pic);
        }
    }
}