using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using HouseRentingSystem.Data;
    using HouseRentingSystem.Services.Data.Interfaces;
    using HouseRentingSystem.Web.ViewModels.Home;

    public class HouseService : IHouseService
    {
        private readonly HouseRentingDbContext dbContext;

        public HouseService(HouseRentingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexViewModel>> LastThreeHousesAsync()
        {
            IEnumerable<IndexViewModel> lastThreeHouses = await dbContext.Houses
                .OrderByDescending(h => h.CreatedOn)
                .Take(3)
                .Select(h=> new IndexViewModel()
                {
                    Id = h.Id.ToString(),
                    Title = h.Title,
                    ImageUrl = h.ImageUrl
                })
                .ToArrayAsync();

            return lastThreeHouses;
        }
    }
}
