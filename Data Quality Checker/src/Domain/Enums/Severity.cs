// <summary>
// Severity levels for data quality & missing data checks.
// </summary>

// <remarks>
// Users should be able to configure their own severity levels for data quality checks, for example, a client may consider that the "Address" fields
// is critical while another may not
// </remarks>
namespace Data_Quality_Checker.Domain.Enums
{
    public enum Severity
    {
        Unknown,  // Not yet determined
        Low,      // Missing/incomplete but not critical, can be addressed later
        Medium,   // Important but not critical, should be addressed soon
        High,     // Critical data missing, must be addressed immediately
        Critical  // Blocks business operations, requires immediate action
    }   
}
