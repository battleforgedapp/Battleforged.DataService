using Battleforged.DataService.Domain.Enums;
using Newtonsoft.Json;

namespace Battleforged.DataService.Domain.Models;

/// <summary>
/// Models used when converting json for the abilities into objects to publish.
/// </summary>
public record AbilityJsonModel {
    
    [JsonProperty("id")]
    public Guid Id { get; init; }

    [JsonProperty("version")] 
    public long Version { get; init; } = 1;
    
    [JsonProperty("type")]
    public AbilityTypes Type { get; init; }

    [JsonProperty("name")]
    public string Name { get; init; } = string.Empty;

    [JsonProperty("text")]
    public string Text { get; init; } = string.Empty;
    
    [JsonProperty("created_date")]
    public DateTime CreatedDate { get; init; } = DateTime.UtcNow;
    
    [JsonProperty("deleted_date")]
    public DateTime? DeletedDate { get; init; }
}