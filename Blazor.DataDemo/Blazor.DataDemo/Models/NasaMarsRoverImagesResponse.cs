using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Blazor.DataDemo.Models
{
    public class NasaMarsRoverImagesResponse
    {
        [JsonPropertyName("photos")]
        public List<MarsRoverPhoto> Photos { get; set; }
    }

    public class MarsRoverPhoto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("sol")]
        public int Sol { get; set; }

        [JsonPropertyName("camera")]
        public MarsRoverCamera Camera { get; set; }

        [JsonPropertyName("img_src")]
        public string ImgSrc { get; set; }

        [JsonPropertyName("earth_date")]
        public string EarthDate { get; set; }

        [JsonPropertyName("rover")]
        public MarsRover Rover { get; set; }
    }

    public class MarsRoverCamera
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rover_id")]
        public int RoverId { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
    }

    public class MarsRover
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("landing_date")]
        public string LandingDate { get; set; }

        [JsonPropertyName("launch_date")]
        public string LaunchDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
