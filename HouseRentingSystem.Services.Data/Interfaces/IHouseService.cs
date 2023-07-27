namespace HouseRentingSystem.Services.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using HouseRentingSystem.Web.ViewModels.Home;

    public interface IHouseService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeHousesAsync();
    }
}
