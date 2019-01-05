﻿using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Treasurer.Repository
{
    public interface ITaxReceiptRepository
    {
        IEnumerable<AffadavitReceipt> GetAllAffadavitReceipts(
            decimal minReceiptNumber, decimal? maxReceiptNumber, decimal minAffidavitNumber, decimal? maxAffidavitNumber, out int resultCount, int pageNumber = 1,
            int pageSize = 50);

        IEnumerable<TaxPaymentReceipt> GetAllTaxPaymentReceipts(
            decimal parcelNumber, decimal parcelExtension, int taxyear, out int resultCount, int pageNumber = 1, int pageSize = 50);

        IEnumerable<GeneralReceipt> GetAllGeneralReceipts(decimal transactionNumber, out int resultCount, int pageNumber = 1, int pageSize = 50);

        AffadavitReceiptDetails AffadavitReceiptDetails(int affadavitReceiptId);

        TaxReceiptDetails Details(decimal transactionNumber);
    }
}