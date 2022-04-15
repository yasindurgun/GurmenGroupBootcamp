using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week3.API_Odev.Commands;
using Week3.API_Odev.Commands.CarDelete;
using Week3.API_Odev.Commands.CarUpdate;
using Week3.API_Odev.Queries.GetAll;
using Week3.API_Odev.Queries.GetAllWithPage;

namespace Week3.API_Odev.Controllers
{

    public class CarsController : ControllerCustomBase
    {
        IMediator _mediator;
        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new CarGetAllQuery());
            return CreateActionResult(response);
        }

        [HttpGet("pages/{page}/{pagesize}")]
        public async Task<IActionResult> GetAllWithPage(int page, int pagesize)
        {

            var response = await _mediator.Send(new CarWithPageQuery() { Page = page, PageSize = pagesize });

            return CreateActionResult(response);

        }

        [HttpPost]
        public async Task<IActionResult> Save(CarInsertCommand carInsertCommand)
        {

            return CreateActionResult(await _mediator.Send(carInsertCommand));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CarUpdateCommand carUpdateCommand)
        {

            return CreateActionResult(await _mediator.Send(carUpdateCommand));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            return CreateActionResult(await _mediator.Send(new CarDeleteCommand() { Id = id }));
        }
    }
}
