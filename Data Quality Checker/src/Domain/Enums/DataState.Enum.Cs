// <summary>
// Data states for data quality checks.
// </summary>

public class DataState
{
    public enum DataStateEnum
    {
        Unknown, // Implicit value, data state is unknown or has not been determined yet.
        Valid, // Data is valid and meets all quality criteria.
        Invalid, // Data is invalid and does not meet quality criteria.
        Missing, // Data is missing.
        Incorrect // Data is incorrect and does not match expected values.
    }
}
