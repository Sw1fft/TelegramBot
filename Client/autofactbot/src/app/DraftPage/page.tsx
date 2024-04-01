import { GetAllDocuments } from "@/Services/DocumentsService";
import { Drafts } from "@/Components/Drafts";
import { useEffect, useState } from "react";

export default function DraftPage() {
    const [documents, setDocuments] = useState<Document[]>([]);

    useEffect(() => {
        const getDocs = async() => {
            const documents = await GetAllDocuments();

            setDocuments(documents);
        };

        getDocs();
    }, []);

    return (
        <div>
            <Drafts documents={documents}/>
        </div>
    )
}