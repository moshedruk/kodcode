// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var webSocket;
let missileNames = [];
let missilesData = []
let missiairData = []
let time;

function connect() {
    webSocket = new WebSocket('ws://localhost:3108/MissileHandler');

    webSocket.onmessage = function (event) {
        var responseElement = document.getElementById('response');
        var message = event.data;
        console.log(message)

        // כאן תוכל לבצע כל מיני פעולות על ההודעה שמתקבלת
        processMessage(message);

        // הצגת ההודעה ב-HTML
        responseElement.innerText = 'Received from server: ' + message;
    };

    webSocket.onopen = function () {
        console.log('WebSocket connection established');
    };

    webSocket.onclose = function () {
        console.log('WebSocket connection closed');
    };

    webSocket.onerror = function (error) {
        console.error('WebSocket error:', error);
    };
}
function sendJsonFile() {

    fetch('/json/json1.json')
        .then(response => response.json())
        .then(data => {            
            missilesData = data;
            
           
            //var jsonMessage = JSON.stringify(data);
            
            //sendMessage(jsonMessage);
            console.log(jsonMessage)
        })
        .catch(error => console.error('Error reading JSON file:', error));
}
function addMissileName() {
    if (missilesData.length > 0) {
        let responseElement = document.getElementById('responsemissile');
        responseElement.innerHTML = 'שמות טילים:<br>';

        missilesData.forEach((missile, index) => {
            let timeLeft = missile.time;
            let missileElement = document.createElement('div');
            missileElement.id = 'missile-' + index;
            missileElement.innerHTML = missile.name + ' - זמן שנותר: ' + timeLeft + ' שניות<br>';
            responseElement.appendChild(missileElement);

            let interval = setInterval(() => {
                timeLeft -= 1;
                if (timeLeft > 0) {
                    missileElement.innerHTML = missile.name + ' - זמן שנותר: ' + timeLeft + ' שניות<br>';
                } else {
                    clearInterval(interval);
                    

                    missileElement.remove();

                    let airElement = document.getElementById('air');
                    let newDiv = document.createElement('div');
                    newDiv.id = `${missile.name}`
                    newDiv.innerHTML = missile.name + '  .<br>';

                    airElement.appendChild(newDiv);


                    missilesData.splice(index, 1);
                    // קריאה לטיל
                    sendMessage(missile)
                }
            }, 1000);
        });

    } else {
        console.log("אין עוד טילים להוסיף.");
    }
}


function sendMessage(datamessege) {
    //var message = document.getElementById('message').value;
    if (webSocket) {
        webSocket.send(JSON.stringify(datamessege));
    } else {
        alert('WebSocket connection is not established.');
    }
}

function processMessage(message) {
    // כאן תוכל לעבד את ההודעה לפי הצורך
    // לדוגמה, תוכל לבצע parsing להודעה אם היא בפורמט JSON
    try {
        var jsonObject = JSON.parse(message);
        console.log('Parsed message:', jsonObject);

        // דוגמה לעיבוד הודעה
        if (jsonObject.type === 'update') {
            console.log('Received an update message');
        } else if (jsonObject.type === 'alert') {
            console.log('Received an alert message');
        }
    } catch (error) {
        console.log('Message is not in JSON format');
    }
}

document.addEventListener("DOMContentLoaded", function () {
    connect(); // Connect to WebSocket when page loads
});
