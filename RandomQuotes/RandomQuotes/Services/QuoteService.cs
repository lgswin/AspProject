using RandomQuotes.Models;

namespace RandomQuotes.Services
{
    // add a class that implements that interface by maintaining a collection of Quote objects and is able to randomly select one from that collection
    public class QuoteService : IQuoteService
    {
        private readonly List<Quote> _quotes;

        public QuoteService()
        {
            _quotes = new List<Quote>
            {
                new Quote("The only way to do great work is to love what you do.","Steve Jobs"),
                new Quote("Be the change that you wish to see in the world.","Mahatma Gandhi"),
                new Quote("In three words I can sum up everything I've learned about life: it goes on.","Robert Frost"),
                new Quote("To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment.","Ralph Waldo Emerson"),
                new Quote("If you tell the truth, you don't have to remember anything.","Mark Twain"),
                new Quote("Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.","Albert Einstein"),
                new Quote("So many books, so little time.","Frank Zappa"),
                new Quote("A room without books is like a body without a soul.","Marcus Tullius Cicero"),
                new Quote("You only live once, but if you do it right, once is enough.","Mae West"),
                new Quote("Be who you are and say what you feel, because those who mind don't matter, and those who matter don't mind.","Bernard M. Baruch"),
                new Quote("You must be the change you wish to see in the world.","Mahatma Gandhi"),
                new Quote("Spread love everywhere you go. Let no one ever come to you without leaving happier.","Mother Teresa"),
                new Quote("The only thing we have to fear is fear itself.","Franklin D. Roosevelt"),
                new Quote("Darkness cannot drive out darkness: only light can do that.Hate cannot drive out hate: only love can do that.","Martin Luther King Jr."),
                new Quote("Do one thing every day that scares you.","Eleanor Roosevelt"),
                new Quote("Well done is better than well said.","Benjamin Franklin"),
                new Quote("The best and most beautiful things in the world cannot be seen or even touched -they must be felt with the heart.","Helen Keller"),
                new Quote("It is during our darkest moments that we must focus to see the light.","Aristotle"),
                new Quote("Do not go where the path may lead, go instead where there is no path and leave a trail.","Ralph Waldo Emerson"),
                new Quote("Be yourself; everyone else is already taken.","Oscar Wilde"),
            };
        }

        // Implementing the GetRandomQuote method should randomly select one of the quotes from your hard-coded collection
        public Quote GetRandomQuote()
        {
            Random _random = new Random();
            int index = _random.Next(_quotes.Count);
            return _quotes[index];
        }
    }
}

