import TextArea from "antd/es/input/TextArea"
import { List, Select } from "antd"

export const EngineSpaceList = () => {
    const motorOilOptions = [
        {label: 'Уровень', value: 'Уровень'},
        {label: 'Не уровень', value: 'Не уровень'},
        {label: 'Эмульсия', value: 'Эмульсия'},
        {label: 'Нагар', value: 'Нагар'}
    ]

    const gearOilOptions = [
        {label: 'Уровень', value: 'Уровень'},
        {label: 'Не уровень', value: 'Не уровень'},
        {label: 'Запах гари', value: 'Запах гари'}
    ]

    const antifreezOptions = [
        {label: 'Уровень', value: 'Уровень'},
        {label: 'Не уровень', value: 'Не уровень'},
        {label: 'Следы масла', value: 'Следы масла'}
    ]

    const brakeFluidOptions = [
        {label: 'Уровень', value: 'Уровень'},
        {label: 'Не уровень', value: 'Не уровень'}
    ]

    const gurFluidOptions = [
        {label: 'Уровень', value: 'Уровень'},
        {label: 'Не уровень', value: 'Не уровень'}
    ]

    const engineSpaceData = [
        {title: 'Масло ДВС', children: <Select options={motorOilOptions}/>},
        {title: 'Масло КПП', children: <Select options={gearOilOptions}/>},
        {title: 'Антифриз', children: <Select options={antifreezOptions}/>},
        {title: 'Тормозная жидкость', children: <Select options={brakeFluidOptions}/>},
        {title: 'Жидкость ГУР', children: <Select options={gurFluidOptions}/>},
        {title: 'Комментарий:', children: <TextArea />}
    ]

    return (
        <List dataSource={engineSpaceData} renderItem={(item) => (
            <List.Item>
                <label>{item.title}</label>
                <div>{item.children}</div>
            </List.Item>
        )}/>
    );
}