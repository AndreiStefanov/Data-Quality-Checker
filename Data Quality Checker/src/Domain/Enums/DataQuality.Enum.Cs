//<summary>
// Data quality field
//</summary>

//<remarks>
// Can be used for creating pie charts or evaluating the data quality.
// The actual requierments for each field should be definable by the user
//</remarks>>

public class DataQuality
{
    public enum DataQualityEnum
    {
        Unknown, // Implicit value, data check has not been performed yet
        Low, // Data entry contains little to no data and is incorrect
        Medium, // Data entry contains some data and is correct
        High, // Data entry contains most data and is correct
        Complete // Data entry contains all available data and is correct
    }
}
