using System;
namespace RandomQuotes.Models
{
	public class Quote
	{
        // Text, to represent the content of the quote, and Author.
        public string Text { get; set; }
        public string Author { get; set; }

        public Quote(string text, string author)
        {
            Text = text;
            Author = author;
        }
    }
}

