using LLD.ConsoleApp.Decorator.ImageEditingApplication.Utils;

namespace LLD.ConsoleApp.Decorator.ImageEditingApplication
{
    public class GrayscaleImageDecorator : BaseImageDecorator
    {
        public GrayscaleImageDecorator(IImageEditor imageEditor) : base(imageEditor) { }

        public override Image ReadImage(string filePath) => ImageUtils.ConvertToGrayscale(_imageEditor.ReadImage(filePath));
    }
}