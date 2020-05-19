// For some reason, Edge has the string trim functions named incorrectly
if (String.prototype.trimLeft)
    String.prototype.trimStart = String.prototype.trimLeft;

/**
 * Show a lightbox for each image with the attribute lightbox
 * when the image is clicked
 */
function createLightboxes() {
    let lightboxElements = document.querySelectorAll("[lightbox]");

    for (let lightboxElement of lightboxElements) {
        let lightboxImage = document.createElement("img");
        lightboxImage.src = lightboxElement.src;

        lightboxElement.onclick = function () {
            let lightboxModal = document.getElementById("lightboxModal");
            let lightboxModalBody = document.querySelector("#lightboxModal .modal-body");
            lightboxModalBody.innerHTML = "";
            lightboxModalBody.appendChild(lightboxImage);
            $(lightboxModal).modal("show");
        };
    }
}

// Create lightboxes on page load
document.addEventListener("DOMContentLoaded", createLightboxes);

/**
 * Add syntax highlighting to <code> blocks.
 */
function initCodeBlocks() {
    let codeElements = document.querySelectorAll("code");

    // Remove leading whitespace, while preserving indentation
    for (let codeElement of codeElements) {
        // Dirty hack I know, but it works
        let code = codeElement.innerHTML;
        let leadingWhitespace = code.length - code.trimStart().length;
        let codeLines = code.split("\n");

        // Loop through each line and remove its excess leading
        // whitespace
        for (let i = 0; i < codeLines.length; i++) {
            let line = codeLines[i];
            let codeLeadingWhitespace = line.length - line.trimStart().length;
            if (codeLeadingWhitespace >= leadingWhitespace - 1) {
                codeLines[i] = line.substring(leadingWhitespace - 1);
            }
        }

        codeElement.innerHTML = codeLines.join("\n");
    }

    // Add syntax highlighter
    hljs.initHighlightingOnLoad();
}