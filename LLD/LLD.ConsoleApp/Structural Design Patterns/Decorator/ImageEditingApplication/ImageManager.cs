using LLD.ConsoleApp.Decorator.ImageEditingApplication.Utils;

namespace LLD.ConsoleApp.Decorator.ImageEditingApplication
{
    public class ImageManager
    {
        public Image ReadImage(string filePath, bool enableGrayscale, bool enableBlur)
        {
            IImageEditor editor = new RawImageEditor();

            if (enableGrayscale)
                editor = new GrayscaleImageDecorator(editor);

            if (enableBlur)
                editor = new BlurImageDecorator(editor);

            return editor.ReadImage(filePath);
        }
    }
}