namespace CoreBusiness.API.DTOs;

public class CreateEventRequest
{
    public string SourceType { get; set; } = string.Empty;

    public string EventType { get; set; } = string.Empty;

    public string? DeviceId { get; set; }

    public string? CardId { get; set; }

    public string? CameraId { get; set; }

    public double? Value { get; set; }

    public string? Zone { get; set; }
}