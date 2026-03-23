using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Fankai.Model;

/// <summary>
/// Représente les données d'une série provenant de l'API Fankai.
/// </summary>
public class FankaiSerie
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }

    [JsonPropertyName("show_title")]
    public string? ShowTitle { get; set; }

    [JsonPropertyName("title_for_plex")]
    public string? TitleForPlex { get; set; }

    [JsonPropertyName("year")]
    public int? Year { get; set; }

    [JsonPropertyName("plot")]
    public string? Plot { get; set; }

    [JsonPropertyName("premiered")]
    public string? Premiered { get; set; }

    [JsonPropertyName("studio")]
    public string? Studio { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("genres")]
    public string? Genres { get; set; }

    [JsonPropertyName("theme_music")]
    public string? ThemeMusicUrl { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("date_added")]
    public string? DateAdded { get; set; }

    [JsonPropertyName("last_update")]
    public double? LastUpdate { get; set; }

    [JsonPropertyName("ids")]
    public SerieIds? Ids { get; set; }

    [JsonPropertyName("rating")]
    public SerieRating? Rating { get; set; }

    [JsonPropertyName("statistics")]
    public SerieStatistics? Statistics { get; set; }

    [JsonPropertyName("links")]
    public SerieLinks? Links { get; set; }

    [JsonPropertyName("images")]
    public SerieImageLinks? Images { get; set; }
}

public class SerieIds
{
    [JsonPropertyName("imdb")]
    public string? Imdb { get; set; }

    [JsonPropertyName("tmdb")]
    public string? Tmdb { get; set; }

    [JsonPropertyName("tvdb")]
    public string? Tvdb { get; set; }
}

public class SerieRating
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("user")]
    public float? User { get; set; }

    [JsonPropertyName("value")]
    public float? Value { get; set; }

    [JsonPropertyName("votes")]
    public int? Votes { get; set; }
}

public class SerieStatistics
{
    [JsonPropertyName("seasons_count")]
    public int? SeasonsCount { get; set; }

    [JsonPropertyName("episodes_count")]
    public int? EpisodesCount { get; set; }

    [JsonPropertyName("first_aired")]
    public string? FirstAired { get; set; }

    [JsonPropertyName("last_aired")]
    public string? LastAired { get; set; }
}

public class SerieLinks
{
    [JsonPropertyName("seasons")]
    public string? SeasonsApiUrl { get; set; }

    [JsonPropertyName("actors")]
    public string? ActorsApiUrl { get; set; }
}

public class SerieImageLinks
{
    [JsonPropertyName("banner")]
    public string? BannerApiUrl { get; set; }

    [JsonPropertyName("fanart")]
    public string? FanartApiUrl { get; set; }

    [JsonPropertyName("poster")]
    public string? PosterApiUrl { get; set; }

    [JsonPropertyName("logo")]
    public string? LogoApiUrl { get; set; }
}