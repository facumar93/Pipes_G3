using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterConditional : IFilter
    {
        public Boolean result { get; set; }
        public IPicture Filter (IPicture image)
        {
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242", true, Color.GreenYellow);
            cog.Recognize($"../imageWithFilter{contador}.JPG");
            contador = contador + 1;

            if (cog.FaceFound == true)
            {
                result = true;
                return image;
            }
            else 
            {
                result = false;
                return image;
            }
        }

        private int contador = 1;
    }
}