import { Content, Header } from "antd/es/layout/layout";
import { Layout } from "antd";

export default function Home() {
  return (
    <main className="min-h-screen p-1">
      <Layout>
        <Header></Header>
        <Content></Content>
      </Layout>
    </main>
  );
}
