using System.Runtime.Serialization;

namespace ClashOfClans
{
    public enum WarFrequency
    {
        [EnumMember(Value = "always")]
        Always,
        [EnumMember(Value = "moreThanOncePerWeek")]
        MoreThanOncePerWeek,
        [EnumMember(Value = "oncePerWeek")]
        OncePerWeek,
        [EnumMember(Value = "lessThanOncePerWeek")]
        LessThanOncePerWeek,
        [EnumMember(Value = "never")]
        Never,
        [EnumMember(Value = "unknown")]
        Unknown
    }
}
