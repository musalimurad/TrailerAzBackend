////$(window).on('load', function () {
////    setTimeout(function () { // allowing 3 secs to fade out loader
////        $('.page-loader').fadeOut('slow');
////    }, 3500);
////});
//Responsive Header Hamburger
var MenuContent = document.getElementById("Menu-content");
$(document).ready(function () {
    $(".navbar-button").click(function () {
        $(this).toggleClass("active");
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
// new film start

function toggle() {
    var video = document.querySelector(".tag-video")
    var exit = document.querySelector("iframe")
    video.classList.toggle("active");
    exit.currentTime = 0;
    var videos = $("#playerid").attr("src");
    $("#playerid").attr("src", "");
    $("#playerid").attr("src", videos);
}

// up-arrow
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(window).scrollTop() > 350) {
            $('#up-arrow').css('opacity', '1')
            $('#up-arrow').css('visibility', 'visible')
        } else {
            $('#up-arrow').css('opacity', '0')
            $('#up-arrow').css('visibility', 'hidden')

        }
    });
    $('#up-arrow').click(function () {
        $('html , body').animate({
            scrollTop: 0
        }, 1500)
    })
});
  // up-arrow


//(function () {
//    $('.flex-container').waitForImages(function () {
//        $('.spinner').fadeOut();
//    }, $.noop, true);

//    $(".flex-slide").each(function () {
//        $(this).hover(function () {
//            $(this).find('.flex-title').css({
//                transform: 'rotate(0deg)',
//                top: '10%'
//            });
//            $(this).find('.flex-about').css({
//                opacity: '1'
//            });
//        }, function () {
//            $(this).find('.flex-title').css({
//                transform: 'rotate(90deg)',
//                top: '15%'
//            });
//            $(this).find('.flex-about').css({
//                opacity: '0'
//            });
//        })
//    });
//})();

//$(window).on('load', function () {
//    setTimeout(function () { // allowing 3 secs to fade out loader
//        $('.page-loader').fadeOut('slow');
//    }, 3500);
//});


