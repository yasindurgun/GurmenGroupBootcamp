using MediatR;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Commands
{
    public class CarInsertCommand : IRequest<ResponseDto<int>>
    {
        public int Id { get; set; }
        public string ModelYear { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string SerialNumber { get; set; }
    }
}
