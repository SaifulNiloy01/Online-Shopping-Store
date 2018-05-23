$(document).ready(function () {
    console.log('This page has ' + $('*').length + ' elements!');
    $('.jumbotron').height($(window).height());
    $('.item').height($(window).height());

    $(window).on('resize', function () {
        $('.jumbotron').height($(window).height());
        $('.item').height($(window).height());
    });

    $('.carousel').carousel({
        interval: 5000
    });

    $(window).on('scroll', function () {
        var scrolling = $(this).scrollTop();

            $('.item img').css('transform', 'translateY(' + scrolling/3 + 'px)');

        if (scrolling > 30) {
            $('.navbar-fixed-top').addClass('color-it');
        }
        else {
            $('.navbar-fixed-top').removeClass('color-it');
        }

    });
    $('html').mousemove(function (e) {
        var x = e.pageX,
            y = e.pageY;
        $('.carousel-caption, .carousel-caption .layer').css('transform', 'translate(' + x / -110 + 'px, ' + y / -110 + 'px)');
        
        $('.store-content .row .col-sm-2').css('transform', 'translate(' + x / -110 + 'px, ' + y / -110 + 'px)');
        

    });
    $('.search-btn').on('click', function () {
        $('.search-content').addClass('slide-it');
        $('.body-content, .nav').addClass('blur-it');
        
    });
    $('.exit').on('click', function () {
        $('.search-content').removeClass('slide-it');
        $('.body-content, .nav').removeClass('blur-it');
    });
});