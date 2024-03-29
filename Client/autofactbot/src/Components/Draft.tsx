import { Content } from "antd/es/layout/layout"
import { Button, Card, Layout } from "antd"

interface Props {
    documents: Document[];
}

export const Draft = ({documents} : Props) => {
    return (
        <Layout>
            <Content>
                {documents.map((document: Document) => (
                    <Card key={document.id}>
                        <div>
                            <p>{document.description}</p>
                        </div>
                        <div>
                            <Button>Удалить</Button>
                            <Button>Редактировать</Button>
                        </div>
                    </Card>
                ))}
            </Content>
        </Layout>
    )
}