using AutoFactBot.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using AutoFactBot.Data.Entities;
using AutoFactBot.Data.Context;
using AutoFactBot.Core.Models;

namespace AutoFactBot.Data.Repositories
{
    public class DocumentsRepository : IDocumentsRepository
    {
        private readonly DocumentDbContext _dbContext;
        private readonly long _userId;

        public DocumentsRepository(DocumentDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<DocumentModel>> GetAllDocuments()
        {
            var documentEntity = await _dbContext.Documents
                .AsNoTracking()
                .ToListAsync();

            #region documents

            var documents = documentEntity.Select(
                s => DocumentModel.Create(
                    s.Id,
                    s.Title,
                    s.CarModel,
                    s.VinNumber,
                    s.EngineNumber,
                    s.Mileage,
                    s.Owner,
                    s.CountOwners,
                    s.Year,
                    s.GearBox,
                    s.Color,
                    s.CountKeys,
                    s.Interior,
                    s.InterriorComment,
                    s.CentrRightStand,
                    s.CentrRightStandThickness,
                    s.CentrLeftStand,
                    s.CentrLeftStandThickness,
                    s.ThresholdRight,
                    s.ThresholdRightThickness,
                    s.ThresholdLeft,
                    s.ThresholdLeftThickness,
                    s.BodyComment,
                    s.Glasses,
                    s.Headlights,
                    s.Mirrors,
                    s.GlassComment,
                    s.EngineOil,
                    s.GearBoxOil,
                    s.Antifreeze,
                    s.BrakeFluid,
                    s.SteeringFluid,
                    s.EngineSpaceComment,
                    s.YearTire,
                    s.RemainingTire,
                    s.SecondComplect,
                    s.WheelComplectComment,
                    s.WheelBearings,
                    s.ShockAbsorbers,
                    s.SuspensionArms,
                    s.Stabilizer,
                    s.SteeringTips,
                    s.SteeringRack,
                    s.EngineSump,
                    s.GearBoxSound,
                    s.OtherElements,
                    s.EngineError,
                    s.GearBoxError,
                    s.AbsError,
                    s.AirbagError,
                    s.AddControlUnits,
                    s.MileageCompliance,
                    s.ComputerDiagnosticComment,
                    s.GearBoxShifts,
                    s.GearBoxShiftsAcceleration,
                    s.GearBoxShiftsBreaking,
                    s.GearBoxShiftsCoasting,
                    s.GearBoxComment,
                    s.VibrationsDriving,
                    s.VibrationsBreaking,
                    s.SoundsDriving,
                    s.SoundsDrivingBumps,
                    s.SuspentionComment,
                    s.BrakePadWear,
                    s.BrakeDiskWear,
                    s.BrakeSystemComment,
                    s.Folding,
                    s.Adjustment,
                    s.Heating,
                    s.SeatHeating,
                    s.RearWindowHeating,
                    s.WindshieldHeating,
                    s.ControlsOperationComment,
                    s.CheckingModes,
                    s.PanelIndication,
                    s.AwdComment,
                    s.ColdStartEngine,
                    s.DifficultStartEngine,
                    s.OtherSounds,
                    s.StrongVibration,
                    s.StartEngineComment,
                    s.CompressorOperation,
                    s.FreonAvailability,
                    s.DriveBeltCondition,
                    s.ConditionerOperationComment,
                    s.Restrictions,
                    s.SubjectСollateral,
                    s.Fines,
                    s.AccidentArticipation,
                    s.CarWanted,
                    s.VinNumberMatch,
                    s.LegalCheckComment,
                    s.TestDrive,
                    s.TimingDrive,
                    s.EngineOilAndFilter,
                    s.CheckWheelsAngle,
                    s.RecommendationsComment).Item1).ToList();

            #endregion

            return documents;
        }

        public async Task<Guid> CreateDocument(DocumentModel document)
        {
            var userExists = _dbContext.Users.FirstOrDefault(u => u.Id == _userId);

            if (userExists == null)
            {
                var userEntity = new UserEntity()
                {
                    Id = _userId,
                };

                await _dbContext.AddAsync(userEntity);
            }

            var documentEntity = new DocumentEntity()
            {
                Id                              = document.Id,
                Title                           = document.Title,
                CarModel                        = document.CarModel,
                VinNumber                       = document.VinNumber,
                EngineNumber                    = document.EngineNumber,
                Mileage                         = document.Mileage,
                Owner                           = document.Owner,
                CountOwners                     = document.CountOwners,
                Year                            = document.Year,
                GearBox                         = document.GearBox,
                Color                           = document.Color,
                CountKeys                       = document.CountKeys,
                Interior                        = document.Interior,
                InterriorComment                = document.InterriorComment,
                CentrRightStand                 = document.CentrRightStand,
                CentrRightStandThickness        = document.CentrRightStandThickness,
                CentrLeftStand                  = document.CentrLeftStand,
                CentrLeftStandThickness         = document.CentrLeftStandThickness,
                ThresholdRight                  = document.ThresholdRight,
                ThresholdRightThickness         = document.ThresholdRightThickness,
                ThresholdLeft                   = document.ThresholdLeft,
                ThresholdLeftThickness          = document.ThresholdLeftThickness,
                BodyComment                     = document.BodyComment,
                Glasses                         = document.Glasses,
                Headlights                      = document.Headlights,
                Mirrors                         = document.Mirrors,
                GlassComment                    = document.GlassComment,
                EngineOil                       = document.EngineOil,
                GearBoxOil                      = document.GearBoxOil,
                Antifreeze                      = document.Antifreeze,
                BrakeFluid                      = document.BrakeFluid,
                SteeringFluid                   = document.SteeringFluid,
                EngineSpaceComment              = document.EngineSpaceComment,
                YearTire                        = document.YearTire,
                RemainingTire                   = document.RemainingTire,
                SecondComplect                  = document.SecondComplect,
                WheelComplectComment            = document.WheelComplectComment,
                WheelBearings                   = document.WheelBearings,
                ShockAbsorbers                  = document.ShockAbsorbers,
                SuspensionArms                  = document.SuspensionArms,
                Stabilizer                      = document.Stabilizer,
                SteeringTips                    = document.SteeringTips,
                SteeringRack                    = document.SteeringRack,
                EngineSump                      = document.EngineSump,
                GearBoxSound                    = document.GearBoxSound,
                OtherElements                   = document.OtherElements,
                EngineError                     = document.EngineError,
                GearBoxError                    = document.GearBoxError,
                AbsError                        = document.AbsError,
                AirbagError                     = document.AirbagError,
                AddControlUnits                 = document.AddControlUnits,
                MileageCompliance               = document.MileageCompliance,
                ComputerDiagnosticComment       = document.ComputerDiagnosticComment,
                GearBoxShifts                   = document.GearBoxShifts,
                GearBoxShiftsAcceleration       = document.GearBoxShiftsAcceleration,
                GearBoxShiftsBreaking           = document.GearBoxShiftsBreaking,
                GearBoxShiftsCoasting           = document.GearBoxShiftsCoasting,
                GearBoxComment                  = document.GearBoxComment,
                VibrationsDriving               = document.VibrationsDriving,
                VibrationsBreaking              = document.VibrationsBreaking,
                SoundsDriving                   = document.SoundsDriving,
                SoundsDrivingBumps              = document.SoundsDrivingBumps,
                SuspentionComment               = document.SuspentionComment,
                BrakePadWear                    = document.BrakePadWear,
                BrakeDiskWear                   = document.BrakeDiskWear,
                BrakeSystemComment              = document.BrakeSystemComment,
                Folding                         = document.Folding,
                Adjustment                      = document.Adjustment,
                Heating                         = document.Heating,
                SeatHeating                     = document.SeatHeating,
                RearWindowHeating               = document.RearWindowHeating,
                WindshieldHeating               = document.WindshieldHeating,
                ControlsOperationComment        = document.ControlsOperationComment,
                CheckingModes                   = document.CheckingModes,
                PanelIndication                 = document.PanelIndication,
                AwdComment                      = document.AwdComment,
                ColdStartEngine                 = document.ColdStartEngine,
                DifficultStartEngine            = document.DifficultStartEngine,
                OtherSounds                     = document.OtherSounds,
                StrongVibration                 = document.StrongVibration,
                StartEngineComment              = document.StartEngineComment,
                CompressorOperation             = document.CompressorOperation,
                FreonAvailability               = document.FreonAvailability,
                DriveBeltCondition              = document.DriveBeltCondition,
                ConditionerOperationComment     = document.ConditionerOperationComment,
                Restrictions                    = document.Restrictions,
                SubjectСollateral               = document.SubjectСollateral,
                Fines                           = document.Fines,
                AccidentArticipation            = document.AccidentArticipation,
                CarWanted                       = document.CarWanted,
                VinNumberMatch                  = document.VinNumberMatch,
                LegalCheckComment               = document.LegalCheckComment,
                TestDrive                       = document.TestDrive,
                TimingDrive                     = document.TimingDrive,
                EngineOilAndFilter              = document.EngineOilAndFilter,
                CheckWheelsAngle                = document.CheckWheelsAngle,
                RecommendationsComment          = document.RecommendationsComment,
                UserId                          = _userId
            };

            await _dbContext.AddAsync(documentEntity);
            await _dbContext.SaveChangesAsync();

            return documentEntity.Id;
        }

        public async Task<Guid> UpdateDocument(
        #region var
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
            await _dbContext.Documents
            #region prop
                .Where(d => d.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(d => d.Title, d => title)
                    .SetProperty(d => d.CarModel, d => carModel)
                    .SetProperty(d => d.VinNumber, d => vinNumber)
                    .SetProperty(d => d.EngineNumber, d => engineNumber)
                    .SetProperty(d => d.Mileage, d => mileage)
                    .SetProperty(d => d.Owner, d => owner)
                    .SetProperty(d => d.CountOwners, d => countOwners)
                    .SetProperty(d => d.Year, d => year)
                    .SetProperty(d => d.GearBox, d => gearBox)
                    .SetProperty(d => d.Color, d => color)
                    .SetProperty(d => d.CountKeys, d => countKeys)
                    .SetProperty(d => d.Interior, d => interior)
                    .SetProperty(d => d.InterriorComment, d => interriorComment)
                    .SetProperty(d => d.CentrRightStand, d => centrRightStand)
                    .SetProperty(d => d.CentrRightStandThickness, d => centrRightStandThickness)
                    .SetProperty(d => d.CentrLeftStand, d => centrLeftStand)
                    .SetProperty(d => d.CentrLeftStandThickness, d => centrLeftStandThickness)
                    .SetProperty(d => d.ThresholdRight, d => thresholdRight)
                    .SetProperty(d => d.ThresholdRightThickness, d => thresholdRightThickness)
                    .SetProperty(d => d.ThresholdLeft, d => thresholdLeft)
                    .SetProperty(d => d.ThresholdLeftThickness, d => thresholdLeftThickness)
                    .SetProperty(d => d.BodyComment, d => bodyComment)
                    .SetProperty(d => d.Glasses, d => glasses)
                    .SetProperty(d => d.Headlights, d => headlights)
                    .SetProperty(d => d.Mirrors, d => mirrors)
                    .SetProperty(d => d.GlassComment, d => glassComment)
                    .SetProperty(d => d.EngineOil, d => engineOil)
                    .SetProperty(d => d.GearBoxOil, d => gearBoxOil)
                    .SetProperty(d => d.Antifreeze, d => antifreeze)
                    .SetProperty(d => d.BrakeFluid, d => brakeFluid)
                    .SetProperty(d => d.SteeringFluid, d => steeringFluid)
                    .SetProperty(d => d.EngineSpaceComment, d => engineSpaceComment)
                    .SetProperty(d => d.YearTire, d => yearTire)
                    .SetProperty(d => d.RemainingTire, d => remainingTire)
                    .SetProperty(d => d.SecondComplect, d => secondComplect)
                    .SetProperty(d => d.WheelComplectComment, d => wheelComplectComment)
                    .SetProperty(d => d.WheelBearings, d => wheelBearings)
                    .SetProperty(d => d.ShockAbsorbers, d => shockAbsorbers)
                    .SetProperty(d => d.SuspensionArms, d => suspensionArms)
                    .SetProperty(d => d.Stabilizer, d => stabilizer)
                    .SetProperty(d => d.SteeringTips, d => steeringTips)
                    .SetProperty(d => d.SteeringRack, d => steeringRack)
                    .SetProperty(d => d.EngineSump, d => engineSump)
                    .SetProperty(d => d.GearBoxSound, d => gearBoxSound)
                    .SetProperty(d => d.OtherElements, d => otherElements)
                    .SetProperty(d => d.EngineError, d => engineError)
                    .SetProperty(d => d.GearBoxError, d => gearBoxError)
                    .SetProperty(d => d.AbsError, d => absError)
                    .SetProperty(d => d.AirbagError, d => airbagError)
                    .SetProperty(d => d.AddControlUnits, d => addControlUnits)
                    .SetProperty(d => d.MileageCompliance, d => mileageCompliance)
                    .SetProperty(d => d.ComputerDiagnosticComment, d => computerDiagnosticComment)
                    .SetProperty(d => d.GearBoxShifts, d => gearBoxShifts)
                    .SetProperty(d => d.GearBoxShiftsAcceleration, d => gearBoxShiftsAcceleration)
                    .SetProperty(d => d.GearBoxShiftsBreaking, d => gearBoxShiftsBreaking)
                    .SetProperty(d => d.GearBoxShiftsCoasting, d => gearBoxShiftsCoasting)
                    .SetProperty(d => d.GearBoxComment, d => gearBoxComment)
                    .SetProperty(d => d.VibrationsDriving, d => vibrationsDriving)
                    .SetProperty(d => d.VibrationsBreaking, d => vibrationsBreaking)
                    .SetProperty(d => d.SoundsDriving, d => soundsDriving)
                    .SetProperty(d => d.SoundsDrivingBumps, d => soundsDrivingBumps)
                    .SetProperty(d => d.SuspentionComment, d => suspentionComment)
                    .SetProperty(d => d.Folding, d => folding)
                    .SetProperty(d => d.Adjustment, d => adjustment)
                    .SetProperty(d => d.Heating, d => heating)
                    .SetProperty(d => d.SeatHeating, d => seatHeating)
                    .SetProperty(d => d.RearWindowHeating, d => rearWindowHeating)
                    .SetProperty(d => d.WindshieldHeating, d => windshieldHeating)
                    .SetProperty(d => d.ControlsOperationComment, d => controlsOperationComment)
                    .SetProperty(d => d.CheckingModes, d => checkingModes)
                    .SetProperty(d => d.PanelIndication, d => panelIndication)
                    .SetProperty(d => d.AwdComment, d => awdComment)
                    .SetProperty(d => d.ColdStartEngine, d => coldStartEngine)
                    .SetProperty(d => d.DifficultStartEngine, d => difficultStartEngine)
                    .SetProperty(d => d.OtherSounds, d => otherSounds)
                    .SetProperty(d => d.StrongVibration, d => strongVibration)
                    .SetProperty(d => d.StartEngineComment, d => startEngineComment)
                    .SetProperty(d => d.CompressorOperation, d => compressorOperation)
                    .SetProperty(d => d.FreonAvailability, d => freonAvailability)
                    .SetProperty(d => d.DriveBeltCondition, d => driveBeltCondition)
                    .SetProperty(d => d.ConditionerOperationComment, d => conditionerOperationComment)
                    .SetProperty(d => d.Restrictions, d => restrictions)
                    .SetProperty(d => d.SubjectСollateral, d => subjectСollateral)
                    .SetProperty(d => d.Fines, d => fines)
                    .SetProperty(d => d.AccidentArticipation, d => accidentArticipation)
                    .SetProperty(d => d.CarWanted, d => carWanted)
                    .SetProperty(d => d.VinNumberMatch, d => vinNumberMatch)
                    .SetProperty(d => d.LegalCheckComment, d => legalCheckComment)
                    .SetProperty(d => d.TestDrive, d => testDrive)
                    .SetProperty(d => d.TimingDrive, d => timingDrive)
                    .SetProperty(d => d.EngineOilAndFilter, d => engineOilAndFilter)
                    .SetProperty(d => d.CheckWheelsAngle, d => checkWheelsAngle)
                    .SetProperty(d => d.RecommendationsComment, d => recommendationsComment));
            #endregion

            return id;
        }

        public async Task<Guid> DeleteDocument(Guid id)
        {
            await _dbContext.Documents
                .Where(d => d.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
