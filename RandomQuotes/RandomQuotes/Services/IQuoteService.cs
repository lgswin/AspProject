using RandomQuotes.Models;

namespace RandomQuotes.Services
{
    // add an interface with 1 method called GetRandomQuote
    public interface IQuoteService
    {
        public Quote GetRandomQuote();

    }
}
