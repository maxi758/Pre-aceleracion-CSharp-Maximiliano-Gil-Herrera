﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DisneyAPI.ViewModels.MovieOrSerieViewModel
{
    public class MovieOrSerieGetRequestViewModel
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(0, Int32.MaxValue)]
        public int GenreId { get; set; }
        [MaxLength(3)]
        public string Order { get; set; }
    }
}
