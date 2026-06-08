namespace CoreBusiness.API.DTOs;

public class EventRequest
{
    public string EventId { get; set; } = string.Empty;

    public string EventType { get; set; } = string.Empty;

    public string Source { get; set; } = string.Empty;

    public DateTime Timestamp { get; set; }

    public string Version { get; set; } = string.Empty;

    public string DeviceId { get; set; } = string.Empty;

    public string CorrelationId { get; set; } = string.Empty;

    public string Payload { get; set; } = string.Empty;
}