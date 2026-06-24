// Used for the system entity ValidationRunIdentifier
namespace Data_Quality_Checker.Domain.Enums
{
    public enum ValidationRunStatus
    {
        Running, // Validation is running
        Completed, // Validation is completed
        Failed // Validation run has failed for whatever reason
    }
}