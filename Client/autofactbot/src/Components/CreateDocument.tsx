import { DocumentRequest } from "@/Contracts/Request";
import { useEffect, useState } from "react";
import { Input, Modal } from "antd";

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
    const [title, setDocumentTitle]     = useState<string>("");
    const [carModel, setCarModel]               = useState<string>("");
    const [vin, setVin]                         = useState<string>("");
    const [engineNumber, setEngineNumber]       = useState<string>("");
    const [mileage, setMileage]                 = useState<string>("");
    const [owner, setOwner]                     = useState<string>("");
    const [countOwners, setCountOwners]         = useState<string>("");
    const [year, setYear]                       = useState<string>("");
    const [gearBox, setGearBox]                 = useState<string>("");
    const [color, setColor]                     = useState<string>("");
    const [countKeys, SetCountKeys]             = useState<string>("");
    const [interior, setInterior]               = useState<string>("");

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
            interior
        };

        createHandle(documentRequest)
    };

    return (
        <Modal open={isOpenModal} onOk={handleOnOk} cancelText='Отменить' onCancel={closeHandle}>
            <div>
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
                <div>
                    <label>Продавец:</label>
                    <Input value={owner} onChange={(e) => setOwner(e.target.value)}/>
                    {/*<Select value={owner} options={[
                        {label: 'Собственник', value:'Собственник'},
                        {label: 'Дилер', value:'Дилер'},
                        {label: 'Посредник', value:'Посредник'},
                        {label: 'Юр. лицо', value:'Юр. лицо'}
                    ]} onChange={(e) => setOwner(e)}/>*/}
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
                <div>
                    <label>Состояние салона:</label>
                    <Input value={interior} onChange={(e) => setInterior(e.target.value)}/>
                    {/*<Select value={interior} options={[
                        {label: 'Норма', value: 'Норма'},
                        {label: 'Дефекты', value: 'Дефекты'},
                        {label: 'Требуется химчистка', value: 'Требуется химчистка'}
                    ]} onChange={(e) => setInterior(e)}/>*/}
                </div>
            </div>
        </Modal>
    )
}