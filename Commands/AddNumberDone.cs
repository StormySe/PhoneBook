using MediatR;
namespace PhoneBook.Commands
{
    public class AddNumberDone : INotification
    {
        public Guid Id { get; }
        public AddNumberDone(Guid id)
        {
            Id = id;
        }
    }
    public class Notified : INotificationHandler<AddNumberDone>
    {
        public Task Handle(AddNumberDone notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
