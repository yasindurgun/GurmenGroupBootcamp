using AutoMapper;
using MediatR;
using Week3.API_Odev.Commands.CarDelete;
using Week3.API_Odev.DTOs;
using Week3.API_Odev.Repositories.Abstract;

namespace Week3.API_Odev.Queries.GetAll
{
    public class CarGetAllQueryHandler : IRequestHandler<CarGetAllQuery, ResponseDto<List<CarRequestDto>>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarGetAllQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<CarRequestDto>>> Handle(CarGetAllQuery request, CancellationToken cancellationToken)
        {
            var cars = await _carRepository.GetAll();

            return ResponseDto<List<CarRequestDto>>.Success(_mapper.Map<List<CarRequestDto>>(cars), 200);
        }
    }
}
