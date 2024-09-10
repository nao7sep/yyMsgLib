namespace yyMsgLib
{
    public class yyMsgMessage
    {
        public int? Id { get; init; }
        public Guid Guid { get; init; }

        public yyMsgTopic? Topic { get; init; }
        public int? TopicId { get; init; }
        public Guid TopicGuid { get; init; }

        public DateTime CreatedAtUtc { get; init; }
        public yyMsgUser? CreatedByUser { get; init; }
        public int? CreatedByUserId { get; init; }
        public Guid CreatedByUserGuid { get; init; }

        public required string Content { get; set; } // Updatable

        public bool IsPinned { get; set; }
        public DateTime? PinnedAtUtc { get; set; }
        public yyMsgUser? PinnedByUser { get; set; }
        public int? PinnedByUserId { get; set; }
        public Guid PinnedByUserGuid { get; set; }

        public List <yyMsgFile> Attachments { get; init; } = [];
        public int AttachmentCount { get; set; }
    }
}
