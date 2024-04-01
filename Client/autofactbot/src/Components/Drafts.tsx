import { Button, Card } from "antd";

interface Props {
    documents: Document[];
}

export const Drafts = ({documents}: Props) => {
    return (
        <div>{documents.map((doc: Document) => (
            <Card key={doc.id} title={doc.title} bordered={false}>
                <p>Card test</p>
                <div>
                    <Button>Удалить</Button>
                    <Button>Редактировать</Button>
                </div>
            </Card>
        ))}</div>
    )
}