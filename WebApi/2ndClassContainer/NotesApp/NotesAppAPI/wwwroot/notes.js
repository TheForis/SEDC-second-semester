let getAllNotesBtn = document.getElementById("btn1");
let notesList = document.getElementById("notes");
let input = document.getElementById("noteValue");
let addNoteBtn = document.getElementById("btn2");

let port = "7060";
let getAllNotes = async ()=>{
    let url = "https://localhost:" + port + "/api/notes"
    let response = await fetch(url);
    console.log(response);
    let data = await response.json();
    console.log(data);
    for (let i = 0; i < data.length; i++) {
        let li = document.createElement("li");
        li.innerText = data[i];
        notesList.appendChild(li);
    }
}

getAllNotesBtn.addEventListener('click', () => {
    notesList.innerHTML = "";
    getAllNotes();
})



let addNote = async () => {
    let url = "https://localhost:" + port + "/api/notes";

    let response = await fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "text/plain"
        },
        body: input.value
    });

    let data = await response.text();
    console.log(data);

};

addNoteBtn.addEventListener('click', () => {
    addNote();
    input.value = ""
});