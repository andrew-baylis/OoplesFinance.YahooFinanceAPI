﻿namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class InsightsHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Insights data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var insights = JsonSerializer.Deserialize<InsightsData>(jsonData);

        return insights != null ? (IEnumerable<T>)insights.Finance.Result : Enumerable.Empty<T>();
    }
}