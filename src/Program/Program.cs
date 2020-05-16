using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia PictureProvide que abrirá una imagen con un Método.
            PictureProvider p = new PictureProvider();
            //GetPicture retornará una instancia de Picture.
            IPicture pic = p.GetPicture("C:/Users/estudiante.fit/Pipes_G3/matrix.png");

            //Necesario instanciar los filtros, porque los "Pipes" se instancian del ultimo al primero.
            IFilter filterGreyscale= new FilterGreyscale();
            IFilter filterNegative = new FilterNegative();
            
            //
            IPipe ipip2 = new PipeSerial(filterNegative, new PipeNull());
            IPipe ipip1 = new PipeSerial(filterGreyscale, ipip2);

            ipip2.Send(pic);

            
        }
    }
}
