using MediatR;

namespace Week3.API_Odev.Events
{
    public class CarCreatedEvent : INotification
    {
        public int CarId { get; set; }
        public string Description { get; set; }
    }
}
