﻿namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class FundOwnershipHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Fund Ownership data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var fundOwnership = JsonSerializer.Deserialize<FundOwnershipData>(jsonData);

        return fundOwnership != null ? (IEnumerable<T>)fundOwnership.QuoteSummary.Results.Select(x => x.FundOwnership).First().OwnershipList : Enumerable.Empty<T>();
    }
}
