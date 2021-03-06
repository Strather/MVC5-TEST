﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Donations.Models {
    public class Movie {

        public int ID { get; set; }
        public string Title { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true, HtmlEncode = true)]
		public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }

    }

    public class MovieDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }
    }
}