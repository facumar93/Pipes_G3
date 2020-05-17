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
            //IPicture pic = p.GetPicture("C:/Users/estudiante.fit/Pipes_G3/matrix.png");
            IPicture pic = p.GetPicture("../imageTest.JPG");

            IFilter filterGreyscale= new FilterGreyscale();
            IFilter filterNegative = new FilterNegative();
            IFilter filterProvider = new FilterProvider();
            
            IPipe pipeNull = new PipeNull();
            IPipe pipeProvider2 = new PipeSerial(filterProvider, pipeNull);
            IPipe pipeSerial2 = new PipeSerial(filterNegative,pipeProvider2);
            IPipe pipeProvider1 = new PipeSerial(filterProvider,pipeSerial2);
            IPipe pipeSerial1 = new PipeSerial(filterGreyscale,pipeProvider1);

            pipeSerial1.Send(pic);
            

           



            
        }
    }
}
