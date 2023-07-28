using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Services.Data
{
    using System.Threading.Tasks;
    using HouseRentingSystem.Data;
    using HouseRentingSystem.Services.Data.Interfaces;

    public class AgentService : IAgentService
    {
        private readonly HouseRentingDbContext dbContext;

        public AgentService(HouseRentingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> AgentExistsByUserIdAsync(string userId)
        {
            bool result = await dbContext.Agents
                .AnyAsync(a => a.UserId.ToString() == userId);

            return result;
        }
    }
}
