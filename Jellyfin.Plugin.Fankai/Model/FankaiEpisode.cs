using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Fankai.Model;

/// <summary>
/// Représente les données d'un épisode provenant de l'API Fankai.
/// </summary>
public class FankaiEpisode
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }

    [JsonPropertyName("episode_number")]
    public int? EpisodeNumber { get; set; }

    [JsonPropertyName("display_episode")]
    public string? DisplayEpisode { get; set; }

    [JsonPropertyName("display_season")]
    public string? DisplaySeason { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("show_title")]
    public string? ShowTitle { get; set; }

    [JsonPropertyName("plot")]
    public string? Plot { get; set; }

    [JsonPropertyName("aired")]
    public string? Aired { get; set; }

    [JsonPropertyName("mpaa")]
    public string? Mpaa { get; set; }

    [JsonPropertyName("studio")]
    public string? Studio { get; set; }

    [JsonPropertyName("date_added")]
    public string? DateAdded { get; set; }

    [JsonPropertyName("duration")]
    public int? DurationInSeconds { get; set; }

    [JsonPropertyName("audio_info")]
    public string? AudioInfo { get; set; }

    [JsonPropertyName("subtitle_info")]
    public string? SubtitleInfo { get; set; }

    [JsonPropertyName("nfo_filename")]
    public string? NfoFilename { get; set; }

    [JsonPropertyName("nfo_path")]
    public string? NfoPath { get; set; }

    [JsonPropertyName("original_filename")]
    public string? OriginalFilename { get; set; }

    [JsonPropertyName("formatted_name")]
    public string? FormattedName { get; set; }

    [JsonPropertyName("thumb_image")]
    public string? ThumbImageUrl { get; set; }

    [JsonPropertyName("last_update")]
    public double? LastUpdate { get; set; }

    [JsonPropertyName("links")]
    public EpisodeLinks? Links { get; set; }
}

public class EpisodeLinks
{
    [JsonPropertyName("season")]
    public string? SeasonApiUrl { get; set; }

    [JsonPropertyName("serie")]
    public string? SerieApiUrl { get; set; }
}