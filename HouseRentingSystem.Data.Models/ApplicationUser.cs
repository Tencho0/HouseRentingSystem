﻿namespace HouseRentingSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.RentedHouses = new HashSet<House>();
        }

        public virtual ICollection<House> RentedHouses { get; set; }  
    }
}
