using MediatR;
using Week3.API_Odev.DTOs;
using Week3.API_Odev.Repositories.Abstract;

namespace Week3.API_Odev.Commands.CarInsert
{
    public class CarInsertCommandHandler : IRequestHandler<CarInsertCommand, ResponseDto<int>>
    {

        private readonly ICarRepository _carRepository;
        private readonly IMediator _mediator;

        public CarInsertCommandHandler(ICarRepository carRepository, IMediator mediator)
        {
            _carRepository = carRepository;
            _mediator = mediator;
        }
        public async Task<ResponseDto<int>> Handle(CarInsertCommand request, CancellationToken cancellationToken)
        {
            var id = await _carRepository.Save(request);

            return ResponseDto<int>.Success(id, 201);
        }
    }
}
