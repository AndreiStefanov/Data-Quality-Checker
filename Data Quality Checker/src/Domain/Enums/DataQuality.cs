//<summary>
// Data quality field
//</summary>

//<remarks>
// Can be used for creating pie charts or evaluating the data quality.
// The actual requierments for each field should be definable by the user
//</remarks>>

namespace Data_Quality_Checker.Domain.Enums
{
    public enum DataQuality
    {
        Unknown, // Implicit value, data check has not been performed yet
        Low, // Data entry contains little to no data
        Medium, // Data entry contains some data
        High, // Data entry contains most data
        Complete // Data entry contains all available data
    }
}
