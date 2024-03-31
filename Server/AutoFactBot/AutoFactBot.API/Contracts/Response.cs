namespace AutoFactBot.API.Contracts
{
    public record Response(
        Guid Id,
        string Title,
        string CarModel,
        string Vin,
        string EngineNumber,
        string Mileage,
        string Owner,
        string CountOwners,
        string Year,
        string GearBox,
        string Color,
        string CountKeys,
        string Interior);
}
