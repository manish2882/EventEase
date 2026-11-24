public Event? GetEventById(int id)
{
    return GetEvents()
        .FirstOrDefault(x => x.Id == id);
}
public class EventService
{
    private List<Event>? _cachedEvents;

    public List<Event> GetEvents()
    {
        if (_cachedEvents != null)
            return _cachedEvents;

        _cachedEvents = new List<Event>
        {
            new Event
            {
                Id = 1,
                Name = "Tech Conference",
                Date = DateTime.Today.AddDays(10),
                Location = "Noida"
            },
            new Event
            {
                Id = 2,
                Name = "Leadership Summit",
                Date = DateTime.Today.AddDays(20),
                Location = "Delhi"
            }
        };

        return _cachedEvents;
    }
}