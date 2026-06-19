// <summary>
// Severity levels for data quality & missing data checks.
// </summary>

// <remarks>
// Users should be able to configure their own severity levels for data quality checks, for example, a client may consider that the "Address" fields
// is critical while another may not
// </remarks>
public class Severity
{
    public enum SeverityEnum
    {
        Unknown, // Implicit value, data quality check is not applicable or has not been performed yet.
        Low, // Data quality check has been performed and the data is missing/incomplete but not critical.
        Warning, // Data quality check has been performed and the data is missing/incomplete and is important but not critical.
        Critical // Data quality check has been performed and the data that is missing/incomplete is critical and must be adressed immediately.
    }   
}
