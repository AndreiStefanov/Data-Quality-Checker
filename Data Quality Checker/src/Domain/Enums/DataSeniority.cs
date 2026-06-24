//<Summary>
// Represents if a data entry is over a certain age treshold imposed by the user
//</Summary>

namespace Data_Quality_Checker.Domain.Enums
{
    public enum Seniority
    {
        Unknown, // Implicit value, data check has not been performed yet.
        Recent, // Data entry is recent.
        Old // Data entry is old and possibly needs attention.
    }
}
