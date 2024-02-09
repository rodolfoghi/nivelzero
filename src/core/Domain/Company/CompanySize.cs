namespace Domain.Company;

public enum CompanySize
{
    /// <summary>
    /// Headcount of 1-9 
    /// </summary>
    Micro,

    /// <summary>
    /// Headcount of 10-49
    /// </summary>
    Small,

    /// <summary>
    /// Headcount of 50-99
    /// </summary>
    MediumLow,

    /// <summary>
    /// Headcount of 100-249
    /// </summary>
    MediumHigh,

    /// <summary>
    /// Headcount of 250-499
    /// </summary>
    LargeLow,

    /// <summary>
    /// Headcount of 500 or more
    /// </summary>
    LargeHigh
}