using LLD.ConsoleApp.Decorator.ImageEditingApplication.Utils;

namespace LLD.ConsoleApp.Decorator.ImageEditingApplication
{
    public interface IImageEditor
    {
        Image ReadImage(string filePath);
        public void Render(Image image);
    }
}