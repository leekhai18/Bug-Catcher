﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BugCatcher.DAL.Models
{
    public partial class ApplicationUser : IdentityUser
    {

        #region Navigation Properties

        public ICollection<CompanyEnrollment> CompanyEnrollments { get; set; }

        #endregion
    }
}
