'use strict'

$(window).on('load',function(){
	setTimeout(function(){ // allowing 3 secs to fade out loader
	$('.page-loader').fadeOut('slow');
	},3500);
});
//Responsive Header Hamburger
var MenuContent = document.getElementById("Menu-content");
$(document).ready(function () {
    $(".navbar-button").click(function () {
        $(".navbar-button").toggleClass("active");
        if (MenuContent.style.opacity==1 && MenuContent.style.visibility=="visible" && MenuContent.style.height=="100vh") {
            MenuContent.style.opacity=0;
            MenuContent.style.visibility="hidden";
            MenuContent.style.height="0vh";
        } else {
          MenuContent.style.opacity=1;
          MenuContent.style.visibility="visible";
          MenuContent.style.height="100vh";
        }
    });
});
// -------------------------------------------


// new film start

function toggle(){
    var video = document.querySelector(".tag-video")
    var exit =document.querySelector("iframe")
    video.classList.toggle("active");
    exit.currentTime=0;
    var videos = $("#playerid").attr("src");
  $("#playerid").attr("src","");
  $("#playerid").attr("src",videos);
  }
  
  
  // new film end

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


  // home slider start

$('.series-card').slick({
    centerMode: true,
    centerPadding: '80px',
    slidesToShow: 4,
    autoplay:true,
    speed:1000,
    arrows:false,
    infinite:true,
    dots:false,
    responsive: [
      {
        breakpoint: 769,
        settings: {
          arrows: false,
          dots:false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 2
        }
      },
      {
        breakpoint: 992,
        settings: {
          arrows: false,
          dots:false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 3
        }
      },
     
      {
        breakpoint: 430,
        settings: {
          arrows: false,
          dots:false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 1
        }
      }
    ]
  });

//   home slider end


// same category film start


window.addEventListener('load', () => {
	var
		carousels = document.querySelectorAll('.carousel')
	;

	for (var i = 0; i < carousels.length; i++) {
		carousel(carousels[i]);
	}
});

function carousel(root) {
	var
		figure = root.querySelector('figure'),
		nav = root.querySelector('nav'),
		images = figure.children,
		n = images.length,
		gap = root.dataset.gap || 0,
		bfc = 'bfc' in root.dataset,
		
		theta =  2 * Math.PI / n,
		currImage = 0
	;
	
	setupCarousel(n, parseFloat(getComputedStyle(images[0]).width));
	window.addEventListener('resize', () => { 
		setupCarousel(n, parseFloat(getComputedStyle(images[0]).width)) 
	});

	setupNavigation();

	function setupCarousel(n, s) {
		var	
			apothem = s / (2 * Math.tan(Math.PI / n))
		;
		
		figure.style.transformOrigin = `50% 50% ${- apothem}px`;

		for (var i = 0; i < n; i++)
			images[i].style.padding = `${gap}px`;
		for (i = 1; i < n; i++) {
			images[i].style.transformOrigin = `50% 50% ${- apothem}px`;
			images[i].style.transform = `rotateY(${i * theta}rad)`;
		}
		if (bfc)
			for (i = 0; i < n; i++)
				 images[i].style.backfaceVisibility = 'hidden';
		
		rotateCarousel(currImage);
	}

	function setupNavigation() {
		nav.addEventListener('click', onClick, true);
		
		function onClick(e) {
			e.stopPropagation();
			
			var t = e.target;
			if (t.tagName.toUpperCase() != 'BUTTON')
				return;
			
			if (t.classList.contains('next')) {
				currImage++;
			}
			else {
				currImage--;
			}
			
			rotateCarousel(currImage);
		}
			
	}

	function rotateCarousel(imageIndex) {
		figure.style.transform = `rotateY(${imageIndex * -theta}rad)`;
	}
	
}

// same category film end


// feature films start

$('.all').slick({
  centerMode: true,
  centerPadding: '80px',
  slidesToShow: 4,
  autoplay:true,
  speed:1000,
  arrows:false,
  infinite:true,
  dots:false,
  responsive: [
    {
      breakpoint: 769,
      settings: {
        arrows: false,
        dots:false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 2
      }
    },
    {
      breakpoint: 992,
      settings: {
        arrows: false,
        dots:false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 3
      }
    },
   
    {
      breakpoint: 430,
      settings: {
        arrows: false,
        dots:false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 1
      }
    }
  ]
});

// feature films end


// same category phone start

$('.category-card').slick({
  centerMode: true,
  centerPadding: '80px',
  slidesToShow: 4,
  autoplay:true,
  speed:1000,
  arrows:false,
  infinite:true,
  dots:false,
  responsive: [
    {
      breakpoint: 769,
      settings: {
        arrows: false,
        dots:false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 2
      }
    },
    {
      breakpoint: 992,
      settings: {
        arrows: false,
        dots:false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 3
      }
    },
   
    {
      breakpoint: 430,
      settings: {
        arrows: false,
        dots:false,
        centerMode: true,
        centerPadding: '40px',
        slidesToShow: 1
      }
    }
  ]
});

// same category phone end
(function(){
	$('.flex-container').waitForImages(function() {
		$('.spinner').fadeOut();
	}, $.noop, true);
	
	$(".flex-slide").each(function(){
		$(this).hover(function(){
			$(this).find('.flex-title').css({
				transform: 'rotate(0deg)',
				top: '10%'
			});
			$(this).find('.flex-about').css({
				opacity: '1'
			});
		}, function(){
			$(this).find('.flex-title').css({
				transform: 'rotate(90deg)',
				top: '15%'
			});
			$(this).find('.flex-about').css({
				opacity: '0'
			});
		})
	});
})();

$(window).on('load',function(){
	setTimeout(function(){ // allowing 3 secs to fade out loader
	$('.page-loader').fadeOut('slow');
	},3500);
});



