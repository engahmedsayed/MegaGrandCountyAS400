﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.GeneralLedgerVM
{
    public class GeneralLedgerDetailsViewModel
    {
        public string FirstCurrentExpense { get; set; }

        public string SecondCurrentExpense { get; set; }

        public decimal? Month { get; set; }

        public decimal? Year { get; set; }

        public decimal? Budget { get; set; }

        public decimal? PendingEncumbrance { get; set; }

        public decimal? Encumbrance { get; set; }

        public decimal? Action { get; set; }
    }
}
