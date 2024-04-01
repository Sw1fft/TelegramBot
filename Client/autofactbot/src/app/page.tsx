"use client"
import CreateDocumentPage from "./CreateDocumentPage/page";
import { MenuOutlined } from "@ant-design/icons";
import { Dropdown, MenuProps } from "antd";
import DraftPage from "./DraftPage/page";
import { useState } from "react";

export default function Home() {
  const [isPage, setIsPage] = useState(false);
  
  const openDraftsPage = () => {
    setIsPage(true);
  }

  const closeDraftsPage = () => {
    setIsPage(false);
  }

  const items: MenuProps['items'] = [
    {key: 'create_page', label: <div onClick={closeDraftsPage}>Создать документ</div>},
    {key: 'drafts_page', label: <div onClick={openDraftsPage}>Черновики</div>},
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
                <MenuOutlined style={{width: '64px'}} />
              </Dropdown>
            </div>
          </div>
        </header>
        <div className="min-h-screen pt-2">
          {isPage ? <DraftPage /> : <CreateDocumentPage />}
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
