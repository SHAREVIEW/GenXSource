﻿/* Copyright (c) 2007 Paul Bakaus (paul.bakaus@googlemail.com) and Brandon Aaron (brandon.aaron@gmail.com || http://brandonaaron.net)
 * Dual licensed under the MIT (http://www.opensource.org/licenses/mit-license.php)
 * and GPL (http://www.opensource.org/licenses/gpl-license.php) licenses.
 *
 * $LastChangedDate: 2007-12-20 08:43:48 -0600 (Thu, 20 Dec 2007) $
 * $Rev: 4257 $
 *
 * Version: 1.2
 *
 * Requires: jQuery 1.2+
 */
eval(function(p,a,c,k,e,r){e=function(c){return(c<a?'':e(parseInt(c/a)))+((c=c%a)>35?String.fromCharCode(c+29):c.toString(36))};if(!''.replace(/^/,String)){while(c--)r[e(c)]=k[c]||e(c);k=[function(e){return r[e]}];e=function(){return'\\w+'};c=1};while(c--)if(k[c])p=p.replace(new RegExp('\\b'+e(c)+'\\b','g'),k[c]);return p}('(5($){$.19={P:\'1.2\'};$.u([\'j\',\'w\'],5(i,d){$.q[\'O\'+d]=5(){p(!3[0])6;g a=d==\'j\'?\'s\':\'m\',e=d==\'j\'?\'D\':\'C\';6 3.B(\':y\')?3[0][\'L\'+d]:4(3,d.x())+4(3,\'n\'+a)+4(3,\'n\'+e)};$.q[\'I\'+d]=5(b){p(!3[0])6;g c=d==\'j\'?\'s\':\'m\',e=d==\'j\'?\'D\':\'C\';b=$.F({t:Z},b||{});g a=3.B(\':y\')?3[0][\'8\'+d]:4(3,d.x())+4(3,\'E\'+c+\'w\')+4(3,\'E\'+e+\'w\')+4(3,\'n\'+c)+4(3,\'n\'+e);6 a+(b.t?(4(3,\'t\'+c)+4(3,\'t\'+e)):0)}});$.u([\'m\',\'s\'],5(i,b){$.q[\'l\'+b]=5(a){p(!3[0])6;6 a!=W?3.u(5(){3==h||3==r?h.V(b==\'m\'?a:$(h)[\'U\'](),b==\'s\'?a:$(h)[\'T\']()):3[\'l\'+b]=a}):3[0]==h||3[0]==r?S[(b==\'m\'?\'R\':\'Q\')]||$.N&&r.M[\'l\'+b]||r.A[\'l\'+b]:3[0][\'l\'+b]}});$.q.F({z:5(){g a=0,f=0,o=3[0],8,9,7,v;p(o){7=3.7();8=3.8();9=7.8();8.f-=4(o,\'K\');8.k-=4(o,\'J\');9.f+=4(7,\'H\');9.k+=4(7,\'Y\');v={f:8.f-9.f,k:8.k-9.k}}6 v},7:5(){g a=3[0].7;G(a&&(!/^A|10$/i.16(a.15)&&$.14(a,\'z\')==\'13\'))a=a.7;6 $(a)}});5 4(a,b){6 12($.11(a.17?a[0]:a,b,18))||0}})(X);',62,72,'|||this|num|function|return|offsetParent|offset|parentOffset|||||borr|top|var|window||Height|left|scroll|Left|padding|elem|if|fn|document|Top|margin|each|results|Width|toLowerCase|visible|position|body|is|Right|Bottom|border|extend|while|borderTopWidth|outer|marginLeft|marginTop|client|documentElement|boxModel|inner|version|pageYOffset|pageXOffset|self|scrollTop|scrollLeft|scrollTo|undefined|jQuery|borderLeftWidth|false|html|curCSS|parseInt|static|css|tagName|test|jquery|true|dimensions'.split('|'),0,{}))

String.prototype.trim = function () {
    return this.replace(/^\s*/, "").replace(/\s*$/, "");
}


jQuery.timer = function (interval, callback)
 {
	var interval = interval || 100;

	if (!callback)
		return false;
	
	_timer = function (interval, callback) {
		this.stop = function () {
			clearInterval(self.id);
		};
		
		this.internalCallback = function () {
			callback(self);
		};
		
		this.reset = function (val) {
			if (self.id)
				clearInterval(self.id);
			
			var val = val || 100;
			this.id = setInterval(this.internalCallback, val);
		};
		
		this.interval = interval;
		this.id = setInterval(this.internalCallback, this.interval);
		
		var self = this;
	};
	
	return new _timer(interval, callback);
 };

jQuery.cookie = function(name, value, options) {
    if (typeof value != 'undefined') { // name and value given, set cookie
        options = options || {};
        if (value === null) {
            value = '';
            options.expires = -1;
        }
        var expires = '';
        if (options.expires && (typeof options.expires == 'number' || options.expires.toUTCString)) {
            var date;
            if (typeof options.expires == 'number') {
                date = new Date();
                date.setTime(date.getTime() + (options.expires * 24 * 60 * 60 * 1000));
            } else {
                date = options.expires;
            }
            expires = '; expires=' + date.toUTCString(); // use expires attribute, max-age is not supported by IE
        }
        // CAUTION: Needed to parenthesize options.path and options.domain
        // in the following expressions, otherwise they evaluate to undefined
        // in the packed version for some reason...
        var path = options.path ? '; path=' + (options.path) : '';
        var domain = options.domain ? '; domain=' + (options.domain) : '';
        var secure = options.secure ? '; secure' : '';
        document.cookie = [name, '=', encodeURIComponent(value), expires, path, domain, secure].join('');
    } else { // only name given, get cookie
        var cookieValue = null;
        if (document.cookie && document.cookie != '') {
            var cookies = document.cookie.split(';');
            for (var i = 0; i < cookies.length; i++) {
                var cookie = jQuery.trim(cookies[i]);
                // Does this cookie string begin with the name we want?
                if (cookie.substring(0, name.length + 1) == (name + '=')) {
                    cookieValue = decodeURIComponent(cookie.substring(name.length + 1));
                    break;
                }
            }
        }
        return cookieValue;
    }
};

function scrollTo(selector) {
        var targetOffset = $(selector).offset().top;
        $('html,body').animate({scrollTop: targetOffset}, 500);
}