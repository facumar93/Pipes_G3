using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;


namespace CompAndDel.Pipes
{
    public class PipeConditionalFork : IPipe
    {
        IPipe next2Pipe;
        IPipe nextPipe;
        IFilter filter;

         public PipeConditionalFork(IFilter filter, IPipe nextPipe, IPipe next2Pipe) 
        {
            this.next2Pipe = next2Pipe;
            this.nextPipe = nextPipe; 
            this.filter = filter;          
        }
        public IPicture Send(IPicture picture)
        {
            picture = this.filter.Filter(picture);

            if (filter.result == true)
            {
                return this.nextPipe.Send(picture);
            }
            else
            {
                return this.next2Pipe.Send(picture);
            }
        
        }
    }
}

//picture = this.filtro.Filter(picture);
            //return this.nextPipe.Send(picture);