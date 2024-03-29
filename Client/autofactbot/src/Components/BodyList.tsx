import { Image, List } from "antd";

export const BodyList = () => {
    const bodyData = [
        {title: '', children: <Image src="/schema.jpg"/>},
        {title: '', children: ''},
        {title: '', children: ''},
        {title: '', children: ''},
        {title: '', children: ''},
    ]

    return (
        <List dataSource={bodyData} renderItem={(item) => (
            <List.Item>
                <label>{item.title}</label>
                <div>{item.children}</div>
            </List.Item>
        )}/>
    );
}