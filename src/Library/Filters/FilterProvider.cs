namespace CompAndDel.Filters
{
    public class FilterProvider : IFilter
    {
        private int contador = 1;
        public IPicture Filter (IPicture image)
        {
            PictureProvider p2 = new PictureProvider();
            p2.SavePicture(image, $"../imageWithFilter{contador}.JPG");
            contador = contador + 1;
            return image;
        }
    }
}