import { EngineSpaceList } from "./EngineSpaceList"
import { Button, Collapse, Form } from "antd"
import { WheelsList } from "./WheelsList"
import { GlassList } from "./GlassList"
import { MainList } from "./MainList"
import { BodyList } from "./BodyList"

const items = [
    { key: 1, label: 'Основное', children: <MainList /> },
    { key: 2, label: 'Кузов', children: <BodyList /> },
    { key: 3, label: 'Стёкла/оптика', children: <GlassList /> },
    { key: 4, label: 'Подкапотное пространство', children: <EngineSpaceList /> },
    { key: 5, label: 'Колёса', children: <WheelsList /> },
    { key: 6, label: 'Осмотр на подъёмнике', children: '' },
    { key: 7, label: 'Диагностика тех. состояния', children: '' },
    { key: 8, label: 'Пуск двигателя', children: '' },
    { key: 9, label: 'Работа кондиционера', children: '' },
    { key: 10, label: 'Юридическая проверка', children: '' },
    { key: 11, label: 'Рекомендации специалиста', children: '' },
  ]

export const Create = () => {
    return (
        <Form>
            <Collapse items={items}/>

            <div className="flex justify-center p-1">
                <Button className="m-2">Сохранить черновик</Button>
                <Button className="m-2">Создать</Button>
            </div>
        </Form>
    )
}