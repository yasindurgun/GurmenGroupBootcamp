using AutoMapper;
using MediatR;
using Week3.API_Odev.DTOs;
using Week3.API_Odev.Repositories.Abstract;

namespace Week3.API_Odev.Queries.GetAllWithPage
{
    public class CarWithPageQueryHandler : IRequestHandler<CarWithPageQuery, ResponseDto<List<CarRequestDto>>>
    {

        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarWithPageQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto<List<CarRequestDto>>> Handle(CarWithPageQuery request, CancellationToken cancellationToken)
        {
            var cars = await _carRepository.GetAllWithPage(request.Page, request.PageSize);

            return ResponseDto<List<CarRequestDto>>.Success(_mapper.Map<List<CarRequestDto>>(cars), 200);
        }
    }
}
