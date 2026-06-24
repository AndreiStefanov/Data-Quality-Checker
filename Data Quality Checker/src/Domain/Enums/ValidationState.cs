//<summary>
// Validation state of data during checking
//</summary>

namespace Data_Quality_Checker.Domain.Enums
{
    public enum ValidationState
    {
        Unknown, // Implicit value, determines if the specific data entry has been checked or not
        Validated, // Data entry has been checked
    }
}
