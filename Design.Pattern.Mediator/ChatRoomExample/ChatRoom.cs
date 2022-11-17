using Design.Pattern.Command.Api.Receivers;

namespace Design.Pattern.Mediator.ChatRoomExample;

public class ChatRoom :
    IReceiver<TeamMember, string>,
    IReceiver<Developer, string>,
    IReceiver<Tester, string>
{
    public string Handle(TeamMember command)
    {
        return "Team member received a message";
    }

    public string Handle(Developer command)
    {
        return "Developer received a message";
    }

    public string Handle(Tester command)
    {
        return "Tester received a message";
    }
} 