using System;
using System.ComponentModel.DataAnnotations;

namespace AlbumApp.Entities
{
	public class Album
	{
		public int AlbumId { get; set; }

        [Required(ErrorMessage = " Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = " Artist is required")]
        public string Artist { get; set; }

        [Required(ErrorMessage = " Rating is required")]
        [Range(0.0, 10.0, ErrorMessage = " Rating should be in range of 0.0 to 10.0")]
        public double Rating { get; set; }

		public string Song { get; set; }

        public string? DisplayedText { get; }

    }
}

