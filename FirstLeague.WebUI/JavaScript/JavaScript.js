function countingDown()
{
    var dzisiaj = new Date();

    var godzina = dzisiaj.getHours();
    if (godzina < 10) godzina = "0" + godzina;

    var minuta = dzisiaj.getMinutes();
    if (minuta < 10) minuta = "0" + minuta;

    var sekunda = dzisiaj.getSeconds();
    if (sekunda < 10) sekunda = "0" + sekunda;

    document.getElementById("clock").innerHTML = godzina + ":" + minuta + ":" + sekunda;

    setTimeout("countingDown()", 1000);
}

var n = 1;

function nextPhotoL()
{
    n++;
    if (n > 7) { n = 1; }

    var file = "<img class=\"img-rounded\" width=\"500\" height=\"309\" src=\"../img/photo" + n + ".jpg\"/>";

    document.getElementById("photosL").innerHTML = file;

    setTimeout("nextPhotoL()", 4000);
}

function nextPhotoR() {
    n++;
    if (n > 7) { n = 1; }

    var file = "<img class=\"img-rounded\" width=\"500\" height=\"309\" src=\"../img/photo" + n + ".jpg\"/>";

    document.getElementById("photosR").innerHTML = file;

    setTimeout("nextPhotoR()", 8000);
}


(function ()
{
    function createButton()
    {
        var button = document.createElement("button");

        button.classList.add("backToTop", "hidden");
        button.textContent = "W GÓRĘ";
        document.body.appendChild(button);

        return button;
    }

    var button = createButton();

    function animateScroll() 
    {
        if (document.body.scrollTop > 0)
        {
            window.scrollBy(0, -9);
            setTimeout(animateScroll, 1);
        }
    }

    button.addEventListener("click", function (e)
    {
        e.stopPropagation();
        animateScroll();

    }, false);

    window.addEventListener("scroll", function (e)
    {
        if (document.body.scrollTop >= 100)
        {
            button.classList.remove("hidden");
        } else
        {
            button.classList.add("hidden");
        }
    }, false);

})();