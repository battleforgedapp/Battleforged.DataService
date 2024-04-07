using Battleforged.DataService.Domain.Enums;

namespace Battleforged.DataService.Domain.Contracts;

public record AbilityStateContract {
    
    public long Version { get; init; }
    
    public Guid AbilityId { get; init; }
    
    public AbilityTypes Type { get; init; }

    public string Name { get; init; } = string.Empty;

    public string Text { get; init; } = string.Empty;
    
    public DateTime CreatedDate { get; init; }
    
    public DateTime? DeletedDate { get; init; }
}