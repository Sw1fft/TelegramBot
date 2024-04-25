using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AutoFactBot.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CarModel = table.Column<string>(type: "text", nullable: false),
                    VinNumber = table.Column<string>(type: "text", nullable: false),
                    EngineNumber = table.Column<string>(type: "text", nullable: false),
                    Mileage = table.Column<string>(type: "text", nullable: false),
                    Owner = table.Column<string>(type: "text", nullable: false),
                    CountOwners = table.Column<string>(type: "text", nullable: false),
                    Year = table.Column<string>(type: "text", nullable: false),
                    GearBox = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    CountKeys = table.Column<string>(type: "text", nullable: false),
                    Interior = table.Column<string>(type: "text", nullable: false),
                    InterriorComment = table.Column<string>(type: "text", nullable: false),
                    CentrRightStand = table.Column<string>(type: "text", nullable: false),
                    CentrRightStandThickness = table.Column<string>(type: "text", nullable: false),
                    CentrLeftStand = table.Column<string>(type: "text", nullable: false),
                    CentrLeftStandThickness = table.Column<string>(type: "text", nullable: false),
                    ThresholdRight = table.Column<string>(type: "text", nullable: false),
                    ThresholdRightThickness = table.Column<string>(type: "text", nullable: false),
                    ThresholdLeft = table.Column<string>(type: "text", nullable: false),
                    ThresholdLeftThickness = table.Column<string>(type: "text", nullable: false),
                    BodyComment = table.Column<string>(type: "text", nullable: false),
                    Glasses = table.Column<string>(type: "text", nullable: false),
                    Headlights = table.Column<string>(type: "text", nullable: false),
                    Mirrors = table.Column<string>(type: "text", nullable: false),
                    GlassComment = table.Column<string>(type: "text", nullable: false),
                    EngineOil = table.Column<string>(type: "text", nullable: false),
                    GearBoxOil = table.Column<string>(type: "text", nullable: false),
                    Antifreeze = table.Column<string>(type: "text", nullable: false),
                    BrakeFluid = table.Column<string>(type: "text", nullable: false),
                    SteeringFluid = table.Column<string>(type: "text", nullable: false),
                    EngineSpaceComment = table.Column<string>(type: "text", nullable: false),
                    YearTire = table.Column<string>(type: "text", nullable: false),
                    RemainingTire = table.Column<string>(type: "text", nullable: false),
                    SecondComplect = table.Column<string>(type: "text", nullable: false),
                    WheelComplectComment = table.Column<string>(type: "text", nullable: false),
                    WheelBearings = table.Column<string>(type: "text", nullable: false),
                    ShockAbsorbers = table.Column<string>(type: "text", nullable: false),
                    SuspensionArms = table.Column<string>(type: "text", nullable: false),
                    Stabilizer = table.Column<string>(type: "text", nullable: false),
                    SteeringTips = table.Column<string>(type: "text", nullable: false),
                    SteeringRack = table.Column<string>(type: "text", nullable: false),
                    EngineSump = table.Column<string>(type: "text", nullable: false),
                    GearBoxSound = table.Column<string>(type: "text", nullable: false),
                    OtherElements = table.Column<string>(type: "text", nullable: false),
                    EngineError = table.Column<string>(type: "text", nullable: false),
                    GearBoxError = table.Column<string>(type: "text", nullable: false),
                    AbsError = table.Column<string>(type: "text", nullable: false),
                    AirbagError = table.Column<string>(type: "text", nullable: false),
                    AddControlUnits = table.Column<string>(type: "text", nullable: false),
                    MileageCompliance = table.Column<string>(type: "text", nullable: false),
                    ComputerDiagnosticComment = table.Column<string>(type: "text", nullable: false),
                    GearBoxShifts = table.Column<string>(type: "text", nullable: false),
                    GearBoxShiftsAcceleration = table.Column<string>(type: "text", nullable: false),
                    GearBoxShiftsBreaking = table.Column<string>(type: "text", nullable: false),
                    GearBoxShiftsCoasting = table.Column<string>(type: "text", nullable: false),
                    GearBoxComment = table.Column<string>(type: "text", nullable: false),
                    VibrationsDriving = table.Column<string>(type: "text", nullable: false),
                    VibrationsBreaking = table.Column<string>(type: "text", nullable: false),
                    SoundsDriving = table.Column<string>(type: "text", nullable: false),
                    SoundsDrivingBumps = table.Column<string>(type: "text", nullable: false),
                    SuspentionComment = table.Column<string>(type: "text", nullable: false),
                    BrakePadWear = table.Column<string>(type: "text", nullable: false),
                    BrakeDiskWear = table.Column<string>(type: "text", nullable: false),
                    BrakeSystemComment = table.Column<string>(type: "text", nullable: false),
                    Folding = table.Column<string>(type: "text", nullable: false),
                    Adjustment = table.Column<string>(type: "text", nullable: false),
                    Heating = table.Column<string>(type: "text", nullable: false),
                    SeatHeating = table.Column<string>(type: "text", nullable: false),
                    RearWindowHeating = table.Column<string>(type: "text", nullable: false),
                    WindshieldHeating = table.Column<string>(type: "text", nullable: false),
                    ControlsOperationComment = table.Column<string>(type: "text", nullable: false),
                    CheckingModes = table.Column<string>(type: "text", nullable: false),
                    PanelIndication = table.Column<string>(type: "text", nullable: false),
                    AwdComment = table.Column<string>(type: "text", nullable: false),
                    ColdStartEngine = table.Column<string>(type: "text", nullable: false),
                    DifficultStartEngine = table.Column<string>(type: "text", nullable: false),
                    OtherSounds = table.Column<string>(type: "text", nullable: false),
                    StrongVibration = table.Column<string>(type: "text", nullable: false),
                    StartEngineComment = table.Column<string>(type: "text", nullable: false),
                    CompressorOperation = table.Column<string>(type: "text", nullable: false),
                    FreonAvailability = table.Column<string>(type: "text", nullable: false),
                    DriveBeltCondition = table.Column<string>(type: "text", nullable: false),
                    ConditionerOperationComment = table.Column<string>(type: "text", nullable: false),
                    Restrictions = table.Column<string>(type: "text", nullable: false),
                    SubjectСollateral = table.Column<string>(type: "text", nullable: false),
                    Fines = table.Column<string>(type: "text", nullable: false),
                    AccidentArticipation = table.Column<string>(type: "text", nullable: false),
                    CarWanted = table.Column<string>(type: "text", nullable: false),
                    VinNumberMatch = table.Column<string>(type: "text", nullable: false),
                    LegalCheckComment = table.Column<string>(type: "text", nullable: false),
                    TestDrive = table.Column<string>(type: "text", nullable: false),
                    TimingDrive = table.Column<string>(type: "text", nullable: false),
                    EngineOilAndFilter = table.Column<string>(type: "text", nullable: false),
                    CheckWheelsAngle = table.Column<string>(type: "text", nullable: false),
                    RecommendationsComment = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserId",
                table: "Documents",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
