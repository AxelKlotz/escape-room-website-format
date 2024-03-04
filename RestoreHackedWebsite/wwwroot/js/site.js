// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function OverlayCheck(check) {
    if (check == 1) {
    document.getElementById("overlay").style.display = "none";
    console.log("overlay off from js");
    }
    else if (check == 0){
    document.getElementById("overlay").style.display = "block";
    console.log("overlay on from js");
    }
}
function ShowStartPuzzle() {
    document.getElementById("StartPuzzleContainer").style.display = "inline-grid";
    console.log("start puzzle shown");
}
let startPuzzleCheck = 1;
function SolveStartPuzzle(btnId) {
    if (btnId == startPuzzleCheck && startPuzzleCheck == 9) {
        document.getElementById("StartCloseBtn").disabled = false;
        document.getElementById("StartPuzzleContainer").style.display = "none"; //hide buttons
        console.log("Start puzzle solved")
        const circles = document.querySelectorAll('.plup');
        circles.forEach(circle => {
            circle.style.backgroundColor = 'green';
        });
        return;
    }
    else if (btnId == startPuzzleCheck) {
        document.getElementById("plup" + startPuzzleCheck.toString()).style.display = "inline-grid";
        console.log("correct button pressed: " + startPuzzleCheck)
        startPuzzleCheck = startPuzzleCheck + 1;
    }
    else {
        startPuzzleCheck = 1;
        //hide all plups
        const circles = document.querySelectorAll('.plup');
        circles.forEach(circle => {
            circle.style.display = 'none';
        });
        console.log("wrong button. puzzle reset")
    }
}
function ClearCookieWindow(check) {
    if (check == 1) {
        //Remove cookie window
        document.getElementById("CookieFooter").style.display = 'none';
        console.log("cookies hidden");
    }
    else if (check == 0) {
        //Nothing happends. Hint for solution?
        document.getElementById("HiddenCookieText").style.color = 'mediumslateblue';
    }
}
function ClickCookieLink(link) {
    link.style.color = 'lightblue';
    link.style.cursor = 'pointer';
    console.log("Link clicked");
}
function enableBtn() {
    const input = document.getElementById("CookieInput");
    const btn = document.getElementById("CookieBtn");
    if (input.value.trim() !== '') {
        btn.disabled = false;
    } else {
        btn.disabled = true;
    }
}
const AcceptCookies = document.getElementById('Cookie-Accept');
AcceptCookies.addEventListener("click", function() {
    ClickCookieLink(AcceptCookies);
});
const DenyCookies = document.getElementById('Cookie-Reject');
DenyCookies.addEventListener("click", function() {
    ClickCookieLink(DenyCookies);
});
AcceptCookies.addEventListener("pointerleave", function () {
    AcceptCookies.style.color = 'blue';
});
DenyCookies.addEventListener("pointerleave", function () {
    DenyCookies.style.color = 'blue';
});
document.addEventListener('keydown', function (event) {
    if (event.altKey && event.ctrlKey && event.key === 'y') {
        document.getElementById("CookiePuzzleContainer").style.display = 'inline-grid';
        console.log("cookie puzzle shown");
    }
});