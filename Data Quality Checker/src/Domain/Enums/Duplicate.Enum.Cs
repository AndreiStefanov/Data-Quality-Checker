//<Summary>
// Represents if a data entry has a duplicate or not.
//</Summary>

public class Duplicate
{
    public enum DuplicateEnum
    {
        Unknown, // Implicit value, data check has not been performed yet.
        Unique, // Data entry is unique.
        HasDuplicates // Data entry has duplicates.
    }
}
