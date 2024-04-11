namespace AutoFactBot.Data.Entities
{
    public class DocumentEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string CarModel { get; set; } = string.Empty;

        public string VinNumber { get; set; } = string.Empty;

        public string EngineNumber { get; set; } = string.Empty;

        public string Mileage { get; set; } = string.Empty;

        public string Owner { get; set; } = string.Empty;

        public string CountOwners { get; set; } = string.Empty;

        public string Year { get; set; } = string.Empty;

        public string GearBox { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public string CountKeys { get; set; } = string.Empty;

        public string Interior { get; set; } = string.Empty;

        public long UserId { get; set; }

        public UserEntity? User { get; set; }
    }
}
