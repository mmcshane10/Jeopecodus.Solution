// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/gameHub")
    .build();

connection.start().catch(err => console.error(err.toString()));

connection.on('Send', (teamName, message) => {
    appendLine(teamName, message);
});

document.getElementById('frm-send-message').addEventListener('submit', event => {
    let message = $('#message').val();
    let teamName = $('#spn-teamName').text();

    $('#message').val('');

    connection.invoke('Send', teamName, message);
    event.preventDefault();
});

function appendLine(teamName, message, color) {
    let nameElement = document.createElement('strong');
    nameElement.innerText = `${teamName}:`;

    let msgElement = document.createElement('em');
    msgElement.innerText = ` ${message}`;

    let li = document.createElement('li');
    li.appendChild(nameElement);
    li.appendChild(msgElement);

    $('#messages').append(li);
};

function continueToGameHub() {
    $('#spn-teamName').text($('#teamName').val());
    $('#entrance').hide();
    $('#chat').show();
}