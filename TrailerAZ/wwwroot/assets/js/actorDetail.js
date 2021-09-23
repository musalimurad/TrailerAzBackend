'use strict'
//Responsive Header Hamburger
//var MenuContent = document.getElementById("Menu-content");
//$(document).ready(function () {
//  $(".navbar-button").click(function () {
//    $(".navbar-button").toggleClass("active");
//    if (MenuContent.style.opacity == 1 && MenuContent.style.visibility == "visible" && MenuContent.style.height == "100vh") {
//      MenuContent.style.opacity = 0;
//      MenuContent.style.visibility = "hidden";
//      MenuContent.style.height = "0vh";
//    } else {
//      MenuContent.style.opacity = 1;
//      MenuContent.style.visibility = "visible";
//      MenuContent.style.height = "100vh";
//    }
//  });
//});
// -------------------------------------------



//  serie starting  start

$('.all').slick({
  centerMode: true,
  centerPadding: '80px',
  slidesToShow: 4,
  autoplay: true,
  speed: 1000,
  arrows: false,
  infinite: true,
  dots: false,
  responsive: [{
      breakpoint: 769,
      settings: {
        arrows: false,
        dots: false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 2
      }
    },
    {
      breakpoint: 992,
      settings: {
        arrows: false,
        dots: false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 3
      }
    },

    {
      breakpoint: 430,
      settings: {
        arrows: false,
        dots: false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 1
      }
    }
  ]
});

//  serie start end

// up-arrow
$(document).ready(function () {
  $(window).scroll(function () {
    if ($(window).scrollTop() > 750) {
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