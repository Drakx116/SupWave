using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SupWave.Models;

namespace SupWave.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the SupWaveUser class
    public class SupWaveUser : IdentityUser
    {
        [PersonalData]
        public List<Playlist> Playlists { get; set; }
    }
}
