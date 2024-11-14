// See https://aka.ms/new-console-template for more information
using MovieDatabase;

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
var scifiMovies = availableMovies.Where(x => x.category == "Sci-Fi").ToList();

Console.WriteLine("Welcome to the Movie list application!");
Console.WriteLine("There are 15 movies in this list");
Console.WriteLine("You can choose from categories: Horror, Drama, Animated or Sci-Fi");
Console.WriteLine("What category are you interested in?");

string userInput = Console.ReadLine().ToLower();

switch(userInput)
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

Console.ReadLine();




