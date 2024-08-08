const getAllUsersBtn = document.getElementById("showUsersBtn");
const getUserBtn = document.getElementById("userIdBtn");
const inputId = document.getElementById("userIdInput");
const resultList = document.getElementById("result");

let port = "7094"
let serverUrl = "https://localhost:" + port + "/api/users";

let getAllUsers = async () => {
    let response = await fetch(serverUrl);
    let data = await response.json();

    for (let i = 0; i < data.length; i++) {
        let li = document.createElement("li");
        li.innerText = `${data[i].firstName} ${data[i].lastName}`;
        resultList.appendChild(li);
    }
}

let getUserById = (userId) => {
    fetch(serverUrl + `/user/${userId}`)
        .then((response) => {
            if (response.ok) {
                return response.json();
            }
            throw new Error(`The user with id: ${userId} does not exist!`);
        })
        .then((data) => {
            console.log(data);
            resultList.innerHTML = `<p>${userId}. ${data.firstName} ${data.lastName}</p>`;
        })
        .catch((error) => {
            console.log(error)
            resultList.innerHTML = error;
        })
}

getAllUsersBtn.addEventListener('click', () => {
    resultList.innerHTML = "";
    getAllUsers();
});

getUserBtn.addEventListener('click', () => {
    let userInput = inputId.value;
    getUserById(userInput);
    userInput = " ";
})


