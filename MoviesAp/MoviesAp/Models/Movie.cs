using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Toolkit.Mvvm;
using Newtonsoft.Json;

namespace MoviesAp.Models
{
    public class YTS
    {
        public string Status { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        public YTSData Data { get; set; }
    }

    public class YTSData
    {
        [JsonProperty("movie_count")]
        public int MovieCount { get; set; }

        public int Limit { get; set; }

        [JsonProperty("page_number")]
        public int PageNumber { get; set; }

        public List<Movie> Movies { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }

        public string Url { get; set; }

        [JsonProperty("imdb_code")]
        public string IMDBCode { get; set; }

        public string Title { get; set; }

        [JsonProperty("title_english")]
        public string TitleEnglish { get; set; }

        [JsonProperty("title_long")]
        public string TitleLong { get; set; }

        public string Slug { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public double Runtime { get; set; }

        //public string[] Genres { get; set; }

        public string Summmary { get; set; }

        [JsonProperty("description_full")]
        public string Description { get; set; }

        public string Sypnosis { get; set; }

        [JsonProperty("yt_trailer_code")]
        public string YTTrailerCode { get; set; }

        public string Language { get; set; }

        [JsonProperty("mpa_rating")]
        public string MPARating { get; set; }

        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }

        [JsonProperty("background_image_original")]
        public string BackgroundImageOriginal { get; set; }

        [JsonProperty("small_cover_image")]
        public string SmallCoverImage { get; set; }

        [JsonProperty("medium_cover_image")]
        public string MediumCoverImage { get; set; }

        [JsonProperty("large_cover_image")]
        public string LargeCoverImage { get; set; }

        public string State { get; set; }

        public List<Torrent> Torrents { get; set; }

        [JsonProperty("date_uploaded")]
        public DateTime DateUploaded { get; set; }

        [JsonProperty("date_uploaded_unix")]
        public long DateUploadedUnix { get; set; }
    }

    public class Torrent
    {
        public string Url { get; set; }

        public string Hash { get; set; }

        public string Quality { get; set; }

        public string Type { get; set; }

        public int Seeds { get; set; }

        public int Peers { get; set; }

        public string Size { get; set; }

        [JsonProperty("size_bytes")]
        public long SizeBytes { get; set; }

        [JsonProperty("date_uploaded")]
        public DateTime DateUploaded { get; set; }

        [JsonProperty("date_uploaded_unix")]
        public long DateUploadedUnix { get; set; }
    }
}
