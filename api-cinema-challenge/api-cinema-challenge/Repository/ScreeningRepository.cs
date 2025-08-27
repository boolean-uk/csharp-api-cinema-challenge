using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;


public class ScreeningRepository : IScreeningRepository
{
    private readonly CinemaContext _context;

    public ScreeningRepository(CinemaContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Screening>> GetAllAsync()
    {
        return await _context.Screenings
                             .Include(s => s.Movie)
                             .ToListAsync();
    }

    public async Task<Screening> CreateAsync(Screening screening)
    {
        _context.Screenings.Add(screening);
        await _context.SaveChangesAsync();
        return screening;
    }
}
