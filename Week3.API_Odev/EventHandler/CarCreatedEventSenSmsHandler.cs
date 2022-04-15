using MediatR;
using Week3.API_Odev.Events;

namespace Week3.API_Odev.EventHandler
{
    public class CarCreatedEventSenSmsHandler : INotificationHandler<CarCreatedEvent>
    {
        private readonly ILogger<CarCreatedEventSenSmsHandler> _logger;
        public CarCreatedEventSenSmsHandler(ILogger<CarCreatedEventSenSmsHandler> logger)
        {
            _logger = logger;
        }
        public Task Handle(CarCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Sms Gönderildi : Ürün id={notification.CarId} Ürün Açıklaması : {notification.Description}");

            return Task.CompletedTask;
        }
    }
}
