using MediatR;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Commands.CarDelete
{
    public class CarDeleteCommand : IRequest<ResponseDto<NoContent>>
    {
        public int Id { get; set; }
    }
}
