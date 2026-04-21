namespace Post.Common.Events;

using CQRS.Core.Events;

public class PostRemovedEent : BaseEvent
{
    public PostRemovedEent() : base(nameof(PostRemovedEent))
    {
    }
}
