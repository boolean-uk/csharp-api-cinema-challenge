//Brought to you by ChatGPT
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data;

public static class MovieSeed
{
  public static List<Movie> Get() =>
  [
    new Movie { Id = 1,  Title = "The Shawshank Redemption", Description = "A banker forms an unlikely friendship in prison while quietly plotting freedom.", RuntimeMins = 142, Rating = 9.3 },
    new Movie { Id = 2,  Title = "The Godfather", Description = "A powerful crime family faces shifting loyalties as a reluctant son takes the reins.", RuntimeMins = 175, Rating = 9.2 },
    new Movie { Id = 3,  Title = "The Dark Knight", Description = "Batman confronts a chaotic new foe whose plans push Gotham and its hero to the brink.", RuntimeMins = 152, Rating = 9.0 },
    new Movie { Id = 4,  Title = "Pulp Fiction", Description = "Intertwined tales of hitmen, a boxer, and a briefcase collide in offbeat fashion.", RuntimeMins = 154, Rating = 8.9 },
    new Movie { Id = 5,  Title = "Inception", Description = "A thief who steals secrets through dreams attempts one last, impossible heist.", RuntimeMins = 148, Rating = 8.8 },
    new Movie { Id = 6,  Title = "The Matrix", Description = "A hacker discovers a hidden reality and fights to free humanity from control.", RuntimeMins = 136, Rating = 8.7 },
    new Movie { Id = 7,  Title = "Parasite", Description = "Two families from different worlds become entangled in a sharp social thriller.", RuntimeMins = 132, Rating = 8.5 },
    new Movie { Id = 8,  Title = "Spirited Away", Description = "A girl navigates a spirit world to rescue her parents and find her courage.", RuntimeMins = 125, Rating = 8.6 },
    new Movie { Id = 9,  Title = "Gladiator", Description = "A betrayed general rises as a gladiator seeking justice against a corrupt emperor.", RuntimeMins = 155, Rating = 8.5 },
    new Movie { Id = 10, Title = "Interstellar", Description = "Explorers venture through a wormhole to secure a future for humanity.", RuntimeMins = 169, Rating = 8.6 },
    new Movie { Id = 11, Title = "The Lord of the Rings: The Fellowship of the Ring", Description = "A humble hero leads allies on a perilous quest to destroy a corrupting ring.", RuntimeMins = 178, Rating = 8.8 },
    new Movie { Id = 12, Title = "The Silence of the Lambs", Description = "An FBI trainee seeks a killer’s profile with help from an imprisoned genius.", RuntimeMins = 118, Rating = 8.6 },
    new Movie { Id = 13, Title = "Forrest Gump", Description = "A kind-hearted man unwittingly drifts through historic moments while chasing love.", RuntimeMins = 142, Rating = 8.8 },
    new Movie { Id = 14, Title = "Fight Club", Description = "An insomniac’s underground club spirals into a manifesto against modern life.", RuntimeMins = 139, Rating = 8.8 },
    new Movie { Id = 15, Title = "The Social Network", Description = "Friendships fracture as the creation of a global platform triggers legal battles.", RuntimeMins = 120, Rating = 7.8 },
    new Movie { Id = 16, Title = "Whiplash", Description = "An ambitious drummer faces a ruthless mentor in a battle of will and rhythm.", RuntimeMins = 107, Rating = 8.5 },
    new Movie { Id = 17, Title = "Mad Max: Fury Road", Description = "A high-octane desert chase pits rebels against a tyrant’s armored war party.", RuntimeMins = 120, Rating = 8.1 },
    new Movie { Id = 18, Title = "La La Land", Description = "An actress and a jazz pianist chase dreams and reckon with the cost of ambition.", RuntimeMins = 128, Rating = 8.0 },
    new Movie { Id = 19, Title = "The Grand Budapest Hotel", Description = "A fastidious concierge and his protégé dash through a caper over a priceless painting.", RuntimeMins = 100, Rating = 8.1 },
    new Movie { Id = 20, Title = "Get Out", Description = "A weekend visit unravels into a sharp, unsettling examination of control and identity.", RuntimeMins = 104, Rating = 7.8 }
  ];
}
