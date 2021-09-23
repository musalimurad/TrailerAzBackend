'use strict'

//$(window).on('load',function(){
//	setTimeout(function(){ // allowing 3 secs to fade out loader
//	$('.page-loader').fadeOut('slow');
//	},3500);
//});

////Responsive Header Hamburger
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



// tv filter start
function startSearch() {
  // get main elements
  const search = document.querySelector(".search");
  const input = search.querySelector("input");
  const label = search.querySelector("label");
  const btnListen = search.querySelector("#dictate");
  const btnSearch = search.querySelector("#search");
  let listening = false;
  var SpeechRecognition = SpeechRecognition || webkitSpeechRecognition;

  // if there's speech recognition, show the microphone
  if (SpeechRecognition) {
    setTimeout(function () {
      btnListen.classList.add("show");
      label.querySelector("span").classList.add("show");
    }, 1000);
  }

  // show/hide placeholder
  input.addEventListener("input", function () {
    if (this.value.length === 0) {
      label.classList.remove("a11y-hidden");
    } else {
      label.classList.add("a11y-hidden");
    }
  });

  // listen to speech
  btnListen.addEventListener("click", function () {
    if (!listening) {
      const recognition = new SpeechRecognition();

      recognition.onstart = function () {
        btnListen.classList.add("active");
        listening = true;
      };

      recognition.onspeechend = function () {
        recognition.stop();
        btnListen.classList.remove("active");
        listening = false;
      }

      recognition.onerror = function () {
        btnListen.classList.remove("active");
        listening = false;
      }

      recognition.onresult = function (event) {
        const transcript = event.results[0][0].transcript;
        const confidence = event.results[0][0].confidence;

        input.value = transcript;
        input.focus();
        if (transcript.length > 0) {
          label.classList.add("a11y-hidden");
        }
      }

      recognition.start();
    }
  })
}

startSearch();

//   filter end


// video slider start

$('.video-slider').slick({
  // infinite: true,
  // autoplay: true,
  centerMode: true,
  arrows: true,
  centerPadding: '70px',
  variableWidth: true,
  dots: false,
  autoplay: true,
  speed: 500,

  slidesToShow: 5,
  responsive: [{
      breakpoint: 1000,
      settings: {
        infinite: true,
        autoplay: true,
        arrows: false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 3,
        variableWidth: true
      }
    },
    {
      breakpoint: 500,
      settings: {
        infinite: true,
        autoplay: true,
        dots: true,
        arrows: false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 1,
        variableWidth: false
      }
    }
  ]

});

// active slider

function toggle() {
  var video = document.querySelector(".tag-video")
  var exit = document.querySelector("iframe")
  video.classList.toggle("active");
  exit.currentTime = 0;
  var videos = $("#playerid").attr("src");
  $("#playerid").attr("src", "");
  $("#playerid").attr("src", videos);
}




//  slider trending   start

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