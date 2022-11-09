using System;
namespace Design.Pattern.Command.Api.Commands
{
    public class DeleteNameCommand : ICommand<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Execute()
        {
            var user = new User();
            user.Id = Id;
            user.Name = Name;
        }
    }
}

