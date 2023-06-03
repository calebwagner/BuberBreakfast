namespace BuberBreakfast.Contracts.BuberBreakfast;

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModified,
    List<string> Savory,
    List<string> Sweet);