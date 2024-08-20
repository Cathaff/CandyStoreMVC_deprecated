using CandyStore.DbContext;
using CandyStore.Interface;
using Microsoft.EntityFrameworkCore;

namespace CandyStore.Services
{
    public class CandyService : ICandyService
    {
        public readonly CandyStoreDbContext _dbContext;

        public await Task<ActionResult> GetAllCandies()
        {
            var candies = _dbContext.Candy.Include(x => x.Executors).ToListAsync();
            return _mapper
        }
    }
}
