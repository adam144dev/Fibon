using System.Threading.Tasks;

namespace Fibon.Api.Events
{
    public interface IEvent
    {
         
    }

    public interface IEventHAndler<in T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }

    public class VAlueCalculateEvent : IEvent
    {
        public int Number { get; set; }
        public int Value { get; set; }
    }
    
}