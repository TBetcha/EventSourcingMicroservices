namespace Post.Cmd.Api.Commands;

using CQRS.Core.Commands;

public class EditMessgeCommand: BaseCommand
{
  public string Message {get; set;}
}
