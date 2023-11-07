using System.ComponentModel;

namespace AspNetExample.Domain.Enum
{
    public enum Gender
    {
        [Description("Мужской пол")]
        Male = 0,

        [Description("Женский пол")]
        Famale = 1
    }
}
