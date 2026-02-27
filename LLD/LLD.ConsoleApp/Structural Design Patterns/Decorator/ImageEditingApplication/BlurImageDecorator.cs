using LLD.ConsoleApp.Decorator.ImageEditingApplication.Utils;

namespace LLD.ConsoleApp.Decorator.ImageEditingApplication
{
    public class BlurImageDecorator : BaseImageDecorator
    {
        public BlurImageDecorator(IImageEditor imageEditor) : base(imageEditor) { }

        public override Image ReadImage(string filePath) => ImageUtils.ApplyBlur(_imageEditor.ReadImage(filePath));
    }
}