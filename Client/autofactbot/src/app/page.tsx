'use client'
import { GetAllDocuments } from "@/Services/DocumentsService";
import { MenuOutlined } from "@ant-design/icons";
import { Create } from "@/Components/Create";
import { useEffect, useState } from "react";
import { Dropdown, MenuProps } from "antd";
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

  const items: MenuProps['items'] = [
    {key: '1', label: (<div onClick={CreateDocument}>Создать документ</div>)},
    {key: 'draft', label: <div onClick={DraftDocument}>Черновики</div>},
  ]

  return (
    <main>
      <div className="p-1">
        <header className="p-1 rounded-md" style={{backgroundColor: 'rgb(3,105,161)'}}>
          <div className="flex justify-between items-center sm:px-10">
            <div>
              <img src="/logo.png" alt="logo" width={200}/>
            </div>
            <div>
              <Dropdown menu={{items}} className="flex size-10 items-center justify-center">
                <MenuOutlined style={{width: '64px'}}/>
              </Dropdown>
            </div>
          </div>
        </header>
        <div className="min-h-screen pt-2">
          {
            isCreateAction ? (<Create />) : (<Draft documents={documents} />)
          }
        </div>
        <footer className="text-center">
          Ant Design ©{new Date().getFullYear()}
          <br />
          Created by Vadim Bogdanov
        </footer>
      </div>
    </main>
  );
}
