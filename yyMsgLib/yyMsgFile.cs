using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;

namespace yyMsgLib
{
    public class yyMsgFile
    {
        public int? Id { get; init; }
        public Guid Guid { get; init; }

        public yyMsgMessage? Message { get; init; }
        public int? MessageId { get; init; }
        public Guid MessageGuid { get; init; }

        public DateTime CreatedAtUtc { get; init; }
        public yyMsgUser? CreatedByUser { get; init; }
        public int? CreatedByUserId { get; init; }
        public Guid CreatedByUserGuid { get; init; }

        public required yyMsgFilePath Path { get; init; }
        public string AbsolutePath => Path.AbsolutePath;
        public string RelativePath => Path.RelativePath;
        public string RelativeUrl => Path.RelativeUrl;
        public string Name => Path.Name;

        public long Length { get; init; }

        public bool IsImage { get; init; }
        public IImageFormat? ImageFormat { get; init; }
        public Size? ImageSize { get; init; }

        public List <yyMsgResizedImageFile>? ResizedImages { get; init; }
        public int? ResizedImageCount { get; init; }
    }
}
