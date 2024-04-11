import { DocumentRequest } from "@/Contracts/Request";

export const GetAllDocuments = async() => {
    const response = await fetch("http://localhost:5000/Document");

    return response.json();
}

export const CreateNewDocument = async(document: DocumentRequest) => {
    await fetch("http://localhost:5000/Document", {
        method: "POST",
        headers: {
            "content-type": "application/json; charset=utf-8"
        },
        body: JSON.stringify(document)
    });
}

export const DeleteDocument = async(id: string) => {
    await fetch(`http://localhost:5000/Document/${id}`, {
        method: "DELETE"
    });
}