namespace WindowHand.Models
{
    public sealed class NetworkAdapterInfo
    {
        public required string Name { get; init; }

        public string? Description { get; init; }

        public string? DeviceId { get; init; }

        public string? NetConnectionId { get; init; }

        public bool? NetEnabled { get; init; }

        public string NetEnabledText => NetEnabled switch
        {
            true => "有効",
            false => "無効",
            _ => "不明"
        };
    }
}
