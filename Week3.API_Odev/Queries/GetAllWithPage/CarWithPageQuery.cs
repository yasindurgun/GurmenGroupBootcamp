using MediatR;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Queries.GetAllWithPage
{
    public class CarWithPageQuery : IRequest<ResponseDto<List<CarRequestDto>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
