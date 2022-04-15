using MediatR;
using Week3.API_Odev.DTOs;
using Week3.API_Odev.Repositories.Abstract;

namespace Week3.API_Odev.Commands.CarUpdate
{
    public class CarUpdateCommandHandler : IRequestHandler<CarUpdateCommand, ResponseDto<NoContent>>
    {
        private readonly ICarRepository _carRepository;

        public CarUpdateCommandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<ResponseDto<NoContent>> Handle(CarUpdateCommand request, CancellationToken cancellationToken)
        {
            var result = await _carRepository.Update(request);

            if (!result)
            {
                return ResponseDto<NoContent>.Fail("update işlemi başarısız", 500);
            }

            return ResponseDto<NoContent>.Success(204);
        }
    }
}
