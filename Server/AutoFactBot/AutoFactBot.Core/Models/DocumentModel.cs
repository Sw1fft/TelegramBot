namespace AutoFactBot.Core.Models
{
    public class DocumentModel
    {
        public const int MAX_TITLE_LENGTH = 250;

        private DocumentModel(
            Guid id,
            string title,
            string carModel,
            string vin,
            string engineNumber,
            string mileage,
            string owner,
            string countOwners,
            string year,
            string gearBox,
            string color,
            string countKeys,
            string interior)
        {
            Id = id;
            Title = title;
            CarModel = carModel;
            Vin = vin;
            EngineNumber = engineNumber;
            Mileage = mileage;
            Owner = owner;
            CountOwners = countOwners;
            Year = year;
            GearBox = gearBox;
            Color = color;
            CountKeys = countKeys;
            Interior = interior;
        }

        public Guid Id { get; }
        public string Title { get; } = string.Empty;
        public string CarModel { get; } = string.Empty;
        public string Vin { get; } = string.Empty;
        public string EngineNumber { get; } = string.Empty;
        public string Mileage { get; } = string.Empty;
        public string Owner { get; } = string.Empty;
        public string CountOwners { get; } = string.Empty;
        public string Year { get; } = string.Empty;
        public string GearBox { get; } = string.Empty;
        public string Color { get; } = string.Empty;
        public string CountKeys { get; } = string.Empty;
        public string Interior { get; } = string.Empty;

        public static (DocumentModel, string Error) Create(
            Guid id, 
            string title,
            string carModel,
            string vin,
            string engineNumber,
            string mileage,
            string owner,
            string countOwners,
            string year,
            string gearBox,
            string color,
            string countKeys,
            string interior)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
                error = "Title can not be empty or longer then 250 symbols";

            var document = new DocumentModel(
                id, 
                title, 
                carModel, 
                vin, 
                engineNumber, 
                mileage, 
                owner, 
                countOwners, 
                year, 
                gearBox, 
                color, 
                countKeys, 
                interior);

            return (document, error);
        }
    }
}
