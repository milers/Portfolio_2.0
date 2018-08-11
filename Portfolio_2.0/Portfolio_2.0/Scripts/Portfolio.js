

$(document).ready(function () {

    jQuery.ajaxSettings.traditional = true;
    $("#LanguageList").change(function () {
        
        var lang = $("#LanguageList option:selected").val();
        document.getElementById("LanguageList").value = lang;
        //alert(lang);
        getTranslation(lang);
    });
    function getTranslation(lang) {
        //$("#wiecejbtn").text("More");

        $.ajax({
            type: "POST",
            url: "Home/getLang",
            contentType: "application/json; charset=utf-8",
            data: "{ 'lang': '"+ lang+"'}",
            dataType: "json",
            async: true,
            cache: false
        }).done(function (model) {

            translateContent(model);

        });
    }
    function translateContent(model) 
    {
        $("#AboutMenu").text(model.AboutMenu);
        $("#PortfolioMenu").text(model.PortfolioMenu);
        $("#ContactMenu").text(model.ContactMenu);
    }
});