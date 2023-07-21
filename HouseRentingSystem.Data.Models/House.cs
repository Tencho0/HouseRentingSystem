﻿using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using static Common.EntityValidationConstants.House;

    public class House
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        public decimal PricePerMonth { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public Guid AgentId { get; set; }

        public virtual Agent Agent { get; set; } = null!;

        public Guid? RenterId { get; set; }

        public virtual ApplicationUser? Renter { get; set; }
    }
}
