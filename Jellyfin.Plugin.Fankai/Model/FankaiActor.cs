using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Fankai.Model;

/// <summary>
/// Représente les données d'un acteur provenant de l'API Fankai.
/// </summary>
public class FankaiActor
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("thumb_url")]
    public string? ThumbUrl { get; set; }

    [JsonPropertyName("profile_url")]
    public string? ProfileUrl { get; set; }

    [JsonPropertyName("total_appearances")]
    public int? TotalAppearances { get; set; }
}