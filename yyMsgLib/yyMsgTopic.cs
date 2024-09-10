namespace yyMsgLib
{
    public class yyMsgTopic
    {
        public int? Id { get; init; }
        public Guid Guid { get; init; }

        public DateTime CreatedAtUtc { get; init; }

        public required string Name { get; set; } // Updatable

        public bool IsArchived { get; set; }
        public DateTime? ArchivedAtUtc { get; set; }

        public List <yyMsgMessage> Messages { get; init; } = [];
        public int MessageCount { get; set; }
        public DateTime? LastMessageCreatedAtUtc { get; set; }
    }
}
