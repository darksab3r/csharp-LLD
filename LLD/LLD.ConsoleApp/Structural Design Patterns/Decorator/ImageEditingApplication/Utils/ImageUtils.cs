namespace LLD.ConsoleApp.Decorator.ImageEditingApplication.Utils
{
    public class ImageUtils
    {
        public static Image Read(string filePath)
        {
            return new Image(filePath);
        }

        public static Image ConvertToGrayscale(Image image)
        {
            return image;
        }

        public static Image ApplyBlur(Image image)
        {
            return image;
        }

        public static void Render(Image image)
        {
        }
    }
}