import { DocumentRequest } from "@/Contracts/Request";
import { useEffect, useState } from "react";
import { Checkbox, Input, Modal, Select } from "antd";

interface Props {
    values: Document;
    isOpenModal: boolean;
    createHandle: (request: DocumentRequest) => void;
    closeHandle: () => void;
};

export const CreateDocument = ({
        values, 
        isOpenModal, 
        createHandle, 
        closeHandle
    }: Props) => {
    const [title, setDocumentTitle]                                                     = useState<string>("");
    const [carModel, setCarModel]                                                       = useState<string>("");
    const [vin, setVin]                                                                 = useState<string>("");
    const [engineNumber, setEngineNumber]                                               = useState<string>("");
    const [mileage, setMileage]                                                         = useState<string>("");
    const [owner, setOwner]                                                             = useState<string>("");
    const [countOwners, setCountOwners]                                                 = useState<string>("");
    const [year, setYear]                                                               = useState<string>("");
    const [gearBox, setGearBox]                                                         = useState<string>("");
    const [color, setColor]                                                             = useState<string>("");
    const [countKeys, SetCountKeys]                                                     = useState<string>("");
    const [interior, setInterior]                                                       = useState<string>("");
    const [interriorComment, setInterriorComment]                                       = useState<string>("");
    const [centrRightStand, setCentrRightStand]                                         = useState<string>("");
    const [centrRightStandThickness, setCentrRightStandThickness]                       = useState<string>("");
    const [centrLeftStand, setCentrLeftStand]                                           = useState<string>("");
    const [centrLeftStandThickness, setCentrLeftStandThickness]                         = useState<string>("");
    const [thresholdRight, setThresholdRight]                                           = useState<string>("");
    const [thresholdRightThickness, setThresholdRightThickness]                         = useState<string>("");
    const [thresholdLeft, setThresholdLeft]                                             = useState<string>("");
    const [thresholdLeftThickness, setThresholdLeftThickness]                           = useState<string>("");
    const [bodyComment, setBodyComment]                                                 = useState<string>("");
    const [glasses, setGlasses]                                                         = useState<string>("");
    const [headlights, setHeadlights]                                                   = useState<string>("");
    const [mirrors, setMirrors]                                                         = useState<string>("");
    const [glassComment, setGlassComment]                                               = useState<string>("");
    const [engineOil, setEngineOil]                                                     = useState<string>("");
    const [gearBoxOil, setGearBoxOil]                                                   = useState<string>("");
    const [antifreeze, setAntifreeze]                                                   = useState<string>("");
    const [brakeFluid, setBrakeFluid]                                                   = useState<string>("");
    const [steeringFluid, setSteeringFluid]                                             = useState<string>("");
    const [engineSpaceComment, setEngineSpaceComment]                                   = useState<string>("");
    const [yearTire, setYearTire]                                                       = useState<string>("");
    const [remainingTire, setRemainingTire]                                             = useState<string>("");
    const [secondComplect, setSecondComplect]                                           = useState<string>("");
    const [wheelComplectComment, setWheelComplectComment]                               = useState<string>("");
    const [wheelBearings, setWheelBearings]                                             = useState<string>("");
    const [shockAbsorbers, setShockAbsorbers]                                           = useState<string>("");
    const [suspensionArms, setSuspensionArms]                                           = useState<string>("");
    const [stabilizer, setStabilizer]                                                   = useState<string>("");
    const [steeringTips, setSteeringTips]                                               = useState<string>("");
    const [steeringRack, setSteeringRack]                                               = useState<string>("");
    const [engineSump, setEngineSump]                                                   = useState<string>("");
    const [gearBoxSound, setGearBoxSound]                                               = useState<string>("");
    const [otherElements, setOtherElements]                                             = useState<string>("");
    const [engineError, setEngineError]                                                 = useState<string>("");
    const [gearBoxError, setGearBoxError]                                               = useState<string>("");
    const [absError, setAbsError]                                                       = useState<string>("");
    const [airbagError, setAirbagError]                                                 = useState<string>("");
    const [addControlUnits, setAddControlUnits]                                         = useState<string>("");
    const [mileageCompliance, setMileageCompliance]                                     = useState<string>("");
    const [computerDiagnosticComment, setComputerDiagnosticComment]                     = useState<string>("");
    const [gearBoxShifts, setGearBoxShifts]                                             = useState<string>("");
    const [gearBoxShiftsAcceleration, setGearBoxShiftsAcceleration]                     = useState<string>("");
    const [gearBoxShiftsBreaking, setGearBoxShiftsBreaking]                             = useState<string>("");
    const [gearBoxShiftsCoasting, setGearBoxShiftsCoasting]                             = useState<string>("");
    const [gearBoxComment, setGearBoxComment]                                           = useState<string>("");
    const [vibrationsDriving, setVibrationsDriving]                                     = useState<string>("");
    const [vibrationsBreaking, setVibrationsBreaking]                                   = useState<string>("");
    const [soundsDriving, setSoundsDriving]                                             = useState<string>("");
    const [soundsDrivingBumps, setSoundsDrivingBumps]                                   = useState<string>("");
    const [suspentionComment, setSuspentionComment]                                     = useState<string>("");
    const [brakePadWear, setBrakePadWear]                                               = useState<string>("");
    const [brakeDiskWear, setBrakeDiskWear]                                             = useState<string>("");
    const [brakeSystemComment, setBrakeSystemComment]                                   = useState<string>("");
    const [folding, setFolding]                                                         = useState<string>("");
    const [adjustment, setAdjustment]                                                   = useState<string>("");
    const [heating, setHeating]                                                         = useState<string>("");
    const [seatHeating, setSeatHeating]                                                 = useState<string>("");
    const [rearWindowHeating, setRearWindowHeating]                                     = useState<string>("");
    const [windshieldHeating, setWindshieldHeating]                                     = useState<string>("");
    const [controlsOperationComment, setControlsOperationComment]                       = useState<string>("");
    const [checkingModes, setCheckingModes]                                             = useState<string>("");
    const [panelIndication, setPanelIndication]                                         = useState<string>("");
    const [awdComment, setAwdComment]                                                   = useState<string>("");
    const [coldStartEngine, setColdStartEngine]                                         = useState<string>("");
    const [difficultStartEngine, setDifficultStartEngine]                               = useState<string>("");
    const [otherSounds, setOtherSounds]                                                 = useState<string>("");
    const [strongVibration, setStrongVibration]                                         = useState<string>("");
    const [startEngineComment, setStartEngineComment]                                   = useState<string>("");
    const [compressorOperation, setCompressorOperation]                                 = useState<string>("");
    const [freonAvailability, setFreonAvailability]                                     = useState<string>("");
    const [driveBeltCondition, setDriveBeltCondition]                                   = useState<string>("");
    const [conditionerOperationComment, setConditionerOperationComment]                 = useState<string>("");
    const [restrictions, setRestrictions]                                               = useState<string>("");
    const [subjectСollateral, setSubjectСollateral]                                     = useState<string>("");
    const [fines, setFines]                                                             = useState<string>("");
    const [accidentArticipation, setAccidentArticipation]                               = useState<string>("");
    const [carWanted, setCarWanted]                                                     = useState<string>("");
    const [vinNumberMatch, setVinNumberMatch]                                           = useState<string>("");
    const [legalCheckComment, setLegalCheckComment]                                     = useState<string>("");
    const [testDrive, setTestDrive]                                                     = useState<string>("");
    const [timingDrive, setTimingDrive]                                                 = useState<string>("");
    const [engineOilAndFilter, setEngineOilAndFilter]                                   = useState<string>("");
    const [checkWheelsAngle, setCheckWheelsAngle]                                       = useState<string>("");
    const [recommendationsComment, setRecommendationsComment]                           = useState<string>("");

    useEffect(() => {
        setDocumentTitle(values.documentTitle);
        setCarModel(values.carModel);
        setVin(values.vin);
        setEngineNumber(values.engineNumber);
        setMileage(values.mileage);
        setOwner(values.owner);
        setCountOwners(values.countOwners);
        setYear(values.year);
        setGearBox(values.gearBox);
        setColor(values.color);
        SetCountKeys(values.countKeys);
        setInterior(values.interior);
        setInterriorComment(values.interior);
        setCentrRightStand(values.centrRightStand);
        setCentrRightStandThickness(values.centrRightStandThickness);
        setCentrLeftStand(values.centrLeftStand);
        setCentrLeftStandThickness(values.centrLeftStandThickness);
        setThresholdRight(values.thresholdRight);
        setThresholdRightThickness(values.thresholdRightThickness);
        setThresholdLeft(values.thresholdLeft);
        setThresholdLeftThickness(values.thresholdLeftThickness);
        setBodyComment(values.bodyComment);
        setGlasses(values.glasses);
        setHeadlights(values.headlights);
        setMirrors(values.mirrors);
        setGlassComment(values.glassComment);
        setEngineOil(values.engineOil);
        setGearBoxOil(values.gearBoxOil);
        setAntifreeze(values.antifreeze);
        setBrakeFluid(values.brakeFluid);
        setSteeringFluid(values.steeringFluid);
        setEngineSpaceComment(values.engineSpaceComment);
        setYearTire(values.yearTire);
        setRemainingTire(values.remainingTire);
        setSecondComplect(values.secondComplect);
        setWheelComplectComment(values.wheelComplectComment);
        setWheelBearings(values.wheelBearings);
        setShockAbsorbers(values.shockAbsorbers);
        setSuspensionArms(values.suspensionArms);
        setStabilizer(values.stabilizer);
        setSteeringTips(values.steeringTips);
        setSteeringRack(values.steeringRack);
        setEngineSump(values.engineSump);
        setGearBoxSound(values.gearBoxSound);
        setOtherElements(values.otherElements);
        setEngineError(values.engineError);
        setGearBoxError(values.gearBoxError);
        setAbsError(values.absError);
        setAirbagError(values.airbagError);
        setAddControlUnits(values.addControlUnits);
        setMileageCompliance(values.mileageCompliance);
        setComputerDiagnosticComment(values.computerDiagnosticComment);
        setGearBoxShifts(values.gearBoxShifts);
        setGearBoxShiftsAcceleration(values.gearBoxShiftsAcceleration);
        setGearBoxShiftsBreaking(values.gearBoxShiftsBreaking);
        setGearBoxShiftsCoasting(values.gearBoxShiftsCoasting);
        setGearBoxComment(values.gearBoxComment);
        setVibrationsDriving(values.vibrationsDriving);
        setVibrationsBreaking(values.vibrationsBreaking);
        setSoundsDriving(values.soundsDriving);
        setSoundsDrivingBumps(values.soundsDrivingBumps);
        setSuspentionComment(values.suspentionComment);
        setBrakePadWear(values.brakePadWear);
        setBrakeDiskWear(values.brakeDiskWear);
        setBrakeSystemComment(values.brakeSystemComment);
        setFolding(values.folding);
        setAdjustment(values.adjustment);
        setHeating(values.heating);
        setSeatHeating(values.seatHeating);
        setRearWindowHeating(values.rearWindowHeating);
        setWindshieldHeating(values.windshieldHeating);
        setControlsOperationComment(values.controlsOperationComment);
        setCheckingModes(values.checkingModes);
        setPanelIndication(values.panelIndication);
        setAwdComment(values.awdComment);
        setColdStartEngine(values.coldStartEngine);
        setDifficultStartEngine(values.difficultStartEngine);
        setOtherSounds(values.otherSounds);
        setStrongVibration(values.strongVibration);
        setStartEngineComment(values.startEngineComment);
        setCompressorOperation(values.compressorOperation);
        setFreonAvailability(values.freonAvailability);
        setDriveBeltCondition(values.driveBeltCondition);
        setConditionerOperationComment(values.conditionerOperationComment);
        setRestrictions(values.restrictions);
        setSubjectСollateral(values.subjectСollateral);
        setFines(values.fines);
        setAccidentArticipation(values.accidentArticipation);
        setCarWanted(values.carWanted);
        setVinNumberMatch(values.vinNumberMatch);
        setLegalCheckComment(values.legalCheckComment);
        setTestDrive(values.testDrive);
        setTimingDrive(values.timingDrive);
        setEngineOilAndFilter(values.engineOilAndFilter);
        setCheckWheelsAngle(values.checkWheelsAngle);
        setRecommendationsComment(values.recommendationsComment);
    }, [values]);

    const handleOnOk = async() => {
        const documentRequest = {
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
            recommendationsComment
        };

        createHandle(documentRequest)
    };

    return (
        <Modal open={isOpenModal} onOk={handleOnOk} cancelText='Отменить' onCancel={closeHandle}>
            <div style={{padding: "1px"}}>
                <div>
                    <h2>ОСНОВНОЕ</h2>
                    <div>
                        <label>Название:</label>
                        <Input value={title} onChange={(e) => setDocumentTitle(e.target.value)}/>
                    </div>
                    <div>
                        <label>Марка, модель:</label>
                        <Input value={carModel} onChange={(e) => setCarModel(e.target.value)}/>
                    </div>
                    <div>
                        <label>VIN:</label>
                        <Input value={vin} onChange={(e) => setVin(e.target.value)}/>
                    </div>
                    <div>
                        <label>№ двигателя:</label>
                        <Input value={engineNumber} onChange={(e) => setEngineNumber(e.target.value)}/>
                    </div>
                    <div>
                        <label>Пробег на панели:</label>
                        <Input value={mileage} onChange={(e) => setMileage(e.target.value)}/>
                    </div>
                    <div className="input-block">
                        <label>Продавец:</label>
                        <Select>
                            <Select.Option>Собственник</Select.Option>
                            <Select.Option>Дилер</Select.Option>
                            <Select.Option>Посредник</Select.Option>
                            <Select.Option>Юр. лицо</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Кол-во владельцев по ПТС:</label>
                        <Input value={countOwners} onChange={(e) => setCountOwners(e.target.value)}/>
                    </div>
                    <div>
                        <label>Год выпуска:</label>
                        <Input value={year} onChange={(e) => setYear(e.target.value)}/>
                    </div>
                    <div>
                        <label>КПП:</label>
                        <Input value={gearBox} onChange={(e) => setGearBox(e.target.value)}/>
                    </div>
                    <div>
                        <label>Цвет:</label>
                        <Input value={color} onChange={(e) => setColor(e.target.value)}/>
                    </div>
                    <div>
                        <label>Кол-во ключей:</label>
                        <Input value={countKeys} onChange={(e) => SetCountKeys(e.target.value)}/>
                    </div>
                    <div className="input-block">
                        <label>Состояние салона:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Дефекты</Select.Option>
                            <Select.Option>Требуется химчистка</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Комментарий:</label>
                        <Input value={interriorComment} onChange={(e) => setInterriorComment(e.target.value)}/>
                    </div>
                </div>

                <div>
                    <h2>СОСТОЯНИЕ КУЗОВА</h2>
                    <div>
                        <label>Центр. стойка правая:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Толщина ЛКП:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Центр. стойка левая:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Толщина ЛКП:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Порог правый:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Толщина ЛКП:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Порог левый:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Толщина ЛКП:</label>
                        <Input/>
                    </div>
                    <div>
                        <label>Комментарий по сост. кузова:</label>
                        <Input/>
                    </div>
                </div>

                <div>
                    <h2>ОСТЕКЛЕНИЕ И СВЕТОВЫЕ ПРИБОРЫ</h2>
                    <div className="input-block">
                        <label>Стекла:</label>
                        <Select>
                            <Select.Option>Оригинал</Select.Option>
                            <Select.Option>Не оригинал</Select.Option>
                            <Select.Option>Треб. замены</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Фары/фонари:</label>
                        <Select>
                            <Select.Option>Оригинал</Select.Option>
                            <Select.Option>Не оригинал</Select.Option>
                            <Select.Option>Треб. замены</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Зеркала:</label>
                        <Select>
                            <Select.Option>Без повреждений</Select.Option>
                            <Select.Option>Повреждения</Select.Option>
                            <Select.Option>Треб. замены</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Комментарий по остеклению и свет. приборам:</label>
                        <Input value={glassComment} onChange={(e) => setGlassComment(e.target.value)}/>
                    </div>
                </div>

                <div>
                    <h2>ПОДКАПОТНОЕ ПРОСТРАНСТВО</h2>
                    <div className="input-block">
                        <label>Масло ДВС:</label>
                        <Select>
                            <Select.Option>Уровень</Select.Option>
                            <Select.Option>Не уровень</Select.Option>
                            <Select.Option>Эмульсия</Select.Option>
                            <Select.Option>Нагар</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Масло КПП:</label>
                        <Select>
                            <Select.Option>Уровень</Select.Option>
                            <Select.Option>Не уровень</Select.Option>
                            <Select.Option>Запах гари</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Антифриз:</label>
                        <Select>
                            <Select.Option>Уровень</Select.Option>
                            <Select.Option>Не уровень</Select.Option>
                            <Select.Option>Следы масла</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Тормозная жидкость:</label>
                        <Select>
                            <Select.Option>Уровень</Select.Option>
                            <Select.Option>Не уровень</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Жидкость ГУР:</label>
                        <Select>
                            <Select.Option>Уровень</Select.Option>
                            <Select.Option>Не уровень</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Комментарий:</label>
                        <Input value={engineSpaceComment} onChange={(e) => setEngineSpaceComment(e.target.value)}/>
                    </div>
                </div>
                
                <div>
                    <h2>СОСТОЯНИЕ КОЛЕС (ДИСКИ/РЕЗИНА)</h2>
                    <div>
                        <label>Год выпуска резины:</label>
                        <div className="flex">
                            <div>
                                <div>
                                    <label>П.п.</label>
                                    <Input/>
                                </div>
                                <div>
                                    <label>П.л.</label>
                                    <Input/>
                                </div>
                            </div>
                            
                            <div>
                                <div>
                                    <label>З.п.</label>
                                    <Input/>
                                </div>
                                <div>
                                    <label>З.л.</label>
                                    <Input/>
                                </div>
                            </div>
                        </div>
                        <div>
                            <label>Есть фото:</label>
                            <Checkbox/>
                        </div>
                    </div>
                    <div>
                        <label>Остаток резины в %:</label>
                        <div className="flex">
                            <div>
                                <div>
                                    <label>П.п.</label>
                                    <Input/>
                                </div>
                                <div>
                                    <label>П.л.</label>
                                    <Input/>
                                </div>
                            </div>
                            
                            <div>
                                <div>
                                    <label>З.п.</label>
                                    <Input/>
                                </div>
                                <div>
                                    <label>З.л.</label>
                                    <Input/>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div className="input-block">
                            <label>Второй комплект:</label>
                            <Select>
                                <Select.Option>Есть</Select.Option>
                                <Select.Option>Нет</Select.Option>
                            </Select>
                        </div>

                        <div>
                            <label>Есть фото:</label>
                            <Checkbox/>
                        </div>
                    </div>
                    <div>
                        <label>Комментарий:</label>
                        <Input value={wheelComplectComment} onChange={(e) => setWheelComplectComment(e.target.value)}/>
                    </div>
                </div>

                <div>
                    <h2>ОСМОТР НА ПОДЪЕМНИКЕ</h2>
                    <div className="input-block">
                        <label>Ступичные подшипники:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Амортизаторы, отбойники, пружины:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Рычаги подвески:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Стабилизатор/Втулки/Стойки</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Рулевые наконечники/тяги</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Рулевая рейка:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Поддон ДВС/Сальник КВ:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>КПП:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Замена</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Другие элементы:</label>
                        <Input value={otherElements} onChange={(e) => setOtherElements(e.target.value)}/>
                    </div>
                </div>
                
                <div>
                    <h2>ДИАГНОСТИКА ТЕХНИЧЕСКОГО СОСТОЯНИЯ</h2>

                    <div className="diagnostic-block">
                        <h3>1. Компьютерная диагностика/Ошибки</h3>
                        <div className="input-block">
                            <label>ДВС:</label>
                            <Select>
                                <Select.Option>Нет</Select.Option>
                                <Select.Option>Есть</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>АКПП/МКПП:</label>
                            <Select>
                                <Select.Option>Нет</Select.Option>
                                <Select.Option>Есть</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>ABS:</label>
                            <Select>
                                <Select.Option>Нет</Select.Option>
                                <Select.Option>Есть</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>AIRBAG:</label>
                            <Select>
                                <Select.Option>Нет</Select.Option>
                                <Select.Option>Есть</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Доп. блоки управления:</label>
                            <Select>
                                <Select.Option>Нет</Select.Option>
                                <Select.Option>Есть</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Соответствие пробега:</label>
                            <Select>
                                <Select.Option>Нет</Select.Option>
                                <Select.Option>Да</Select.Option>
                                <Select.Option>Не подтвержден</Select.Option>
                            </Select>
                        </div>
                        <div>
                            <label>Комментарий:</label>
                            <Input value={computerDiagnosticComment} onChange={(e) => setComputerDiagnosticComment(e.target.value)}/>
                        </div>
                    </div>

                    <div className="diagnostic-block">
                        <h3>2. Работа КПП</h3>
                        <div className="input-block">
                            <label>Переключение МКПП:</label>
                            <Select>
                                <Select.Option>Норма</Select.Option>
                                <Select.Option>Не норма</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Переключение при разгоне:</label>
                            <Select>
                                <Select.Option>Норма</Select.Option>
                                <Select.Option>Не норма</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Переключение при торможении:</label>
                            <Select>
                                <Select.Option>Норма</Select.Option>
                                <Select.Option>Не норма</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Переключение при езде накатом:</label>
                            <Select>
                                <Select.Option>Норма</Select.Option>
                                <Select.Option>Не норма</Select.Option>
                            </Select>
                        </div>
                        <div>
                            <label>Комментарий:</label>
                            <Input value={gearBoxComment} onChange={(e) => setGearBoxComment(e.target.value)}/>
                        </div>
                    </div>

                    <div className="diagnostic-block">
                        <h3>3. Подвеска и рулевое управление</h3>
                        <div className="input-block">
                            <label>Вибрации при движении:</label>
                            <Select>
                                <Select.Option>Да</Select.Option>
                                <Select.Option>Нет</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Вибрации при торможении:</label>
                            <Select>
                                <Select.Option>Да</Select.Option>
                                <Select.Option>Нет</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Посторонние звуки при движении:</label>
                            <Select>
                                <Select.Option>Да</Select.Option>
                                <Select.Option>Нет</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Посторонние звуки при проезде неровостей:</label>
                            <Select>
                                <Select.Option>Да</Select.Option>
                                <Select.Option>Нет</Select.Option>
                            </Select>
                        </div>
                        <div>
                            <label>Комментарий:</label>
                            <Input value={suspentionComment} onChange={(e) => setSuspentionComment(e.target.value)}/>
                        </div>
                    </div>

                    <div className="diagnostic-block">
                        <h3>4. Тормозная система</h3>
                        <div>
                            <label>Износ торозных колодок:</label>
                            <div className="flex">
                                <div>
                                    <div>
                                        <label>П.п.</label>
                                        <Input/>
                                    </div>
                                    <div>
                                        <label>П.л.</label>
                                        <Input/>
                                    </div>
                                </div>
                                
                                <div>
                                    <div>
                                        <label>З.п.</label>
                                        <Input/>
                                    </div>
                                    <div>
                                        <label>З.л.</label>
                                        <Input/>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div>
                            <label>Износ торозных дисков в %:</label>
                            <div className="flex">
                                <div>
                                    <div>
                                        <label>П.п.</label>
                                        <Input/>
                                    </div>
                                    <div>
                                        <label>П.л.</label>
                                        <Input/>
                                    </div>
                                </div>
                                
                                <div>
                                    <div>
                                        <label>З.п.</label>
                                        <Input/>
                                    </div>
                                    <div>
                                        <label>З.л.</label>
                                        <Input/>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div>
                            <label>Комментарий:</label>
                            <Input value={brakeSystemComment} onChange={(e) => setBrakeSystemComment(e.target.value)}/>
                        </div>
                    </div>

                    <div className="diagnostic-block">
                        <h3>5. Работа органов управления и световых приборов</h3>
                        <div>
                            <h4>Боковые зеркала</h4>
                            <div className="input-block">
                                <label>Складывания:</label>
                                <Select>
                                    <Select.Option>Норма</Select.Option>
                                    <Select.Option>Не норма</Select.Option>
                                </Select>
                            </div>
                            <div className="input-block">
                                <label>Регулировка:</label>
                                <Select>
                                    <Select.Option>Норма</Select.Option>
                                    <Select.Option>Не норма</Select.Option>
                                </Select>
                            </div>
                            <div className="input-block">
                                <label>Обогрев:</label>
                                <Select>
                                    <Select.Option>Норма</Select.Option>
                                    <Select.Option>Не норма</Select.Option>
                                </Select>
                            </div>
                        </div>
                        <div>
                            <h4>Обогрев</h4>
                            <div className="input-block">
                                <label>Сиденья:</label>
                                <Select>
                                    <Select.Option>Норма</Select.Option>
                                    <Select.Option>Не норма</Select.Option>
                                </Select>
                            </div>
                            <div className="input-block">
                                <label>Заднее стекло:</label>
                                <Select>
                                    <Select.Option>Норма</Select.Option>
                                    <Select.Option>Не норма</Select.Option>
                                </Select>
                            </div>
                            <div className="input-block">
                                <label>Лобовое стекло:</label>
                                <Select>
                                    <Select.Option>Норма</Select.Option>
                                    <Select.Option>Не норма</Select.Option>
                                </Select>
                            </div>
                        </div>
                        <div>
                            <label>Комментарий:</label>
                            <Input value={controlsOperationComment} onChange={(e) => setControlsOperationComment(e.target.value)}/>
                        </div>
                    </div>

                    <div className="diagnostic-block">
                        <h3>6. Полный привод</h3>
                        <div className="input-block">
                            <label>Проверка режимов:</label>
                            <Select>
                                <Select.Option>Норма</Select.Option>
                                <Select.Option>Не норма</Select.Option>
                            </Select>
                        </div>
                        <div className="input-block">
                            <label>Индикация на панели приборов:</label>
                            <Select>
                                <Select.Option>Есть</Select.Option>
                                <Select.Option>Мигает</Select.Option>
                                <Select.Option>Нет</Select.Option>
                            </Select>
                        </div>
                        <div>
                            <label>Комментарий:</label>
                            <Input value={awdComment} onChange={(e) => setAwdComment(e.target.value)}/>
                        </div>
                    </div>
                </div>

                <div>
                    <h2>ПУСК ДВИГАТЕЛЯ</h2>
                    <div className="input-block">
                        <label>Холодный пуск двигателя:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Затрудненный пуск:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Посторонние звуки:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Сильная вибрация:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Комментарий:</label>
                        <Input value={startEngineComment} onChange={(e) => setStartEngineComment(e.target.value)}/>
                    </div>
                </div>

                <div>
                    <h2>РАБОТА КОНДИЦИОНЕРА</h2>
                    <div className="input-block">
                        <label>Работа кондиционера "AC"</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Наличие фреона:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Состояние приводного ремня:</label>
                        <Select>
                            <Select.Option>Норма</Select.Option>
                            <Select.Option>Не норма</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Комментарий:</label>
                        <Input value={conditionerOperationComment} onChange={(e) => setConditionerOperationComment(e.target.value)}/>
                    </div>
                </div>

                <div>
                    <h2>ЮРИДИЧЕСКАЯ ПРОВЕРКА</h2>
                    <div className="input-block">
                        <label>Ограничения на регист. действия:</label>
                        <Select>
                            <Select.Option>Есть</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Предмет залога:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>VIN номер, № двигателя, VIN в блоке управления, номер рамы совпадает в документах:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Штрафы:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Участия в ДТП:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>Нахождение автомобиля в розыске:</label>
                        <Select>
                            <Select.Option>Да</Select.Option>
                            <Select.Option>Нет</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Комментарий:</label>
                        <Input value={legalCheckComment} onChange={(e) => setLegalCheckComment(e.target.value)}/>
                    </div>
                </div>

                <div>
                    <label>Тест-драйв:</label>
                    <Input value={testDrive} onChange={(e) => setTestDrive(e.target.value)}/>
                </div>

                <div>
                    <h2>РЕКОМЕНДАЦИИ СПЕЦИАЛИСТА</h2>
                    <div className="input-block">
                        <label>1) Привод ГРМ</label>
                        <Select>
                            <Select.Option>Замена</Select.Option>
                            <Select.Option>Контроль</Select.Option>
                        </Select>
                    </div>
                    <div className="input-block">
                        <label>2) Масло в ДВС, масляный фильтр:</label>
                        <Select>
                            <Select.Option>Замена</Select.Option>
                            <Select.Option>Контроль</Select.Option>
                        </Select>
                    </div>
                    <div>
                        <label>Проверка угла регулировки колес:</label>
                        <Input value={checkWheelsAngle} onChange={(e) => setCheckWheelsAngle(e.target.value)}/>
                    </div>
                    <div>
                        <label>Комментарий:</label>
                        <Input value={recommendationsComment} onChange={(e) => setRecommendationsComment(e.target.value)}/>
                    </div>
                </div>
            </div>
        </Modal>
    )
}