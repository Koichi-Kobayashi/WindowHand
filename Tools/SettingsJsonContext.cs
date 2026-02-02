using System.Text.Json.Serialization;

namespace Generated.Settings;

// 重要：partial / 継承だけ。コンストラクタやメンバーは書かない。
[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
[JsonSerializable(typeof(Root))]
internal partial class SettingsJsonContext : JsonSerializerContext
{
}
