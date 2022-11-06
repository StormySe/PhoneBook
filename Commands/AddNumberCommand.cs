using MediatR;

namespace PhoneBook.Commands
{
    public class AddNumberCommand : IRequest<Guid>
    {
        public string Name { get; }
        public string Number { get; }
        public AddNumberCommand(string number, string name)
        {
            Number = number;
            Name = name;   
        }
        public AddNumberCommand() { }
    }

}
