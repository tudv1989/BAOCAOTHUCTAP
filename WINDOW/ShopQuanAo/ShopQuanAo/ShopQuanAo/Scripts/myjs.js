// JavaScript Document


$(window).load(function () {
    $('#slider').nivoSlider({
        effect: 'random', // Specify sets like: 'fold,fade,sliceDown'
        slices: 15, // For slice animations
        boxCols: 8, // For box animations
        boxRows: 4, // For box animations
        animSpeed: 1000, // Slide transition speed
        pauseTime: 5000, // How long each slide will show
        startSlide: 0, // Set starting Slide (0 index)
        directionNav: true, // Next & Prev navigation
        controlNav: true, // 1,2,3... navigation
        controlNavThumbs: false, // Use thumbnails for Control Nav
        pauseOnHover: true, // Stop animation while hovering
        manualAdvance: false, // Force manual transitions
        prevText: 'Prev', // Prev directionNav text
        nextText: 'Next', // Next directionNav text
        randomStart: false, // Start on a random slide
        beforeChange: function () { }, // Triggers before a slide transition
        afterChange: function () { }, // Triggers after a slide transition
        slideshowEnd: function () { }, // Triggers after all slides have been shown
        lastSlide: function () { }, // Triggers when last slide is shown
        afterLoad: function () { } // Triggers when slider has loaded
    });
    $('ul li').hover(
		function () {
		    $(this).find('span').slideDown(500);
		}
		, function () {
		    $(this).find('span').slideUp(200);
		}


	);
    $(window).scroll(function () {
        var $toado_bandau = 0;
        var $toado_hientai = $(window).scrollTop();
        var $top = $toado_hientai - $toado_bandau;
        $('#menu-scroll').stop().animate({ 'top': $top + 100 }, 700);
        $toado_bandau = $toado_hientai;
        if ($(window).scrollTop() <= 500) {
            $('#menu-scroll').hide();
        }
        else {
            $('#menu-scroll').show();
        }
    });

    $('dd:not(:first)').hide();
    $('dt a').hover(function () { // khai báo sự kiện click cho các thẻ a trong dt
        $('dd:visible').hide(); // hide thành phần đang hiển thị
        // hiển thị thẻ dd của dt có the a dang click
        $(this).parent().next().show();

    });
    $('#animation').click(function () {

        $('#cart_mid').slideToggle();


    });
    $('#comment_click').click(function () {

        $('#form_comment').slideToggle();



    });
    // khai báo hàm xử lý sự kiện click cho button "Gởi"
    $('#btnGui').click(function () {
        var tieude = $('#txtTieuDe').val();
        var noidung = $('#txtNoiDung').val();
        $.post("PostComment.aspx", { td: tieude, nd: noidung }, function (data) {
            // xử lý khi server tra về
            if (data == "1") {
                $('#txtTieuDe').value = "";
                alert('Thêm comment thành công!');
                
            }
            else {
                alert('Không thể thêm comment!');
            }
        }); // end post

    });


});
