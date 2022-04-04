// ==UserScript==
// @name         Remove Netflix overlay
// @namespace    https://pupslab.de
// @version      0.1
// @description  Removes the info overlay when netflix playback is paused
// @author       You
// @match        https://www.netflix.com/*
// @icon         data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw==
// @grant        none
// ==/UserScript==

(function() {
    'use strict';

    const domObserver = new MutationObserver((mutations) => {
            mutations.forEach((mutation) => {
                mutation.addedNodes.forEach(node => {
                    if (!node || node.nodeType !== Node.ELEMENT_NODE) {
                        return;
                    }

                    const element = node;
                    if (element.className !== "watch-video--evidence-overlay-container") {
                        return;
                    }

                    console.log("Removing video metadata overlay.");

                    element.setAttribute('style', 'display: none;');
                });
            });
        });

     domObserver.observe(document, {
            childList: true,
            subtree: true,
            attributes: false,
            characterData: false,
        });
})();