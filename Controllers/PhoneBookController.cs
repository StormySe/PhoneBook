using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Commands;

namespace PhoneBook.Controllers
{
    public class PhoneBookController : ControllerBase
    {
        private readonly IMediator mediator;

        public PhoneBookController(IMediator mediator) => this.mediator = mediator;

        [HttpPost("addnumber")]
        public async Task<Guid> AddNumber(AddNumberCommand cmd)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info("Number Added");
            return await mediator.Send(cmd);
        }
    }
}
