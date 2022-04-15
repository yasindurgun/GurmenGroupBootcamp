using MediatR;
using Week3.API_Odev.DTOs;
using Week3.API_Odev.Repositories.Abstract;

namespace Week3.API_Odev.Commands.CarDelete
{
    public class CarDeleteCommandHandler : IRequestHandler<CarDeleteCommand, ResponseDto<NoContent>>
    {

        private readonly ICarRepository _carRepository;
        private readonly IMediator _mediator;

        public CarDeleteCommandHandler(ICarRepository carRepository, IMediator mediator)
        {
            _carRepository = carRepository;
            _mediator = mediator;
        }
        public async Task<ResponseDto<NoContent>> Handle(CarDeleteCommand request, CancellationToken cancellationToken)
        {
            var result = await _carRepository.Delete(request);

            if (!result)
            {
                return ResponseDto<NoContent>.Fail("silme işlemi başarısız", 500);
            }

            return ResponseDto<NoContent>.Success(204);
        }
    }
}
