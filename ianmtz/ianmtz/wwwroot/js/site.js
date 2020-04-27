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