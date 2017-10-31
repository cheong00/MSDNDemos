// ==UserScript==
// @name         Disable double tap zoom
// @namespace    http://tampermonkey.net/
// @version      1.0
// @description  Who needs double tap zoom when you can zoom with two finger gasture?
// @author       cheong00
// @include      *
// @run-at       document-body
// @grant        none
// ==/UserScript==

(function() {
    'use strict';

    function addGlobalStyle(css) {
        var head, style;
        head = document.getElementsByTagName('head')[0];
        if (!head) { return; }
        style = document.createElement('style');
        style.type = 'text/css';
        style.innerHTML = css;
        head.appendChild(style);
    }

    addGlobalStyle("body { touch-action: manipulation !important; }");

})();