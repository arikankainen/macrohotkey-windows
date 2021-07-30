# Macro Hotkey

Macro Hotkeyn tarkoitus on automatisoida usein toistettavia hiirell� tai n�pp�imist�ll� teht�vi� t�it�. Sill� voidaan esimerkiksi t�ytt�� lomakkeita tietyill� samoilla tiedoilla, tai vaihtoehtoisesti esimerkiksi Excelist� kopioitavalla sis�ll�ll�. P��asia on, ett� ty� on toistettavaa ja t�ytett�v�t kent�t sijaitsevat aina samassa paikassa, tai ovat muuten helposti valittavissa esim. n�pp�inkomennoilla.

![Macro Hotkey](/docs/main.png)

## K�ytt�

Makroja voidaan k�ynnist�� joko `Run`-painikkeella, tai antamalla makrolle oman n�pp�inyhdistelm�n. N�pp�inyhdistelm�� k�ytett�ess� itse ohjelma voi olla pienennettyn� tai piilotettuna teht�v�palkin ilmoitusalueelle. Makron ollessa k�ynniss� p��n�yt�n yl�reunaan ilmestyy musta ikkuna, joka kertoo arvion makron edistymisest�. Arvio ei kaikissa tapauksissa ole t�ysin tarkka, koska se lasketaan etuk�teen makron sis�lt�mist� komennoista (sama arvio n�ytet��n p��ikkunan tilapalkissa kun makro on valittuna). Makron p��tytty� ikkuna h�vi�� ruudulta. Makro voidaan my�s lopettaa kesken painamalla n�pp�inyhdistelm�� `Ctrl-Break/Pause` (jos k�yt�ss� on l�pp�ri, voi komento olla merkist� riippuen esim. `Fn-Ctrl-B`). My�s makron keskeytys ja jatkaminen on mahdollista painamalla pelkk�� `Break/Pause` -n�pp�int� (l�pp�riss� esim. `Fn-P`).

## Valikot

**_File / Create backup of all macros_**\
P��ikkunassa n�kyv� lista makroista on tallennettu ohjelman kanssa samaan kansioon, nimell� `macrohotkey.lst`. Kyseisest� tiedostosta voidaan ottaa helposti varmuuskopioita, jos makrojen tallennuksessa sattuisi menem��n jotain pieleen. Varmuuskopiot makroista tallennetaan samaan paikkaan, tiedostonimell� `macrohotkey_backup_2019-12-23_15-31-42.lst` (jossa siis on varmuuskopiohetken p�iv�m��r�). Varmuuskopion palauttaminen onnistuu kun varmuuskopion nime�� oletusnimell� `macrohotkey.lst`.

**_File / Settings_**\
Avataan ohjelman asetukset.

**_File / Help_**\
Avataan n�m� ohjeet.

**_File / Exit_**\
Ohjelma suljetaan, vaikka asetuksista olisi valittu ett� ohjelma "sulkeutuu" teht�v�palkkin ilmoitusalueelle.

## Asetukset _(General -v�lilehti)_

![Asetukset](/docs/settings_general.png)

**_Close to tray_**\
Valinnan ollessa p��ll� ohjelman sulkeminen ikkunan `X`-painikkeesta ei oikeasti sulje ohjelmaa, vaan piilottaa sen kuvakkeeksi teht�v�p�lkin ilmoitusalueelle.

**_Start in tray_**\
Ohjelma k�ynnistet��n piilotettuna teht�v�palkin ilmoitusalueelle.

**_Minimize when using 'Run' button_**\
Ohjelma pienennet��n pois tielt� jos makro k�ynnistet��n `Run`-painikkeesta.

**_Remember main window size_**\
P��ikkunan koko muistetaan seuraavan kerran ohjelmaa k�ynnistett�ess�.

**_Remember main window position_**\
P��ikkunan sijainti n�yt�ll� muistetaan seuraavan kerran ohjelmaa k�ynnistett�ess�.

**_Remember editor window size_**\
Makroeditorin koko muistetaan seuraavan kerran editoria avattaessa.

**_Remember editor window position_**\
Makroeditorin sijainti n�yt�ll� muistetaan seuraavan kerran editoria avattaessa.

**_Return mouse to its original position after macro is finished_**\
Makron p��tytty� hiiren kursori palautetaan siihen pisteeseen jossa se oli ennen kuin makro k�ynnistettiin.

## Asetukset _(Delays -v�lilehti)_

![Asetukset](/docs/settings_delays.png)

**_Delay on start_**\
M��ritet��n kuinka paljon makron suorituksen aloittamista viiv�stytet��n kun makro k�ynnistet��n. Esimerkiksi jos viive on nollassa ja makro k�ynnistet��n pikan�pp�imell�, saattaa viel� pohjassa olevat pikan�pp�imet h�irit� makron ensimm�isen komennon suoritusta. Oletusviive on `500ms`.

**_Delay between commands_**\
Jokaisen komennon suorituksen v�liin voidaan m��ritt�� tietynpituinen tauko. Mik�li kahden komennon v�liin lis�t��n makroeditorissa taukokomento (_Delay_), j�tet��n t�ss� m��ritelty tauko huomiotta. Oletusviive on `100ms`.

**_Delay before 'Paste' or 'PasteText' commands_**\
'Paste' ja 'PasteText' komento liitt�� m��ritellyn tekstin leikep�yd�n kautta, ja t�ll� asetuksella m��ritell��n kuinka kauan odotetaan ennenkuin leikep�yd�lle asetettu teksti liitet��n sovellukseen. Jos liitt�minen tapahtuu liian nopeasti, sovelluksesta riippuen teksti ei ole viel� valmiina liitett�v�ksi. Jos liitt�misess� on ongelmia, pidenn� t�t� aikaa. Oletusviive on `300ms`.

**_Delay after 'Paste' or 'PasteText' commands_**\
'Paste' ja 'PasteText' komento liitt�� m��ritellyn tekstin leikep�yd�n kautta, joutuen v�liaikaisesti tyhjent�m��n siell� mahdollisesti ennest��n olleen tekstin. Alkuper�inen teksti palautetaan leikep�yd�lle liitt�misen j�lkeen, ja t�ll� asetuksella m��ritell��n kuinka pitk��n odotetaan ett� alkuper�inen teksti palautetaan leikep�yd�lle. Jos palautus tapahtuu liian nopeasti, sovelluksesta riippuen ei leikep�yd�n teksti� ehk� ehdit� liitt�m��n sovellukseen. Jos liitt�misess� on ongelmia, pidenn� t�t� aikaa. Oletusviive on `100ms`.

## Makroeditori

![Makroeditori](/docs/macro_editor.png)

### Editorin k�ytt�

`Name` -kentt��n annetaan makron nimi. `Hotkey` -kentt��n voidaan m��ritell� pikan�pp�in tai pikan�pp�inyhdistelm�, jolla makro k�ynnistet��n. Kent�n ollessa aktiivinen (taustav�ri on kellert�v�), voidaan n�pp�imist�st� painaa n�pp�in tai n�pp�inyhdistelm�. Pikan�pp�imess� kannattaa k�ytt�� `Ctrl`, `Shift` tai `Alt`-n�pp�imi�, sill� jos sy�t�t esim. pelk�n kirjaimen `A`, et voi k�ytt�� `A`-kirjainta en�� muualla, sill� se k�ynnist�� aina makron. Pikan�pp�imen tyhjennys onnistuu, kun kent�ss� painaa `ESC`-n�pp�int�.

Itse makro kirjoitetaan isoon nime�m�tt�m��n tekstilaatikkoon. Makro koostuu ikkunan oikealta puolelta l�ytyvist� komennoista, joita voidaan liitt�� suoraan makroon klikkaamalla ko. komennon painiketta. Komento koostuu aina komennon nimest�, jonka per�ss� on sulut. Komennoissa isoilla kirjaimilla ei ole merkityst�, mutta paremman luettavuuden takia niiden sanat ovat oletuksena isolla alkukirjaimella. Sulkujen sis��n tulee komennosta riippuen esim. hiiren koordinaatit, liitett�v� teksti tai tauon pituus. Koordinaatit sis�lt�v�� komentoa tuplaklikkaamalla hiiren kursori siirret��n kyseisiin koordinaatteihin, jolloin ne on helppo tarkistaa. Komentojen v�liin voidaan luettavuuden helpottamiseksi j�tt�� tyhji� rivej�, sek� omia tilanteeseen liittyvi� kommenteja. Kommenttirivit kannattaa aloittaa risuaidalla `#`, jolloin rivin sis�lt�� ei yritet� suorittaa. My�s oikeita komentoja voidaan v�liaikaisesti poistaa k�yt�st� lis��m�ll� risuaita rivin alkuun. Mik�li jonkin rivin suorittaminen ei onnistu (esim. kirjoitusvirhe), siirryt��n suorittamaan seuraavaa rivi�. Makron alkuun lis�t��n automaattisesti n. `500ms` (puoli sekuntia) tauko, jotta makro ei ala samantien kun sen k�ynnist�v� n�pp�inyhdistelm� on viel� pohjassa. Samaten makron jokaisen komennon v�liin lis�t��n automaattisesti n. `100ms` tauko.

Ikkunan alalaidasta n�kyy hiiren kursorin koordinaatit, joita voi k�ytt�� apuna komennoissa. `Mouse position (Monitor)` kertoo hiiren koordinaatit tietyll� n�yt�ll�. N�yt�n koordinaatit `0,0` alkaa aina n�yt�n vasemmasta yl�laidasta. `Mouse position (Windows)` kertoo hiiren koordinaatit kun kaikkien n�ytt�jen ala otetaan huomioon. Normaalisti koordinaatit `0,0` alkaa p��n�yt�n (_Primary display_) vasemmasta yl�laidasta, ja jos ko. n�yt�n vasemmalla puolella on n�ytt�, menee sen n�yt�n koordinaatit `X`-akselilta miinusmerkkisiksi. `Windows` -koordinaatteja kannattaa k�ytt�� vain jos kaikki tapahtuu p��n�yt�ll�, sill� Windowsin asetuksista n�ytt�jen pienikin siirtely esim. korkeussuunnassa muuttaa muiden n�ytt�jen kuin p��n�yt�n koordinaatit. `Monitor` -koordinaatteja k�ytett�ess� `X` ja `Y` -koordinaattien per��n lis�t��n n�yt�n numero, joka n�kyy ikkunan alalaidassa (_Monitor number_). Numero ei v�ltt�m�tt� vastaa Windowsin asetusikkunan numerointia n�yt�ille. `Monitor`-koordinaatteja kannattaa k�ytt��, jos makro k�ytt�� joko useampaa kuin yht� n�ytt��, tai se k�ytt�� jotain muuta kuin p��n�ytt��. T�ll�in mahdollisen n�ytt�numeroinnin muuttuessa, on makrosta helppo k�yd� vain muuttamassa koordinaattien per�ss� olevat n�yt�n numerot vastaamaan uutta j�rjestyst�, eik� itse koordinaatteja tarvitse muuttaa.

### Komennot

**_MousePosition(X,Y,Monitor)..._**\
Hiiren kursori siirret��n tietyn n�yt�n koordinaatteihin. Vastaa makroeditorin `Mouse position (Monitor)` -koordinaatteja ja `Monitor number` -numeroa n�yt�lle.

Komennon nappia painamalla esiin tulee ikkuna, joka kehottaa siirt�m��n hiiren haluttuun paikkaan n�yt�ll� ja painamaan `Enter`. T�ll�in hiiren sen hetkiset koordinaatit sy�tet��n automaattisesti komentoon.

**_MousePosition(X,Y)..._**\
Hiiren kursori siirret��n koordinaatteihin joka ottaa huomioon kaikkien n�ytt�jen alan. Vastaa makroeditorin `Mouse position (Windows)` -koordinaatteja.

Komennon nappia painamalla esiin tulee ikkuna, joka kehottaa siirt�m��n hiiren haluttuun paikkaan n�yt�ll� ja painamaan `Enter`. T�ll�in hiiren sen hetkiset koordinaatit sy�tet��n automaattisesti komentoon.

**_MouseMove(X,Y)_**\
Hiiren kursoria siirret��n `X` pikseli� oikealle ja `Y` pikseli� alasp�in. Negatiivisia lukuja k�ytett�ess� vasemmalle tai yl�s.

**_MouseClick(Left)_**\
Hiiren vasemman napin klikkaus.

**_MouseClick(Middle)_**\
Hiiren keskimm�isen napin klikkaus.

**_MouseClick(Right)_**\
Hiiren oikean napin klikkaus.

**_MouseDown(Left)_**\
Hiiren vasen nappi painetaan pohjaan, eik� p��stet� yl�s. K�ytet��n kun halutaan esim. maalata teksti� liikuttaen hiirt� nappi pohjassa. Voidaan k�ytt�� my�s `Middle` ja `Right` -m��reit�.

**_MouseUp(Left)_**\
Hiiren vasen nappi p��stet��n yl�s. Voidaan k�ytt�� my�s `Middle` ja `Right` -m��reit�.

**_MouseScroll(Y)_**\
Vieritt�� hiiren rullaa `Y` kertaa. `Y`:n m��r� riippuu hiiren asetuksista. Positiivinen arvo vieritt�� yl�sp�in, negatiivinen alasp�in.

**_Copy()_**\
L�hetet��n `Ctrl-C` n�pp�inkomento, eli kopioidaan mahdollisesti valittu teksti leikep�yd�lle. Sulkujen sis��n ei kirjoiteta mit��n.

**_Paste()_**\
L�hetet��n `Ctrl-V` n�pp�inkomento, eli leikep�yd�ll� mahdollisesti oleva teksti liitet��n. Mik�li leikep�yd�ll� on useampi rivi teksti� (eroteltuna rivinvaihdoilla), tai esimerkiksi usempi solu Excelist� (p��llekk�iset solut erotellaan rivinvaihdolla, ja vierekk�iset solut tabulaattorilla) voidaan komennon kanssa valita liitett�v� rivi tai solu. Esim. `Paste(1)` liitt�� leikepoyd�n ensimm�isen rivin/solun, `Paste(2)` toisen jne. Ilman numeroa liitet��n kaikki leikep�yd�n tekstisis�lt� sellaisenaan.

**_TypeText()_**\
Sy�tet��n sulkujen sis�ll� oleva teksti emuloiden n�pp�imist�n painalluksia merkki kerrallaan, eli teksti ilmestyy "hitaasti". Nopeus saattaa hieman vaihdella koneen ja k�ytt�j�rjestelm�n mukaan.

**_PasteText()_**\
Kopioidaan sulkujen sis�ll� oleva teksti leikep�yd�lle, ja liitet��n se kerralla l�hett�m�ll� n�pp�inkomento `Ctrl-V`. Ennen komentoa leikep�yd�ll� mahdollisesti ollut teksti palautetaan leikep�yd�lle komennon j�lkeen.

**_Key()..._**\
L�hetet��n n�pp�imen painallus, n�pp�inyhdistelm� tai teksti emuloiden n�pp�imien painalluksia. Kaikki sulkujen sis�ll� oleva teksti muutetaan automaattisesti pieniksi kirjaimiksi. Mik�li tarvitsee ison kirjaimen, kirjaimen eteen pit�� lis�t� `+`. `+` vastaa `Shift`-n�pp�imen painallusta. `%` vastaa `Alt`-n�pp�imen painallusta ja `^` vastaa `Ctrl` -n�pp�int�. My�s n�pp�imist�n erikoisn�pp�imill� on omat nimet, esim. `Enter` kirjoitetaan `{ENTER}`.

Komennon nappia painamalla avautuu ikkuna, josta voi pudotusvalikosta valita tarvittavan napin nimen, sek� alapuolella on oma valintaruksi `Shift`, `Alt` ja `Ctrl` -nappien merkille. Lis�tietoja komennosta ja siin� k�ytetyist� n�pp�imien nimist� l�ytyy [Microsoftin sivuilta](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.8#remarks).

**_Delay()_**\
Komentojen v�lille voidaan lis�t� taukoja, jotka kirjoitetaan sulkujen sis�lle millisekunteina, eli `1000ms` = 1 sekunti. `Delay()`-komentoa k�ytett�ess� sen p��lle ei en�� lis�t� automaattista `100ms` taukoa, joka normaalisti lis�t��n komentojen v�liin.

**_Pause()_**\
Makron suoritus voidaan laittaa tauolle, kunnes k�ytt�j� p��tt�� jatkaa makroa. Suoritus jatkuu kun painetaan `Pause/Break` -n�pp�int�. Sulkujen sis��n ei kirjoiteta mit��n.

**_StartAgain()_**\
Hypp�� makron alkuun ja ajaa sen uudelleen. T�st� tulee ikuinen looppi, kunnes k�ytt�j� keskeytt�� sen painamalla `Pause/Break`.

**_WindowPosition(X,Y,Monitor)..._**\
Aktiivinen ikkuna voidaan siirt�� tiettyyn kohtaan n�yt�ll�. Tarvitaan mm. jos makron suorituksen aikana avautuu uusi ikkuna johon pit�� sy�tt�� tietoja, mutta ikkuna ei aina aukeakaan samaan kohtaan n�yt�ll�. Koordinaatit toimii samoin kuin `MousePosition(X,Y,Monitor)` -komennossa.

**_WindowPosition(X,Y)..._**\
Aktiivinen ikkuna voidaan siirt�� tiettyyn kohtaan n�yt�ll�. Koordinaatit toimii samoin kuin `MousePosition(X,Y)` -komennossa.

**_WindowSize(Width,Height)_**\
Aktiivisen ikkunan kokoa voidaan tarvittaessa muuttaa. Uusi koko annetaan pikseleiss�, ensin leveys, sitten korkeus.

**_ActivateWindow(Name,Title)..._**\
Voidaan aktivoida tietty ikkuna tietojen sy�tt�� tai siirtely� varten. `Name` -m��re vastaa ohjelman prosessin nime�, eli yleens� sen suoritettavaa exe-tiedostoa. `Title` -m��re taas vastaa ikkunan otsikon teksti�. Molempia m��reit� voidaan k�ytt�� yhdess�, tai haluttaessa vain yht� j�tt�m�ll� toinen tyhj�ksi. Vain yht� m��rett� k�ytett�ess� pilkun tulee kuitenkin olla mukana, sill� tunnistetaan kumpaa m��rett� tarkoitetaan. `Title` -m��reen tekstin� voi olla vain osa otsikon tekstist�. Jos samalla prosessilla on useita ikkunoita auki (esim. monta samaa selainta tai tiedostonhallintaikkunaa) ei oikeaa (tai mit��n) ikkunaa v�ltt�m�tt� saada aktiiviseksi.

Komennon nappia painamalla esiin tulee ikkuna, joka kehottaa aktivoimaan halutun ikkunan ja painamaan `Enter`. T�ll�in ikkunan prosessin ja otsikon nimet lis�t��n automaattisesti komentoon, ja niit� voidaan haluttaessa muokata.

## Lataus

En ota mit��n vastuuta ohjelman mahdollisesti aiheuttamista vahingoista; kukin k�ytt�� ohjelmaa omalla vastuullaan. Toiminta testattu Windows 10 -k�ytt�j�rjestelm�ll�. Vaatimuksena my�s .NET Framework 4.5.2.

**[Lataa uusin versio](https://github.com/arikankainen/macrohotkey-windows/releases)**