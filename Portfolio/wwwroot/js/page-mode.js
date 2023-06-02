// Ao alterar o estado do interruptor com o ID "switch-shadow", uma função será acionada
document.getElementById("switch-shadow").addEventListener("change", function () {
    // Obtendo o elemento de texto com o ID "mode-text"
    var modeText = document.getElementById("mode-text");

    // Verificando se o interruptor está marcado (modo escuro ativado)
    if (this.checked) {
        // Atualizando o conteúdo do elemento de texto para "Dark"
        modeText.textContent = "Dark";

        // Adicionando a classe "dark-mode" ao elemento body
        document.body.classList.add("dark-mode");
    } else {
        // Caso contrário, se o interruptor não estiver marcado (modo escuro desativado)
        // Atualizando o conteúdo do elemento de texto para "Light"
        modeText.textContent = "Light";

        // Removendo a classe "dark-mode" do elemento body
        document.body.classList.remove("dark-mode");
    }
});
