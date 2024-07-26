using System.Text.Json.Serialization;

public class MobilePhoneSoftwareEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string OperatingSystem { get; set; } = default!;
    public string OSVersion { get; set; } = default!;
    public string FirmwareVersion { get; set; } = default!;
    public bool IsRootedOrJailbroken { get; set; }
    public DateTime? LastSoftwareUpdate { get; set; } = DateTime.Now;

    public Guid MobilePhoneId { get; set; }
    [JsonIgnore]
    public MobilePhoneEntity MobilePhone { get; set; } = default!;
}
