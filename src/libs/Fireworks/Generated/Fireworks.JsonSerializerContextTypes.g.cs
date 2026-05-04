
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Fireworks
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.AudioTranscriptionRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.AudioModel? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.VadModel? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.AlignmentModel? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.ResponseFormat? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Fireworks.TimestampGranularity>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.TimestampGranularity? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.PreprocessingMode? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.AudioTranslationRequest? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.AudioResponse? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.AudioResponseTask? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Fireworks.Word>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.Word? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Fireworks.Segment>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.Segment? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.ErrorResponse? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.OneOf<string, global::Fireworks.ErrorDetail>? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Fireworks.ErrorDetail? Type22 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Fireworks.TimestampGranularity>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Fireworks.Word>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Fireworks.Segment>? ListType2 { get; set; }
    }
}