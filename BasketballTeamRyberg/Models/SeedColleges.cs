using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRyberg.Models
{
    internal class SeedColleges : IEntityTypeConfiguration<College>
    {
        public void Configure(EntityTypeBuilder<College> entity)
        {
            entity.HasData(
                new College { CollegeId = "ISU", CollegeName = "Iowa State University" },
                new College { CollegeId = "IU", CollegeName = "University of Iowa" },
                new College { CollegeId = "UM", CollegeName = "University of Minnesota" },
                new College { CollegeId = "DT", CollegeName = "Dartmouth" },
                new College { CollegeId = "CN", CollegeName = "Cornell" },
                new College { CollegeId = "ASU", CollegeName = "Arizona State University"},
                new College { CollegeId = "NIU", CollegeName = "Northen Illinois University"},
                new College { CollegeId = "DMACC", CollegeName = "Des Moines Area Community College"}
                );
        }
    }
}
