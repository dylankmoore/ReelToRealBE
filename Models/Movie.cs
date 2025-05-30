﻿namespace ReelToReal.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Genre { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? VideoUrl { get; set; }
    }
}
