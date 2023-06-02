document.getElementById("switch-shadow").addEventListener("change", function () {
    var modeText = document.getElementById("mode-text");
    if (this.checked) {
        modeText.textContent = "Dark";
    } else {
        modeText.textContent = "Light";
    }
});
