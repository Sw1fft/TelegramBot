import { DatePicker, Input, InputNumber, List, Select } from "antd"

const ownerOptions = [
    {label: 'Норма', value: 'Норма'},
    {label: 'Дефекты', value: 'Дефекты'},
    {label: 'Требуется химчистка', value: 'Требуется химчистка'}
]

export const mainData = [
    {title: 'Марка, модель:', children: <Input />},
    {title: 'VIN:', children: <Input />},
    {title: '№ двигателя:', children: <Input />},
    {title: 'Пробег на панели:', children: <InputNumber />},
    {title: 'Продавец:', children: <Select options={ownerOptions}/>},
    {title: 'Кол-во владельцев по ПТС:', children: <Input />},
    {title: 'Год выпуска:', children: <DatePicker picker="year"/>},
    {title: 'КПП:', children: <Input />},
    {title: 'Цвет:', children: <Input />},
    {title: 'Кол-во ключей:', children: <Input />},
    {title: 'Состояние салона:', children: <Select />}
]

export const MainList = () => {
    return (
        <List dataSource={mainData} renderItem={(item) => (
            <List.Item>
                <label>{item.title}</label>
                <div>{item.children}</div>
            </List.Item>
        )}/>
    )
}