'use strict'

if (window.getSelection().rangeCount >= 1) { var r = window.getSelection().getRangeAt(0); }

// -------------------------------------------


  
  // new film end



  // home slider start
$(function () {
    $('.series-card').not('.slick-initialized').slick({
        centerMode: true,
        centerPadding: '80px',
        slidesToShow: 4,
        autoplay: true,
        speed: 1000,
        arrows: false,
        infinite: true,
        dots: false,
        responsive: [
            {
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

})

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


