(function($) {
    if (!$)
        return;
    $.fn.imgLazyLoad = function(options) {
        var defaults = {
            preloadSrc: '',
            originalSrcAttr: 'data-src',
            bottom: 50
        };
        var opt = $.extend(defaults, options);
        var lazyImgArray = [];
        this.each(function() {
            var $lazyimg = $(this).find("img[" + opt.originalSrcAttr + "]");
            if ($lazyimg.length > 0) {
                if (opt.preloadSrc) {
                    $lazyimg.attr("src", opt.preloadSrc);
                }
                if ($lazyimg.eq(0).offset()) {
                    lazyImgArray.push([$lazyimg.eq(0).offset().top, $lazyimg]);
                }
            }
        });
        var lazyload = function() {
            var _len = lazyImgArray.length,
                    _height = $(window).height(),
                    _scrollTop = $(window).scrollTop();
            for (var i = 0, j = 0; i < _len; i++) {
                if (lazyImgArray[i][0] <= _height + _scrollTop - opt.bottom) {
                    lazyImgArray[i][1].each(function() {
                        if ($(this).attr(opt.originalSrcAttr) != '') {
                            $(this).attr("src", $(this).attr(opt.originalSrcAttr));
                            $(this).removeAttr(opt.originalSrcAttr);
                        }
                    });
                    j++;
                }
                if (j >= _len) {
                    $(window).unbind("scroll", lazyload);
                    $(window).unbind("resize", lazyload);
                }
            }
        };
        if (lazyImgArray.length) {
            lazyload();
            $(window).bind("scroll", lazyload);
            $(window).bind("resize", lazyload);
        }
    };
})(typeof jQuery === 'undefined' ? null : jQuery);