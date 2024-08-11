// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var webSocket;
let missileNames = [];
let missilesData = []
let missiairData = []
let time;
function connect() {
    // החיבור לאיזה סוקט להתחבר 
    webSocket = new WebSocket('ws://localhost:5064/');

    webSocket.onmessage = function (event) {
        var responseElement = document.getElementById('time');
        var message = event.data;
        console.log(message + "7787878787")
        

        //if (message.includes("fell")) {
        //    var responseElement = document.getElementById()
        //    responseElement.innerHTML += message + '<br>'
        //    responseElement.remove()

        //    if (missileElement) {
        //        responseElement.remove(); // הסרת הטיל שנפל
        //    }
        //} else {
        //    // עדכון או הוספת מידע אחר
        //}

       
        //processMessage(message);

       
        
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

function readJsonFile() {

        fetch('/json/json11.json')
        .then(response => response.json())
            .then(data => {
                // יצירת אובייקט חדש עם חלק מהמידע
                missilesData = data.Missiles; 
                var jsonMessage = JSON.stringify(data, null, 4);
                         
              
                var responseElement = document.getElementById('response');
                //responseElement.innerText = 'Received from : file json' + jsonMessage;
            //sendMessage(jsonMessage);
            console.log(jsonMessage)
        })
        .catch(error => console.error('Error reading JSON file:', error));
}
function addMissileName() {
    if (missilesData.length > 0) {
        let responseElement = document.getElementById('response');
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



function displayMissileNames() {
    let interval = setInterval(function () {
        let responseElement = document.getElementById('response');
        let airElement = document.getElementById('air');
        let missileNamesText = ''; // משתנה לאחסון הטקסט להצגה

        for (let missile of missilesData) {
            if (time > 0) {
                // הוספת שם הטיל והזמן הנותר למשתנה המחרוזת
                missileNamesText += missile.name + ' - Time left: ' + time + 's<br>';
            }
        }

        // עדכון התצוגה של הדיב עם כל השמות והזמנים
        responseElement.innerHTML = 'Missile Names:<br>' + missileNamesText;

        if (time <= 0) {
            // העברת השמות של הטילים לדיב השני כאשר הזמן נגמר
            airElement.innerHTML = 'Air Missile: ' + missileNamesText;
            responseElement.innerHTML = '';
            clearInterval(interval);
        }

        time -= 1; // הורדת השנייה מהזמן בכל איטרציה

    }, 1000);
}


function displayMissileair(name) {
    let responseElement = document.getElementById('air');
   
    responseElement.innerText = 'Missile : ' + name.join(', ');
}

function sendMessage(message) {
    var jsonMessage = JSON.stringify(message, null, 4);
    //var message = document.getElementById('message').value;
    if (webSocket) {
        webSocket.send(jsonMessage);
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
