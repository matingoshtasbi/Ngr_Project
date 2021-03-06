using SemnanFlix.Accessors.Identity;
using SemnanFlix.Accessors.Models.DTO.Base;
using System;

namespace SemnanFlix.Accessors.Models.DTO
{
    public class UserMovieDTO : EntityDTO
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int MovieId { get; set; }

        public MovieDTO Movie { get; set; }

        public DateTime? RentEndDate { get; set; }

        public DateTime? PurchaseDate { get; set; }
    }
}
