using Design.Pattern.Command.Api;
using Design.Pattern.Mediator.ChatRoomExample;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddMediator(typeof(Program));

var provider = services.BuildServiceProvider();
var mediator = provider.GetRequiredService<IMediator>();

Console.WriteLine(mediator.Send(new Developer()));
Console.WriteLine(mediator.Send(new Tester()));
Console.WriteLine(mediator.Send(new TeamMember()));
