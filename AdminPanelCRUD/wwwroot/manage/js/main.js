let deleteBtns = document.querySelectorAll(".deleteBtn");

deleteBtns.forEach(btn => btn.addEventListener("click", function () {
    btn.parentElement.remove();
}))