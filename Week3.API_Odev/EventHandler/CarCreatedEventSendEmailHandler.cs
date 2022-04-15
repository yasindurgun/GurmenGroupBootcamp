using MediatR;
using Week3.API_Odev.Events;

namespace Week3.API_Odev.EventHandler
{
    public class CarCreatedEventSendEmailHandler : INotificationHandler<CarCreatedEvent>
    {
        private readonly ILogger<CarCreatedEventSendEmailHandler> _logger;
        public CarCreatedEventSendEmailHandler(ILogger<CarCreatedEventSendEmailHandler> logger)
        {
            _logger = logger;
        }
        public Task Handle(CarCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Email Gönderildi : Ürün id={notification.CarId} Ürün Açıklaması : {notification.Description}");

            return Task.CompletedTask;
        }
    }
}
