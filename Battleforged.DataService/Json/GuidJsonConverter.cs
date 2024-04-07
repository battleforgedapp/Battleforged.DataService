using Newtonsoft.Json;

namespace Battleforged.DataService.Json;

public sealed class GuidJsonConverter : JsonConverter<Guid> {
        
    public override Guid ReadJson(JsonReader reader, Type objectType, Guid existingValue, bool hasExistingValue, JsonSerializer serializer) {
        if (reader.Value != null && Guid.TryParse(reader.Value.ToString(), out var parsedValue)) {
            return parsedValue;
        }
        return Guid.Empty;
    }
            
    public override void WriteJson(JsonWriter writer, Guid value, JsonSerializer serializer) {
        serializer.Serialize(writer, value.ToString("N"));
    }
}

public sealed class NullableGuidJsonConverter : JsonConverter<Guid?> {
        
    public override Guid? ReadJson(JsonReader reader, Type objectType, Guid? existingValue, bool hasExistingValue, JsonSerializer serializer) {
        if (reader.Value != null && Guid.TryParse(reader.Value.ToString(), out var parsedValue)) {
            return parsedValue;
        }
        return null;
    }
            
    public override void WriteJson(JsonWriter writer, Guid? value, JsonSerializer serializer) {
        serializer.Serialize(writer, value?.ToString("N"));
    }
}