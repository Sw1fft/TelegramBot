namespace AutoFactBot.Data.Entities
{
    public class DocumentEntity
    {
        public Guid Id { get; set; }

        #region Main

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
        public string InterriorComment { get; set; } = string.Empty;

        #endregion

        #region Body

        public string CentrRightStand { get; set; } = string.Empty;
        public string CentrRightStandThickness { get; set; } = string.Empty;
        public string CentrLeftStand { get; set; } = string.Empty;
        public string CentrLeftStandThickness { get; set; } = string.Empty;
        public string ThresholdRight { get; set; } = string.Empty;
        public string ThresholdRightThickness { get; set; } = string.Empty;
        public string ThresholdLeft { get; set; } = string.Empty;
        public string ThresholdLeftThickness { get; set; } = string.Empty;
        public string BodyComment { get; set; } = string.Empty;

        #endregion

        #region Glass

        public string Glasses { get; set; } = string.Empty;
        public string Headlights { get; set; } = string.Empty;
        public string Mirrors { get; set; } = string.Empty;
        public string GlassComment { get; set; } = string.Empty;

        #endregion

        #region EngineSpace

        public string EngineOil { get; set; } = string.Empty;
        public string GearBoxOil { get; set; } = string.Empty;
        public string Antifreeze { get; set; } = string.Empty;
        public string BrakeFluid { get; set; } = string.Empty;
        public string SteeringFluid { get; set; } = string.Empty;
        public string EngineSpaceComment { get; set; } = string.Empty;

        #endregion

        #region WheelCondition

        public string YearTire { get; set; } = string.Empty;
        public string RemainingTire { get; set; } = string.Empty;
        public string SecondComplect { get; set; } = string.Empty;
        public string WheelComplectComment { get; set; } = string.Empty;

        #endregion

        #region LiftInspection

        public string WheelBearings { get; set; } = string.Empty;
        public string ShockAbsorbers { get; set; } = string.Empty;
        public string SuspensionArms { get; set; } = string.Empty;
        public string Stabilizer { get; set; } = string.Empty;
        public string SteeringTips { get; set; } = string.Empty;
        public string SteeringRack { get; set; } = string.Empty;
        public string EngineSump { get; set; } = string.Empty;
        public string GearBoxSound { get; set; } = string.Empty;
        public string OtherElements { get; set; } = string.Empty;

        #endregion

        #region Diagnostics

        #region ComputerDiagnostic

        public string EngineError { get; set; } = string.Empty;
        public string GearBoxError { get; set; } = string.Empty;
        public string AbsError { get; set; } = string.Empty;
        public string AirbagError { get; set; } = string.Empty;
        public string AddControlUnits { get; set; } = string.Empty;
        public string MileageCompliance { get; set; } = string.Empty;
        public string ComputerDiagnosticComment { get; set; } = string.Empty;

        #endregion

        #region GearBox

        public string GearBoxShifts { get; set; } = string.Empty;
        public string GearBoxShiftsAcceleration { get; set; } = string.Empty;
        public string GearBoxShiftsBreaking { get; set; } = string.Empty;
        public string GearBoxShiftsCoasting { get; set; } = string.Empty;
        public string GearBoxComment { get; set; } = string.Empty;

        #endregion

        #region Suspension

        public string VibrationsDriving { get; set; } = string.Empty;
        public string VibrationsBreaking { get; set; } = string.Empty;
        public string SoundsDriving { get; set; } = string.Empty;
        public string SoundsDrivingBumps { get; set; } = string.Empty;
        public string SuspentionComment { get; set; } = string.Empty;

        #endregion

        #region BreakSystem

        public string BrakePadWear { get; set; } = string.Empty;
        public string BrakeDiskWear { get; set; } = string.Empty;
        public string BrakeSystemComment { get; set; } = string.Empty;

        #endregion

        #region ControlsOperation

        public string Folding { get; set; } = string.Empty;
        public string Adjustment { get; set; } = string.Empty;
        public string Heating { get; set; } = string.Empty;
        public string SeatHeating { get; set; } = string.Empty;
        public string RearWindowHeating { get; set; } = string.Empty;
        public string WindshieldHeating { get; set; } = string.Empty;
        public string ControlsOperationComment { get; set; } = string.Empty;

        #endregion

        #region AllWheelDrive

        public string CheckingModes { get; set; } = string.Empty;
        public string PanelIndication { get; set; } = string.Empty;
        public string AwdComment { get; set; } = string.Empty;

        #endregion

        #endregion

        #region StartEngine

        public string ColdStartEngine { get; set; } = string.Empty;
        public string DifficultStartEngine { get; set; } = string.Empty;
        public string OtherSounds { get; set; } = string.Empty;
        public string StrongVibration { get; set; } = string.Empty;
        public string StartEngineComment { get; set; } = string.Empty;

        #endregion

        #region ConditionerOperation

        public string CompressorOperation { get; set; } = string.Empty;
        public string FreonAvailability { get; set; } = string.Empty;
        public string DriveBeltCondition { get; set; } = string.Empty;
        public string ConditionerOperationComment { get; set; } = string.Empty;

        #endregion

        #region LegalCheck

        public string Restrictions { get; set; } = string.Empty;
        public string SubjectСollateral { get; set; } = string.Empty;
        public string Fines { get; set; } = string.Empty;
        public string AccidentArticipation { get; set; } = string.Empty;
        public string CarWanted { get; set; } = string.Empty;
        public string VinNumberMatch { get; set; } = string.Empty;
        public string LegalCheckComment { get; set; } = string.Empty;
        public string TestDrive { get; set; } = string.Empty;

        #endregion

        #region Recommendations

        public string TimingDrive { get; set; } = string.Empty;
        public string EngineOilAndFilter { get; set; } = string.Empty;
        public string CheckWheelsAngle { get; set; } = string.Empty;
        public string RecommendationsComment { get; set; } = string.Empty;

        #endregion

        public long UserId { get; set; }

        public UserEntity? User { get; set; }
    }
}
