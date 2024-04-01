import { DocumentRequest } from "@/Contracts/Request";

export const GetAllDocuments = async() => {
    const response = await fetch("http://localhost:5069/Document");

    return response.json();
}

export const CreateNewDocument = async(document: DocumentRequest) => {
    const response = await fetch('http://localhost:5069/Document', {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify(document)
    });
}

export const DeleteDocument = async (id: string) => {
    await fetch(`http://localhost:5069/Document/${id}`, {
        method: "DELETE"
    });
}