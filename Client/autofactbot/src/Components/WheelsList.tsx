import { List, Select } from "antd"

export const WheelsList = () => {
    const wheelsOptions = [
        {label: 'Есть', value: 'Есть'},
        {label: 'Нет', value: 'Нет'}
    ]

    const wheelsData = [
        {title: 'Год выпуска резины', children: ''},
        {title: 'Остаток резины в %', children: ''},
        {title: 'Второй комплект', children: <Select options={wheelsOptions}/>}
    ]

    return (
        <List dataSource={wheelsData} renderItem={(item) => (
            <List.Item>
                <label>{item.title}</label>
                <div>{item.children}</div>
            </List.Item>
        )}/>
    )
}