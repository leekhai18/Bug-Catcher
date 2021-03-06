﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BugCatcher.DAL.Query.Models.Filters
{
    /// <summary>
    /// Filter object used in fetching records in Report Table.
    /// </summary>
    public class ReportFetchingFilter
    {
        private Guid? requiredBuildId = null;
        public Guid? RequiredBuildId
        {
            get { return requiredBuildId; }
            set { requiredBuildId = value; }
        }
    }
}
