using EnumComboBox;

namespace SilverCityOS
{
    public enum Status
    {
        [StringValue("-- Select --")]
        None = 0,

        Active = 1,

        Inactive = 2,

        [StringValue("Pending Authorization")]
        PendingAuthorization = 3,

        [StringValue]
        Empty = 4,
    }
}
