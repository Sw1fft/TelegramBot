﻿namespace AutoFactBot.API.Contracts
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
        string Interior,
        string InterriorComment,
        string CentrRightStand,
        string CentrRightStandThickness,
        string CentrLeftStand,
        string CentrLeftStandThickness,
        string ThresholdRight,
        string ThresholdRightThickness,
        string ThresholdLeft,
        string ThresholdLeftThickness,
        string BodyComment,
        string Glasses,
        string Headlights,
        string Mirrors,
        string GlassComment,
        string EngineOil,
        string GearBoxOil,
        string Antifreeze,
        string BrakeFluid,
        string SteeringFluid,
        string EngineSpaceComment,
        string YearTire,
        string RemainingTire,
        string SecondComplect,
        string WheelComplectComment,
        string WheelBearings,
        string ShockAbsorbers,
        string SuspensionArms,
        string Stabilizer,
        string SteeringTips,
        string SteeringRack,
        string EngineSump,
        string GearBoxSound,
        string OtherElements,
        string EngineError,
        string GearBoxError,
        string AbsError,
        string AirbagError,
        string AddControlUnits,
        string MileageCompliance,
        string ComputerDiagnosticComment,
        string GearBoxShifts,
        string GearBoxShiftsAcceleration,
        string GearBoxShiftsBreaking,
        string GearBoxShiftsCoasting,
        string GearBoxComment,
        string VibrationsDriving,
        string VibrationsBreaking,
        string SoundsDriving,
        string SoundsDrivingBumps,
        string SuspentionComment,
        string BrakePadWear,
        string BrakeDiskWear,
        string BrakeSystemComment,
        string Folding,
        string Adjustment,
        string Heating,
        string SeatHeating,
        string RearWindowHeating,
        string WindshieldHeating,
        string ControlsOperationComment,
        string CheckingModes,
        string PanelIndication,
        string AwdComment,
        string ColdStartEngine,
        string DifficultStartEngine,
        string OtherSounds,
        string StrongVibration,
        string StartEngineComment,
        string CompressorOperation,
        string FreonAvailability,
        string DriveBeltCondition,
        string ConditionerOperationComment,
        string Restrictions,
        string SubjectСollateral,
        string Fines,
        string AccidentArticipation,
        string CarWanted,
        string VinNumberMatch,
        string LegalCheckComment,
        string TestDrive,
        string TimingDrive,
        string EngineOilAndFilter,
        string CheckWheelsAngle,
        string RecommendationsComment);
}
