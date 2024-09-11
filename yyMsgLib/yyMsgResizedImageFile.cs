using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;

namespace yyMsgLib
{
    public class yyMsgResizedImageFile
    {
        public required yyMsgImageResizingOptions Options { get; init; }

        public required yyMsgFilePath Path { get; init; }
        public string AbsolutePath => Path.AbsolutePath;
        public string RelativePath => Path.RelativePath;
        public string RelativeUrl => Path.RelativeUrl;
        public string Name => Path.Name;

        public long Length { get; init; }

        public required IImageFormat ImageFormat { get; init; }
        public Size ImageSize { get; init; }
    }
}
