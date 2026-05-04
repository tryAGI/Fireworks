
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Fireworks
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Fireworks.JsonConverters.AudioModelJsonConverter),

            typeof(global::Fireworks.JsonConverters.AudioModelNullableJsonConverter),

            typeof(global::Fireworks.JsonConverters.VadModelJsonConverter),

            typeof(global::Fireworks.JsonConverters.VadModelNullableJsonConverter),

            typeof(global::Fireworks.JsonConverters.AlignmentModelJsonConverter),

            typeof(global::Fireworks.JsonConverters.AlignmentModelNullableJsonConverter),

            typeof(global::Fireworks.JsonConverters.ResponseFormatJsonConverter),

            typeof(global::Fireworks.JsonConverters.ResponseFormatNullableJsonConverter),

            typeof(global::Fireworks.JsonConverters.TimestampGranularityJsonConverter),

            typeof(global::Fireworks.JsonConverters.TimestampGranularityNullableJsonConverter),

            typeof(global::Fireworks.JsonConverters.PreprocessingModeJsonConverter),

            typeof(global::Fireworks.JsonConverters.PreprocessingModeNullableJsonConverter),

            typeof(global::Fireworks.JsonConverters.AudioResponseTaskJsonConverter),

            typeof(global::Fireworks.JsonConverters.AudioResponseTaskNullableJsonConverter),

            typeof(global::Fireworks.JsonConverters.OneOfJsonConverter<string, global::Fireworks.ErrorDetail>),

            typeof(global::Fireworks.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.AudioModel), TypeInfoPropertyName = "AudioModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.VadModel), TypeInfoPropertyName = "VadModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.AlignmentModel), TypeInfoPropertyName = "AlignmentModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fireworks.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.TimestampGranularity), TypeInfoPropertyName = "TimestampGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.PreprocessingMode), TypeInfoPropertyName = "PreprocessingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.AudioTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.AudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.AudioResponseTask), TypeInfoPropertyName = "AudioResponseTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fireworks.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.Word))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fireworks.Segment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.Segment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.OneOf<string, global::Fireworks.ErrorDetail>), TypeInfoPropertyName = "OneOfStringErrorDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fireworks.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fireworks.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fireworks.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fireworks.Segment>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}