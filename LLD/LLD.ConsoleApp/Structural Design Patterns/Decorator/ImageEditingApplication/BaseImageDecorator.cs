using LLD.ConsoleApp.Decorator.ImageEditingApplication.Utils;

namespace LLD.ConsoleApp.Decorator.ImageEditingApplication
{
    public abstract class BaseImageDecorator : IImageEditor
    {
        protected IImageEditor _imageEditor;

        public BaseImageDecorator(IImageEditor imageEditor)
        {
            _imageEditor = imageEditor;
        }

        public virtual Image ReadImage(string filePath) => _imageEditor.ReadImage(filePath);
        public void Render(Image image) => _imageEditor.Render(image);
    }
}