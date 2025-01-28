using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.DTO.Request
{
    public class Delete_Movie : IDTO_Request_delete<Delete_Movie, Movie>
    {
        public static async Task<Movie?> delete(IRepository<Movie> repo, params object[] id)
        {
            var movie = await repo.DeleteEntry(x => x.Where(x => x.Id == (int)id[0]));
            if (movie == null) throw new Exception("Not found");
            return movie;
        }
    }
}
