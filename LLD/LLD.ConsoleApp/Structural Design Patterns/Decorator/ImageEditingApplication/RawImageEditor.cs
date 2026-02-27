using LLD.ConsoleApp.Decorator.ImageEditingApplication.Utils;

namespace LLD.ConsoleApp.Decorator.ImageEditingApplication
{
    public class RawImageEditor: IImageEditor
    {
        public Image ReadImage(string filePath)
        {
            return ImageUtils.Read(filePath);
        }
        public void Render(Image image)
        {
            ImageUtils.Render(image);
        }
    }
}