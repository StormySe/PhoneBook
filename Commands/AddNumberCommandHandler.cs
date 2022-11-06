using MediatR;
using PhoneBook.Entities;

namespace PhoneBook.Commands
{
    public class AddNumberCommandHandler : IRequestHandler<AddNumberCommand, Guid>
    {
        private readonly IMediator mediator;
        public AddNumberCommandHandler(IMediator mediator) => this.mediator = mediator;
        public async Task<Guid> Handle(AddNumberCommand request, CancellationToken cancellationToken)
        {
            var note = new Note(Guid.NewGuid(), request.Name, request.Number);

            await mediator.Publish(new AddNumberDone(note.Id));

            return note.Id;
        }
    }

}
