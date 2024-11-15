// See https://aka.ms/new-console-template for more information
using MovieDatabase;

bool endProgram = false;
List<Movie> availableMovies = new List<Movie>()
{
    new Movie("Toy Story", "Animated"),
    new Movie("The Pursuit of Happyness", "Drama"),
    new Movie("Schindler's List", "Drama"),
    new Movie("IT", "Horror"),
    new Movie("Star Wars", "Sci-fi"),
    new Movie("Finding Nemo", "Animated"),
    new Movie("Get Out", "Horror"),
    new Movie("The Terminator", "Sci-fi"),
    new Movie("The Godfather", "Drama"),
    new Movie("The Conjuring", "Horror")
};

var horrorMovies = availableMovies.Where(x => x.category == "Horror").ToList();
var dramaMovies = availableMovies.Where(x => x.category == "Drama").ToList();
var animatedMovies = availableMovies.Where(x => x.category == "Animated").ToList();
var scifiMovies = availableMovies.Where(x => x.category == "Sci-fi").ToList();

bool IsValidMovieCategory(string category)
{
    if(category == "horror" || category == "animated" || category == "sci-fi" || category == "drama")
    {
        return true;
    }
    return false;
}

do
{
    Console.WriteLine("Welcome to the Movie list application!");
    Console.WriteLine("There are 10 movies in this list");
    Console.WriteLine("What category are you interested in?");
    Console.WriteLine("You can choose from categories: Horror, Drama, Animated or Sci-Fi");

    string userInput = Console.ReadLine().ToLower();

    bool vaildUserOption =  IsValidMovieCategory(userInput);

    while (String.IsNullOrWhiteSpace(userInput) || vaildUserOption == false)
    {
        Console.WriteLine("You've entered something invalid.");
        Console.WriteLine("What category are you interested in?");
        Console.WriteLine("You can choose from categories: Horror, Drama, Animated or Sci-Fi");
        userInput = Console.ReadLine().ToLower();
        vaildUserOption = IsValidMovieCategory(userInput);
    }

    switch (userInput)
    {
        case "horror":
            horrorMovies.ForEach(x => Console.WriteLine(x.title));
            break;
        case "drama":
            dramaMovies.ForEach(x => Console.WriteLine(x.title));
            break;
        case "animated":
            animatedMovies.ForEach(x => Console.WriteLine(x.title));
            break;
        case "sci-fi":
            scifiMovies.ForEach(x => Console.WriteLine(x.title));
            break;
    }
    Console.WriteLine("Continue? (Yes/No)");
    userInput = Console.ReadLine().ToLower();

    if(userInput != "yes")
    {
        endProgram = true;
    }

} while (endProgram == false);






