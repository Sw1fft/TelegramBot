import { CreateNewDocument } from "@/Services/DocumentsService";
import { CreateDocument } from "@/Components/CreateDocument";
import { DocumentRequest } from "@/Contracts/Request";
import { useState } from "react"
import { Button } from "antd"

export default function CreateDocumentPage() {
    const defaultValues = {
        title:                          "",
        carModel:                       "",
        vin:                            "",
        engineNumber:                   "",
        mileage:                        "",
        owner:                          "",
        countOwners:                    "",
        year:                           "",
        gearBox:                        "",
        color:                          "",
        countKeys:                      "",
        interior:                       "",
        interriorComment:               "",
        centrRightStand:                "",
        centrRightStandThickness:       "",
        centrLeftStand:                 "",
        centrLeftStandThickness:        "",
        thresholdRight:                 "",
        thresholdRightThickness:        "",
        thresholdLeft:                  "",
        thresholdLeftThickness:         "",
        bodyComment:                    "",
        glasses:                        "",
        headlights:                     "",
        mirrors:                        "",
        glassComment:                   "",
        engineOil:                      "",
        gearBoxOil:                     "",
        antifreeze:                     "",
        brakeFluid:                     "",
        steeringFluid:                  "",
        engineSpaceComment:             "",
        yearTire:                       "",
        remainingTire:                  "",
        secondComplect:                 "",
        wheelComplectComment:           "",
        wheelBearings:                  "",
        shockAbsorbers:                 "",
        suspensionArms:                 "",
        stabilizer:                     "",
        steeringTips:                   "",
        steeringRack:                   "",
        engineSump:                     "",
        gearBoxSound:                   "",
        otherElements:                  "",
        engineError:                    "",
        gearBoxError:                   "",
        absError:                       "",
        airbagError:                    "",
        addControlUnits:                "",
        mileageCompliance:              "",
        computerDiagnosticComment:      "",
        gearBoxShifts:                  "",
        gearBoxShiftsAcceleration:      "",
        gearBoxShiftsBreaking:          "",
        gearBoxShiftsCoasting:          "",
        gearBoxComment:                 "",
        vibrationsDriving:              "",
        vibrationsBreaking:             "",
        soundsDriving:                  "",
        soundsDrivingBumps:             "",
        suspentionComment:              "",
        brakePadWear:                   "",
        brakeDiskWear:                  "",
        brakeSystemComment:             "",
        folding:                        "",
        adjustment:                     "",
        heating:                        "",
        seatHeating:                    "",
        rearWindowHeating:              "",
        windshieldHeating:              "",
        controlsOperationComment:       "",
        checkingModes:                  "",
        panelIndication:                "",
        awdComment:                     "",
        coldStartEngine:                "",
        difficultStartEngine:           "",
        otherSounds:                    "",
        strongVibration:                "",
        startEngineComment:             "",
        compressorOperation:            "",
        freonAvailability:              "",
        driveBeltCondition:             "",
        conditionerOperationComment:    "",
        restrictions:                   "",
        subjectСollateral:              "",
        fines:                          "",
        accidentArticipation:           "",
        carWanted:                      "",
        vinNumberMatch:                 "",
        legalCheckComment:              "",
        testDrive:                      "",
        timingDrive:                    "",
        engineOilAndFilter:             "",
        checkWheelsAngle:               "",
        recommendationsComment:         ""
    } as Document;

    const [values, setValues] = useState<Document>(defaultValues);
    const [isOpenModal, setIsOpenModal] = useState(false);

    const OpenModal = () => {
        setIsOpenModal(true);
    };

    const HandleCreate = async(request: DocumentRequest) => {
        CreateNewDocument(request);
        CloseModal();
    };

    const CloseModal = () => {
        setValues(defaultValues);
        setIsOpenModal(false);
    };

    return (
        <div>
            <div className="flex justify-center p-1">
                <Button className="m-2" onClick={OpenModal}>Создать документ</Button>

                <CreateDocument values={values} isOpenModal={isOpenModal} createHandle={HandleCreate} closeHandle={CloseModal}/>
            </div>
        </div>
    )
}