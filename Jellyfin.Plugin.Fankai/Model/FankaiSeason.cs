using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Fankai.Model;

/// <summary>
/// Représente les données d'une saison provenant de l'API Fankai.
/// </summary>
public class FankaiSeason
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("serie_id")]
    public int SerieId { get; set; }

    [JsonPropertyName("season_number")]
    public int? SeasonNumber { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("sort_title")]
    public string? SortTitle { get; set; }

    [JsonPropertyName("plot")]
    public string? Plot { get; set; }

    [JsonPropertyName("premiered")]
    public string? Premiered { get; set; }

    [JsonPropertyName("last_update")]
    public double? LastUpdate { get; set; }

    [JsonPropertyName("ids")]
    public SeasonIds? Ids { get; set; }

    [JsonPropertyName("statistics")]
    public SeasonStatistics? Statistics { get; set; }

    [JsonPropertyName("links")]
    public SeasonLinks? Links { get; set; }

    [JsonPropertyName("images")]
    public SeasonImageLinks? Images { get; set; }
}

public class SeasonIds
{
    [JsonPropertyName("imdb")]
    public string? Imdb { get; set; }

    [JsonPropertyName("tmdb")]
    public string? Tmdb { get; set; }

    [JsonPropertyName("tvdb")]
    public string? Tvdb { get; set; }
}

public class SeasonStatistics
{
    [JsonPropertyName("episode_count")]
    public int? EpisodeCount { get; set; }

    [JsonPropertyName("first_aired")]
    public string? FirstAired { get; set; }

    [JsonPropertyName("last_aired")]
    public string? LastAired { get; set; }

    [JsonPropertyName("episodes_with_thumbnails")]
    public int? EpisodesWithThumbnails { get; set; }
}

public class SeasonLinks
{
    [JsonPropertyName("episodes")]
    public string? EpisodesApiUrl { get; set; }

    [JsonPropertyName("serie")]
    public string? SerieApiUrl { get; set; }
}

public class SeasonImageLinks
{
    [JsonPropertyName("poster")]
    public string? PosterApiUrl { get; set; }

    [JsonPropertyName("fanart")]
    public string? FanartApiUrl { get; set; }
}