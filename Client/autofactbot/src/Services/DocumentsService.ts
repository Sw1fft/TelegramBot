export const GetAllDocuments = async() => {
    const response = await fetch("http://localhost:..../Document");

    return response.json();
}

export const CreateDocument = async(document: Request) => {
    await fetch("http://localhost:..../Document", {
        method: "POST",
        headers: {
            "content-type": "application/json"
        },
        body: JSON.stringify(document)
    });
}

export const DeleteDocument = async (id: string) => {
    await fetch(`http://localhost:/Document/${id}`, {
        method: "DELETE"
    });
}