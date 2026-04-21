namespace Post.Common.Events;

using CQRS.Core.Events;

public class CommentRemovedEvent : BaseEvent
{
    public CommentRemovedEvent() : base(nameof(CommentRemovedEvent))
    {
    }
    public Guid CommentId { get; set; }
}
