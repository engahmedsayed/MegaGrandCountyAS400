﻿using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemBasicInfoViewModel
    {
        [Display(Name = "Jurisdiction")]
        public string JurisdictionCode { get; set; }

        public string JurisidictionShortDepartmentName { get; set; }

        [Display(Name = "Application Yr/#")]
        public decimal ApplicationYear { get; set; }

        public decimal ApplicationNumber { get; set; }

        [Display(Name = "Department")]
        public string DepartmentCode { get; set; }

        public string DepartmentShortDepartmentName { get; set; }

        [Display(Name = "Addendum #")]
        public int AddendumNumber { get; set; }

        public string PermitStatus { get; set; }

        // computed properties
        [Display(Name = "Application(Year-Number)")]
        public string ApplicationYearDisplay => $"{ApplicationYear} - {ApplicationNumber}";

        [Display(Name = "Jurisdiction")]
        public string JurisdictionDisplay => $"{JurisdictionCode} - {JurisidictionShortDepartmentName}";

        [Display(Name = "Department")]
        public string DepartmentDisplay => $"{DepartmentCode} - {DepartmentShortDepartmentName}";

        [Display(Name = "Permit Status")]
        public string PermitStatusDisplay
        {
            get
            {
                switch (PermitStatus)
                {
                    case "A": return "Applica";
                    case "D": return "VoidApp";
                    case "E": return "ExpApp";
                    case "W": return "Working";
                    case "V": return "VoidPer";
                    case "U": return "ExpPer";
                    case "F": return "Final";
                    case "C": return "Closed";
                    default: return "";
                }
            }
        }
    }
}