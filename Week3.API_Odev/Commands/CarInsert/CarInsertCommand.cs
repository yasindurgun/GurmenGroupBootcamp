using MediatR;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Commands
{
    public class CarInsertCommand : IRequest<ResponseDto<int>>
    {
        public CarRequestDto CarRequestDto { get; set; }
    }
}
