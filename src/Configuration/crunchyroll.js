function saveConfig() {
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;

    ApiClient.getPluginConfiguration("CrunchyrollPlugin").then(function(config) {
        config.CrunchyrollUsername = username;
        config.CrunchyrollPassword = password;

        ApiClient.updatePluginConfiguration("CrunchyrollPlugin", config).then(function(result) {
            alert("Configuration saved!");
        });
    });
}