﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.LegalDocument
{
    public class RealPropertyLegalDocumentViewModel
    {
        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        public string TaxPayerCode { get; set; }
        public string TaxPayerName { get; set; }
        public string TitleOwnerCode { get; set; }
        public string TitleOwnerName { get; set; }
        public string ContractHolderCode { get; set; }
        public string ContractHolderName { get; set; }

        [Display(Name = "Loan Number")]
        public string LoanNumber { get; set; }

        [Display(Name = "Building AV")]
        [DisplayFormat(DataFormatString = "{0:##,#}")]
        public decimal BuildingValue { get; set; }

        public decimal LandUseCode { get; set; }
        public decimal TaxCodeArea { get; set; }
        public string TaxCodeDesc { get; set; }
        public string UseCodeShortDesc { get; set; }

        [Display(Name = "Land AV")]
        [DisplayFormat(DataFormatString = "{0:##,#}")]
        public decimal AssessedValue { get; set; }

        [Display(Name = "Tax Year")]
        public int TaxYear { get; set; }

        public decimal RPsalesAmount { get; set; }
        public decimal PPsalesAmount { get; set; }

        public IEnumerable<LegalDocumentViewModel> LegalDocuments { get; set; }

        [Display(Name = "Tax Payer(code - name)")]
        public string TaxPayerDisplay => $"{TaxPayerCode} - {TaxPayerName}";

        [Display(Name = "Title Owner(code - name)")]
        public string TitleOwnerDisplay => $"{TitleOwnerCode} - {TitleOwnerName}";

        [Display(Name = "Contract Holder(code - name)")]
        public string ContractHolderDisplay => (string.IsNullOrWhiteSpace(ContractHolderCode)) ? "" : $"{ContractHolderCode} - {ContractHolderName}";

        [Display(Name = "Tax Code(area - desciption)")]
        public string TaxCodeDisplay => $"{TaxCodeArea} - {TaxCodeDesc}";

        [Display(Name = "Land Use(code - desciption)")]
        public string LandUseDisplay => $"{LandUseCode} - {UseCodeShortDesc}";
    }

    public class LegalDocumentViewModel
    {
        public int Id { get; set; }
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? LegalInstrumentDate { get; set; }

        [Display(Name = "Inst")]
        public string LegalDocumentType { get; set; }

        [Display(Name = "Previous Owner")]
        public string PreviousOwnerSeller { get; set; }

        public int Volume { get; set; }
        public int Page { get; set; }
        public decimal AffidavitNumber { get; set; }
        public string AffidavitNumberExtension { get; set; }

        [Display(Name = "Exc #")]
        public string AffidavitDisplay => $"{AffidavitNumberExtension} - {AffidavitNumber}";
    }
}