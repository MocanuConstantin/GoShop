using System.Text.Json.Serialization;

public class MobilePhoneHardwareEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Processor { get; set; } = default!;
    public string RAM { get; set; } = default!;
    public string Storage { get; set; } = default!;
    public string Display { get; set; } = default!;
    public string Battery { get; set; } = default!;
    public string Camera { get; set; } = default!;
    public string Dimensions { get; set; } = default!;
    public string Weight { get; set; } = default!;

    public Guid MobilePhoneId { get; set; }

    [JsonIgnore]
    public MobilePhoneEntity MobilePhone { get; set; } = default!;
}
