﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingMainModuleViewModel
    {
        public DateTime? ApplicationDate { get;  set; }
        public decimal? ApplicationNumber { get;   set; }
        public decimal? AddendumNumber { get;   set; }
        public string PermitCode { get;   set; }
        public string PermitStatus { get;   set; }
        public decimal? ApplicationYear { get;   set; }
        public decimal? PermitNumber { get;   set; }
        public string ApplicationName { get;   set; }
        public string BuildingApprovalRequired { get;   set; }
        public string BuildingApprovalDate { get;   set; }

        public string FireMarchalRequired { get;   set; }
        public string FireMarshalDate { get;   set; }

        public string PlanningApprovalRequired { get;   set; }
        public string PlanningApprovalDate { get;   set; }

        public string HealthApprovalRequired { get;   set; }
        public string HealthApprovalDate { get;   set; }

        public string AssessorApprovalRequired { get;   set; }
        public string AssessorApprovalDate { get;   set; }

        public string PublicWorkApprovalRequired { get;   set; }
        public string PublicWorkApprovalDate { get;   set; }

        public string CityJurisdictionApprovalRequired { get;   set; }
        public string CityJurisdictionApprovalDate { get;   set; }
        public string CityUtilityApprovalRequired { get;   set; }
        public string CityUtilityApprovalDate { get;   set; }
    }
}