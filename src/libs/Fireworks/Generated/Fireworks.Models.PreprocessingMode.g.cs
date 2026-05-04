
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// Audio preprocessing mode.
    /// </summary>
    public enum PreprocessingMode
    {
        /// <summary>
        /// 
        /// </summary>
        BassDynamic,
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        SoftDynamic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreprocessingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreprocessingMode value)
        {
            return value switch
            {
                PreprocessingMode.BassDynamic => "bass_dynamic",
                PreprocessingMode.Dynamic => "dynamic",
                PreprocessingMode.None => "none",
                PreprocessingMode.SoftDynamic => "soft_dynamic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreprocessingMode? ToEnum(string value)
        {
            return value switch
            {
                "bass_dynamic" => PreprocessingMode.BassDynamic,
                "dynamic" => PreprocessingMode.Dynamic,
                "none" => PreprocessingMode.None,
                "soft_dynamic" => PreprocessingMode.SoftDynamic,
                _ => null,
            };
        }
    }
}