//<summary>
// Validation state of data during checking
//</summary>

public class ValidationState
{
    public enum ValidationStateEnum
    {
        Unknown, // Implicit value, determines if the specific data entry has been checked or not
        Validated, // Data entry has been checked
        Missing // Data entry is missing
    }
}
