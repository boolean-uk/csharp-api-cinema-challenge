using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.DTO.Request
{
    public class Update_Movie : IDTO_Request_update<Update_Movie, Movies>
    {
        public string? Title {  get; set; }
        public string? Rating {  get; set; }
        public string? Description  {  get; set; }
        public int? RuntimeMins {  get; set; }

        public static async Task<Movies?> update(Update_Movie dto, IRepository<Movies> repo, params object[] id)
        {
            var movie =  await repo.GetEntry(x => x.Where(x => (int)id[0] == x.Id));
            if (movie == null) throw new Exception("Not found");

            return await repo.UpdateEntry(
                x => x.Where(x => (int)id[0] == x.Id),
                new Movies
                {
                    Id = movie.Id,

                    Title = dto.Title ?? movie.Title,
                    Rating  = dto.Rating ?? movie.Rating,
                    Description  = dto.Description ?? movie.Description,
                    RuntimeMins = dto.RuntimeMins ?? movie.RuntimeMins,
                    
                    CreatedAt = movie.CreatedAt

                });
        }
    }
}
