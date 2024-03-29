'use client'
import { Content, Footer, Header } from "antd/es/layout/layout";
import { GetAllDocuments } from "@/Services/DocumentsService";
import { Create } from "@/Components/Create";
import { useEffect, useState } from "react";
import { Image, Layout, Menu } from "antd";
import { Draft } from "@/Components/Draft";

export default function Home() {
  const [isCreateAction, setIsCreateAction] = useState(false);
  const [documents, setDocuments] = useState<Document[]>([]);

  useEffect(() => {
    const getBooks = async () => {
        const books = await GetAllDocuments();
        setIsCreateAction(true);
        setDocuments(documents);
    };

    getBooks();
}, []);

  const CreateDocument = async() => {
    setIsCreateAction(true);
  }

  const DraftDocument = async() => {
    setIsCreateAction(false);
  }

  const menuItems = [
    {key: 1, label: <nav onClick={CreateDocument}>Создать документ</nav>},
    {key: 2, label: <nav onClick={DraftDocument}>Черновики</nav>}
  ]

  return (
    <main className="min-h-screen p-1">
      <Layout>
        <Header className="flex items-center justify-between">
          <div className="flex bg-white p-1">
            <Image src="/next.svg" width={100} alt="logo"/>
          </div>
          <Menu items={menuItems} mode="horizontal" theme="dark"/>
        </Header>
        <Content>
          {
            isCreateAction ? (<Create />) : (<Draft documents={documents} />)
          }
        </Content>
        <Footer className="text-center">
          Ant Design ©{new Date().getFullYear()}
          <br />
          Created by Vadim Bogdanov
        </Footer>
      </Layout>
    </main>
  );
}
