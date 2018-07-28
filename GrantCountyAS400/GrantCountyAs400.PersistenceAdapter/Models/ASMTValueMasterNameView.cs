﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class ASMTValueMasterNameView
    {
        public int Id { get; set; }
        public decimal? ParcelNumber { get; set; }
        public string TaxpayerCode { get; set; }
        public string TitleOwnerCode { get; set; }
        public string ContractHolder { get; set; }
        public string TaxpayerName { get; set; }
        public string TitleOwnerName { get; set; }
        public string ContractHolderName { get; set; }
    }
}
