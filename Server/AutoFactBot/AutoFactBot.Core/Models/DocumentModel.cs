namespace AutoFactBot.Core.Models
{
    public class DocumentModel
    {
        public const int MAX_TITLE_LENGTH = 250;

        private DocumentModel(
        #region
            Guid id, 
            string title, 
            string carModel, 
            string vinNumber,
            string engineNumber, 
            string mileage, 
            string owner, 
            string countOwners,
            string year, 
            string gearBox, 
            string color, 
            string countKeys, 
            string interior,
            string interriorComment, 
            string centrRightStand, 
            string centrRightStandThickness,
            string centrLeftStand, 
            string centrLeftStandThickness, 
            string thresholdRight,
            string thresholdRightThickness, 
            string thresholdLeft, 
            string thresholdLeftThickness,
            string bodyComment, 
            string glasses, 
            string headlights, 
            string mirrors,
            string glassComment, 
            string engineOil, 
            string gearBoxOil, 
            string antifreeze,
            string brakeFluid, 
            string steeringFluid, 
            string engineSpaceComment, 
            string yearTire,
            string remainingTire, 
            string secondComplect, 
            string wheelComplectComment,
            string wheelBearings, 
            string shockAbsorbers, 
            string suspensionArms, 
            string stabilizer,
            string steeringTips, 
            string steeringRack, 
            string engineSump, 
            string gearBoxSound,
            string otherElements, 
            string engineError, 
            string gearBoxError, 
            string absError,
            string airbagError, 
            string addControlUnits, 
            string mileageCompliance,
            string computerDiagnosticComment, 
            string gearBoxShifts, 
            string gearBoxShiftsAcceleration,
            string gearBoxShiftsBreaking, 
            string gearBoxShiftsCoasting, 
            string gearBoxComment,
            string vibrationsDriving, 
            string vibrationsBreaking, 
            string soundsDriving,
            string soundsDrivingBumps, 
            string suspentionComment, 
            string brakePadWear,
            string brakeDiskWear, 
            string brakeSystemComment, 
            string folding, 
            string adjustment,
            string heating, 
            string seatHeating, 
            string rearWindowHeating, 
            string windshieldHeating,
            string controlsOperationComment, 
            string checkingModes, 
            string panelIndication,
            string awdComment, 
            string coldStartEngine, 
            string difficultStartEngine,
            string otherSounds, 
            string strongVibration, 
            string startEngineComment,
            string compressorOperation, 
            string freonAvailability, 
            string driveBeltCondition,
            string conditionerOperationComment, 
            string restrictions, 
            string subjectСollateral,
            string fines, 
            string accidentArticipation, 
            string carWanted, 
            string vinNumberMatch,
            string legalCheckComment, 
            string testDrive, 
            string timingDrive,
            string engineOilAndFilter, 
            string checkWheelsAngle, 
            string recommendationsComment)
        #endregion
        {
            #region
            Id = id;
            Title                           = title;
            CarModel                        = carModel;
            VinNumber                       = vinNumber;
            EngineNumber                    = engineNumber;
            Mileage                         = mileage;
            Owner                           = owner;
            CountOwners                     = countOwners;
            Year                            = year;
            GearBox                         = gearBox;
            Color                           = color;
            CountKeys                       = countKeys;
            Interior                        = interior;
            InterriorComment                = interriorComment;
            CentrRightStand                 = centrRightStand;
            CentrRightStandThickness        = centrRightStandThickness;
            CentrLeftStand                  = centrLeftStand;
            CentrLeftStandThickness         = centrLeftStandThickness;
            ThresholdRight                  = thresholdRight;
            ThresholdRightThickness         = thresholdRightThickness;
            ThresholdLeft                   = thresholdLeft;
            ThresholdLeftThickness          = thresholdLeftThickness;
            BodyComment                     = bodyComment;
            Glasses                         = glasses;
            Headlights                      = headlights;
            Mirrors                         = mirrors;
            GlassComment                    = glassComment;
            EngineOil                       = engineOil;
            GearBoxOil                      = gearBoxOil;
            Antifreeze                      = antifreeze;
            BrakeFluid                      = brakeFluid;
            SteeringFluid                   = steeringFluid;
            EngineSpaceComment              = engineSpaceComment;
            YearTire                        = yearTire;
            RemainingTire                   = remainingTire;
            SecondComplect                  = secondComplect;
            WheelComplectComment            = wheelComplectComment;
            WheelBearings                   = wheelBearings;
            ShockAbsorbers                  = shockAbsorbers;
            SuspensionArms                  = suspensionArms;
            Stabilizer                      = stabilizer;
            SteeringTips                    = steeringTips;
            SteeringRack                    = steeringRack;
            EngineSump                      = engineSump;
            GearBoxSound                    = gearBoxSound;
            OtherElements                   = otherElements;
            EngineError                     = engineError;
            GearBoxError                    = gearBoxError;
            AbsError                        = absError;
            AirbagError                     = airbagError;
            AddControlUnits                 = addControlUnits;
            MileageCompliance               = mileageCompliance;
            ComputerDiagnosticComment       = computerDiagnosticComment;
            GearBoxShifts                   = gearBoxShifts;
            GearBoxShiftsAcceleration       = gearBoxShiftsAcceleration;
            GearBoxShiftsBreaking           = gearBoxShiftsBreaking;
            GearBoxShiftsCoasting           = gearBoxShiftsCoasting;
            GearBoxComment                  = gearBoxComment;
            VibrationsDriving               = vibrationsDriving;
            VibrationsBreaking              = vibrationsBreaking;
            SoundsDriving                   = soundsDriving;
            SoundsDrivingBumps              = soundsDrivingBumps;
            SuspentionComment               = suspentionComment;
            BrakePadWear                    = brakePadWear;
            BrakeDiskWear                   = brakeDiskWear;
            BrakeSystemComment              = brakeSystemComment;
            Folding                         = folding;
            Adjustment                      = adjustment;
            Heating                         = heating;
            SeatHeating                     = seatHeating;
            RearWindowHeating               = rearWindowHeating;
            WindshieldHeating               = windshieldHeating;
            ControlsOperationComment        = controlsOperationComment;
            CheckingModes                   = checkingModes;
            PanelIndication                 = panelIndication;
            AwdComment                      = awdComment;
            ColdStartEngine                 = coldStartEngine;
            DifficultStartEngine            = difficultStartEngine;
            OtherSounds                     = otherSounds;
            StrongVibration                 = strongVibration;
            StartEngineComment              = startEngineComment;
            CompressorOperation             = compressorOperation;
            FreonAvailability               = freonAvailability;
            DriveBeltCondition              = driveBeltCondition;
            ConditionerOperationComment     = conditionerOperationComment;
            Restrictions                    = restrictions;
            SubjectСollateral               = subjectСollateral;
            Fines                           = fines;
            AccidentArticipation            = accidentArticipation;
            CarWanted                       = carWanted;
            VinNumberMatch                  = vinNumberMatch;
            LegalCheckComment               = legalCheckComment;
            TestDrive                       = testDrive;
            TimingDrive                     = timingDrive;
            EngineOilAndFilter              = engineOilAndFilter;
            CheckWheelsAngle                = checkWheelsAngle;
            RecommendationsComment          = recommendationsComment;
            #endregion
        }

        #region Main

        public Guid Id { get; }
        public string Title { get; } = string.Empty;
        public string CarModel { get; } = string.Empty;
        public string VinNumber { get; } = string.Empty;
        public string EngineNumber { get; } = string.Empty;
        public string Mileage { get; } = string.Empty;
        public string Owner { get; } = string.Empty;
        public string CountOwners { get; } = string.Empty;
        public string Year { get; } = string.Empty;
        public string GearBox { get; } = string.Empty;
        public string Color { get; } = string.Empty;
        public string CountKeys { get; } = string.Empty;
        public string Interior { get; } = string.Empty;
        public string InterriorComment { get; } = string.Empty;

        #endregion

        #region Body

        public string CentrRightStand { get; } = string.Empty;
        public string CentrRightStandThickness { get; } = string.Empty;
        public string CentrLeftStand { get; } = string.Empty;
        public string CentrLeftStandThickness { get; } = string.Empty;
        public string ThresholdRight { get; } = string.Empty;
        public string ThresholdRightThickness { get; } = string.Empty;
        public string ThresholdLeft { get; } = string.Empty;
        public string ThresholdLeftThickness { get; } = string.Empty;
        public string BodyComment { get; } = string.Empty;

        #endregion

        #region Glass

        public string Glasses { get; } = string.Empty;
        public string Headlights { get; } = string.Empty;
        public string Mirrors { get; } = string.Empty;
        public string GlassComment { get; } = string.Empty;

        #endregion

        #region EngineSpace

        public string EngineOil { get; } = string.Empty;
        public string GearBoxOil { get; } = string.Empty;
        public string Antifreeze { get; } = string.Empty;
        public string BrakeFluid { get; } = string.Empty;
        public string SteeringFluid { get; } = string.Empty;
        public string EngineSpaceComment { get; } = string.Empty;

        #endregion

        #region WheelCondition

        public string YearTire { get; } = string.Empty;
        public string RemainingTire { get; } = string.Empty;
        public string SecondComplect { get; } = string.Empty;
        public string WheelComplectComment { get; } = string.Empty;

        #endregion

        #region LiftInspection

        public string WheelBearings { get; } = string.Empty;
        public string ShockAbsorbers { get; } = string.Empty;
        public string SuspensionArms { get; } = string.Empty;
        public string Stabilizer { get; } = string.Empty;
        public string SteeringTips { get; } = string.Empty;
        public string SteeringRack { get; } = string.Empty;
        public string EngineSump { get; } = string.Empty;
        public string GearBoxSound { get; } = string.Empty;
        public string OtherElements { get; } = string.Empty;

        #endregion

        #region Diagnostics

        #region ComputerDiagnostic

        public string EngineError { get; } = string.Empty;
        public string GearBoxError { get; } = string.Empty;
        public string AbsError { get; } = string.Empty;
        public string AirbagError { get; } = string.Empty;
        public string AddControlUnits { get; } = string.Empty;
        public string MileageCompliance { get; } = string.Empty;
        public string ComputerDiagnosticComment { get; } = string.Empty;

        #endregion

        #region GearBox

        public string GearBoxShifts { get; } = string.Empty;
        public string GearBoxShiftsAcceleration { get; } = string.Empty;
        public string GearBoxShiftsBreaking { get; } = string.Empty;
        public string GearBoxShiftsCoasting { get; } = string.Empty;
        public string GearBoxComment { get; } = string.Empty;

        #endregion

        #region Suspension

        public string VibrationsDriving { get; } = string.Empty;
        public string VibrationsBreaking { get; } = string.Empty;
        public string SoundsDriving { get; } = string.Empty;
        public string SoundsDrivingBumps { get; } = string.Empty;
        public string SuspentionComment { get; } = string.Empty;

        #endregion

        #region BreakSystem

        public string BrakePadWear { get; } = string.Empty;
        public string BrakeDiskWear { get; } = string.Empty;
        public string BrakeSystemComment { get; } = string.Empty;

        #endregion

        #region ControlsOperation

        public string Folding { get; } = string.Empty;
        public string Adjustment { get; } = string.Empty;
        public string Heating { get; } = string.Empty;
        public string SeatHeating { get; } = string.Empty;
        public string RearWindowHeating { get; } = string.Empty;
        public string WindshieldHeating { get; } = string.Empty;
        public string ControlsOperationComment { get; } = string.Empty;

        #endregion

        #region AllWheelDrive

        public string CheckingModes { get; } = string.Empty;
        public string PanelIndication { get; } = string.Empty;
        public string AwdComment { get; } = string.Empty;

        #endregion

        #endregion

        #region StartEngine

        public string ColdStartEngine { get; } = string.Empty;
        public string DifficultStartEngine { get; } = string.Empty;
        public string OtherSounds { get; } = string.Empty;
        public string StrongVibration { get; } = string.Empty;
        public string StartEngineComment { get; } = string.Empty;

        #endregion

        #region ConditionerOperation

        public string CompressorOperation { get; } = string.Empty;
        public string FreonAvailability { get; } = string.Empty;
        public string DriveBeltCondition { get; } = string.Empty;
        public string ConditionerOperationComment { get; } = string.Empty;

        #endregion

        #region LegalCheck

        public string Restrictions { get; } = string.Empty;
        public string SubjectСollateral { get; } = string.Empty;
        public string Fines { get; } = string.Empty;
        public string AccidentArticipation { get; } = string.Empty;
        public string CarWanted { get; } = string.Empty;
        public string VinNumberMatch { get; } = string.Empty;
        public string LegalCheckComment { get; } = string.Empty;
        public string TestDrive { get; } = string.Empty;

        #endregion

        #region Recommendations

        public string TimingDrive { get; } = string.Empty;
        public string EngineOilAndFilter { get; } = string.Empty;
        public string CheckWheelsAngle { get; } = string.Empty;
        public string RecommendationsComment { get; } = string.Empty;

        #endregion

        public static (DocumentModel, string Error) Create(
        #region
            Guid id, 
            string title, 
            string carModel, 
            string vinNumber,
            string engineNumber, 
            string mileage, 
            string owner, 
            string countOwners,
            string year, 
            string gearBox, 
            string color, 
            string countKeys, 
            string interior,
            string interriorComment,
            string centrRightStand,
            string centrRightStandThickness,
            string centrLeftStand,
            string centrLeftStandThickness,
            string thresholdRight,
            string thresholdRightThickness,
            string thresholdLeft,
            string thresholdLeftThickness,
            string bodyComment,
            string glasses,
            string headlights,
            string mirrors,
            string glassComment,
            string engineOil,
            string gearBoxOil,
            string antifreeze,
            string brakeFluid,
            string steeringFluid,
            string engineSpaceComment,
            string yearTire,
            string remainingTire,
            string secondComplect,
            string wheelComplectComment,
            string wheelBearings,
            string shockAbsorbers,
            string suspensionArms,
            string stabilizer,
            string steeringTips,
            string steeringRack,
            string engineSump,
            string gearBoxSound,
            string otherElements,
            string engineError,
            string gearBoxError,
            string absError,
            string airbagError,
            string addControlUnits,
            string mileageCompliance,
            string computerDiagnosticComment,
            string gearBoxShifts,
            string gearBoxShiftsAcceleration,
            string gearBoxShiftsBreaking,
            string gearBoxShiftsCoasting,
            string gearBoxComment,
            string vibrationsDriving,
            string vibrationsBreaking,
            string soundsDriving,
            string soundsDrivingBumps,
            string suspentionComment,
            string brakePadWear,
            string brakeDiskWear,
            string brakeSystemComment,
            string folding,
            string adjustment,
            string heating,
            string seatHeating,
            string rearWindowHeating,
            string windshieldHeating,
            string controlsOperationComment,
            string checkingModes,
            string panelIndication,
            string awdComment,
            string coldStartEngine,
            string difficultStartEngine,
            string otherSounds,
            string strongVibration,
            string startEngineComment,
            string compressorOperation,
            string freonAvailability,
            string driveBeltCondition,
            string conditionerOperationComment,
            string restrictions,
            string subjectСollateral,
            string fines,
            string accidentArticipation,
            string carWanted,
            string vinNumberMatch,
            string legalCheckComment,
            string testDrive,
            string timingDrive,
            string engineOilAndFilter,
            string checkWheelsAngle,
            string recommendationsComment)
        #endregion
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
                error = "Title can not be empty or longer then 250 symbols";

            var document = new DocumentModel(
            #region
                id, 
                title, 
                carModel, 
                vinNumber,
                engineNumber, 
                mileage, 
                owner, 
                countOwners, 
                year,
                gearBox, 
                color, 
                countKeys, 
                interior,
                interriorComment,
                centrRightStand,
                centrRightStandThickness,
                centrLeftStand,
                centrLeftStandThickness,
                thresholdRight,
                thresholdRightThickness,
                thresholdLeft,
                thresholdLeftThickness,
                bodyComment,
                glasses,
                headlights,
                mirrors,
                glassComment,
                engineOil,
                gearBoxOil,
                antifreeze,
                brakeFluid,
                steeringFluid,
                engineSpaceComment,
                yearTire,
                remainingTire,
                secondComplect,
                wheelComplectComment,
                wheelBearings,
                shockAbsorbers,
                suspensionArms,
                stabilizer,
                steeringTips,
                steeringRack,
                engineSump,
                gearBoxSound,
                otherElements,
                engineError,
                gearBoxError,
                absError,
                airbagError,
                addControlUnits,
                mileageCompliance,
                computerDiagnosticComment,
                gearBoxShifts,
                gearBoxShiftsAcceleration,
                gearBoxShiftsBreaking,
                gearBoxShiftsCoasting,
                gearBoxComment,
                vibrationsDriving,
                vibrationsBreaking,
                soundsDriving,
                soundsDrivingBumps,
                suspentionComment,
                brakePadWear,
                brakeDiskWear,
                brakeSystemComment,
                folding,
                adjustment,
                heating,
                seatHeating,
                rearWindowHeating,
                windshieldHeating,
                controlsOperationComment,
                checkingModes,
                panelIndication,
                awdComment,
                coldStartEngine,
                difficultStartEngine,
                otherSounds,
                strongVibration,
                startEngineComment,
                compressorOperation,
                freonAvailability,
                driveBeltCondition,
                conditionerOperationComment,
                restrictions,
                subjectСollateral,
                fines,
                accidentArticipation,
                carWanted,
                vinNumberMatch,
                legalCheckComment,
                testDrive,
                timingDrive,
                engineOilAndFilter,
                checkWheelsAngle,
                recommendationsComment);
            #endregion

            return (document, error);
        }
    }
}
