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


// home slider start

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


(function () {
  document.addEventListener("mousemove", pluginOne);
  const element = document.querySelector("#PluginOne");

  function pluginOne(e) {
    let w = window.innerWidth / 2;
    let h = window.innerHeight / 2;
    let mouseX = e.clientX;
    let mouseY = e.clientY;
    let depth1 = `${50-(mouseX-w)*0.8}% ${50-(mouseY-h)*0.8}%`;
    let depth2 = `${50-(mouseX-w)*0.12}% ${50-(mouseY-h)*0.12}%`;
    let depth3 = `${50-(mouseX-w)*0.14}% ${50-(mouseY-h)*0.14}%`;

    let x = `${depth3}, ${depth2}, ${depth1}`;
    element.style.backgroundPosition = x;

  }
})();

// home slider end

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


// new film end

// Slider start


(function () {

  var $$ = function (selector, context) {
    var context = context || document;
    var elements = context.querySelectorAll(selector);
    return [].slice.call(elements);
  };

  function _fncSliderInit($slider, options) {
    var prefix = ".fnc-";

    var $slider = $slider;
    var $slidesCont = $slider.querySelector(prefix + "slider__slides");
    var $slides = $$(prefix + "slide", $slider);
    var $controls = $$(prefix + "nav__control", $slider);
    var $controlsBgs = $$(prefix + "nav__bg", $slider);
    var $progressAS = $$(prefix + "nav__control-progress", $slider);

    var numOfSlides = $slides.length;
    var curSlide = 1;
    var sliding = false;
    var slidingAT = +parseFloat(getComputedStyle($slidesCont)["transition-duration"]) * 1000;
    var slidingDelay = +parseFloat(getComputedStyle($slidesCont)["transition-delay"]) * 1000;

    var autoSlidingActive = false;
    var autoSlidingTO;
    var autoSlidingDelay = 5000; // default autosliding delay value
    var autoSlidingBlocked = false;

    var $activeSlide;
    var $activeControlsBg;
    var $prevControl;

    function setIDs() {
      $slides.forEach(function ($slide, index) {
        $slide.classList.add("fnc-slide-" + (index + 1));
      });

      $controls.forEach(function ($control, index) {
        $control.setAttribute("data-slide", index + 1);
        $control.classList.add("fnc-nav__control-" + (index + 1));
      });

      $controlsBgs.forEach(function ($bg, index) {
        $bg.classList.add("fnc-nav__bg-" + (index + 1));
      });
    };

    setIDs();

    function afterSlidingHandler() {
      $slider.querySelector(".m--previous-slide").classList.remove("m--active-slide", "m--previous-slide");
      $slider.querySelector(".m--previous-nav-bg").classList.remove("m--active-nav-bg", "m--previous-nav-bg");

      $activeSlide.classList.remove("m--before-sliding");
      $activeControlsBg.classList.remove("m--nav-bg-before");
      $prevControl.classList.remove("m--prev-control");
      $prevControl.classList.add("m--reset-progress");
      var triggerLayout = $prevControl.offsetTop;
      $prevControl.classList.remove("m--reset-progress");

      sliding = false;
      var layoutTrigger = $slider.offsetTop;

      if (autoSlidingActive && !autoSlidingBlocked) {
        setAutoslidingTO();
      }
    };

    function performSliding(slideID) {
      if (sliding) return;
      sliding = true;
      window.clearTimeout(autoSlidingTO);
      curSlide = slideID;

      $prevControl = $slider.querySelector(".m--active-control");
      $prevControl.classList.remove("m--active-control");
      $prevControl.classList.add("m--prev-control");
      $slider.querySelector(prefix + "nav__control-" + slideID).classList.add("m--active-control");

      $activeSlide = $slider.querySelector(prefix + "slide-" + slideID);
      $activeControlsBg = $slider.querySelector(prefix + "nav__bg-" + slideID);

      $slider.querySelector(".m--active-slide").classList.add("m--previous-slide");
      $slider.querySelector(".m--active-nav-bg").classList.add("m--previous-nav-bg");

      $activeSlide.classList.add("m--before-sliding");
      $activeControlsBg.classList.add("m--nav-bg-before");

      var layoutTrigger = $activeSlide.offsetTop;

      $activeSlide.classList.add("m--active-slide");
      $activeControlsBg.classList.add("m--active-nav-bg");

      setTimeout(afterSlidingHandler, slidingAT + slidingDelay);
    };



    function controlClickHandler() {
      if (sliding) return;
      if (this.classList.contains("m--active-control")) return;
      if (options.blockASafterClick) {
        autoSlidingBlocked = true;
        $slider.classList.add("m--autosliding-blocked");
      }

      var slideID = +this.getAttribute("data-slide");

      performSliding(slideID);
    };

    $controls.forEach(function ($control) {
      $control.addEventListener("click", controlClickHandler);
    });

    function setAutoslidingTO() {
      window.clearTimeout(autoSlidingTO);
      var delay = +options.autoSlidingDelay || autoSlidingDelay;
      curSlide++;
      if (curSlide > numOfSlides) curSlide = 1;

      autoSlidingTO = setTimeout(function () {
        performSliding(curSlide);
      }, delay);
    };

    if (options.autoSliding || +options.autoSlidingDelay > 0) {
      if (options.autoSliding === false) return;

      autoSlidingActive = true;
      setAutoslidingTO();

      $slider.classList.add("m--with-autosliding");
      var triggerLayout = $slider.offsetTop;

      var delay = +options.autoSlidingDelay || autoSlidingDelay;
      delay += slidingDelay + slidingAT;

      $progressAS.forEach(function ($progress) {
        $progress.style.transition = "transform " + (delay / 1000) + "s";
      });
    }

    $slider.querySelector(".fnc-nav__control:first-child").classList.add("m--active-control");

  };

  var fncSlider = function (sliderSelector, options) {
    var $sliders = $$(sliderSelector);

    $sliders.forEach(function ($slider) {
      _fncSliderInit($slider, options);
    });
  };

  window.fncSlider = fncSlider;
}());


fncSlider(".example-slider", {
  autoSlidingDelay: 4000
});

var $demoCont = document.querySelector(".demo-cont");

[].slice.call(document.querySelectorAll(".fnc-slide__action-btn")).forEach(function ($btn) {
  $btn.addEventListener("click", function () {
    $demoCont.classList.toggle("credits-active");
  });
});

document.querySelector(".demo-cont__credits-close").addEventListener("click", function () {
  $demoCont.classList.remove("credits-active");
});

document.querySelector(".js-activate-global-blending").addEventListener("click", function () {
  document.querySelector(".example-slider").classList.toggle("m--global-blending-active");
});

// Slider End





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

$('.signin').hover(function () {}, function () {
  $(this).addClass('animateout');
  setTimeout(function () {
    $('.signin').removeClass('animateout');
  }, 750);
});

$('.signin').on('click', function () {
  $('.overlay').toggleClass('active');
  $('signinform-field').removeClass('focus');
  $('input').val('');
  return false;
});
$('input').focus(function () {
  $(this).parent().addClass('focus');
}).blur(function () {
  if ($(this).val() == '') {
    $(this).parent().removeClass('focus');
  }
  if ($('#fdEmail').val() != '' && $('#fdPassword').val() != '') {
    $('#btSubmit').addClass('active');
  } else {
    $('#btSubmit').removeClass('active');

  }
});
$('#btSubmit').on('click', function () {
  return false;
});
$('#btCancel').on('click', function () {
  $('.overlay').removeClass('active');
  return false;
});

// const settings = {
// 	"async": true,
// 	"crossDomain": true,
// 	"url": "https://imdb8.p.rapidapi.com/auto-complete?q=tt13169104",
// 	"method": "GET",
// 	"headers": {
// 		"x-rapidapi-key": "07ae0cdc6emsh2eacd0de221dc1ap1eadc8jsna4281794e93d",
// 		"x-rapidapi-host": "imdb8.p.rapidapi.com"
// 	}
// };

// $.ajax(settings).done(function (response) {
// 	console.log(response);
// });



$(window).on('load',function(){
	setTimeout(function(){ // allowing 3 secs to fade out loader
	$('.page-loader').fadeOut('slow');
	},1500);
});