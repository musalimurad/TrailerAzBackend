'use strict'

//Responsive Header Hamburger
var MenuContent = document.getElementById("Menu-content");
$(document).ready(function () {
    $(".navbar-button").click(function () {
        $(".navbar-button").toggleClass("active");
        if (MenuContent.style.opacity == 1 && MenuContent.style.visibility == "visible" && MenuContent.style.height == "100vh") {
            MenuContent.style.opacity = 0;
            MenuContent.style.visibility = "hidden";
            MenuContent.style.height = "0vh";
        } else {
            MenuContent.style.opacity = 1;
            MenuContent.style.visibility = "visible";
            MenuContent.style.height = "100vh";
        }
    });
});
// -------------------------------------------