import TextArea from "antd/es/input/TextArea"
import { List, Select } from "antd"

export const GlassList = () => {
    const glassOptions = [
        {label: 'Оригинал', value: 'Оригинал'},
        {label: 'Не оригинал', value: 'Не оригинал'},
        {label: 'Требует замены', value: 'Требует замены'}
    ]

    const headlightsOptions = [
        {label: 'Оригинал', value: 'Оригинал'},
        {label: 'Не оригинал', value: 'Не оригинал'},
        {label: 'Требует замены', value: 'Требует замены'}
    ]

    const mirrorOptions = [
        {label: 'Без повреждений', value: 'Без повреждений'},
        {label: 'Повреждения', value: 'Повреждения'},
        {label: 'Требует замены', value: 'Требует замены'}
    ]

    const glassData = [
        {title: 'Стекла', children: <Select className="w-full" options={glassOptions}/>},
        {title: 'Фары/фонари', children: <Select options={headlightsOptions}/>},
        {title: 'Зеркала', children: <Select options={mirrorOptions}/>},
        {title: 'Комментарий:', children: <TextArea />}
    ]

    return (
        <List dataSource={glassData} renderItem={(item) => (
            <List.Item>
                <label>{item.title}</label>
                <div style={{width: '50%'}}>{item.children}</div>
            </List.Item>
        )}/>
    );
}