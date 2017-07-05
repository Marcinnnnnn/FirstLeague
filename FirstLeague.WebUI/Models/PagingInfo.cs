using System;

namespace FirstLeague.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalClubs { get; set; }
        public int ClubsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalClubs / ClubsPerPage); }
        }
    }
}