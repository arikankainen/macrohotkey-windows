# Macro Hotkey

Macro Hotkeyn tarkoitus on automatisoida usein toistettavia hiirellä tai näppäimistöllä tehtäviä töitä. Sillä voidaan esimerkiksi täyttää lomakkeita tietyillä samoilla tiedoilla, tai vaihtoehtoisesti esimerkiksi Excelistä kopioitavalla sisällöllä. Pääasia on, että työ on toistettavaa ja täytettävät kentät sijaitsevat aina samassa paikassa, tai ovat muuten helposti valittavissa esim. näppäinkomennoilla.

![Macro Hotkey](/docs/main.png)

## Käyttö

Makroja voidaan käynnistää joko `Run`-painikkeella, tai antamalla makrolle oman näppäinyhdistelmän. Näppäinyhdistelmää käytettäessä itse ohjelma voi olla pienennettynä tai piilotettuna tehtäväpalkin ilmoitusalueelle. Makron ollessa käynnissä päänäytön yläreunaan ilmestyy musta ikkuna, joka kertoo arvion makron edistymisestä. Arvio ei kaikissa tapauksissa ole täysin tarkka, koska se lasketaan etukäteen makron sisältämistä komennoista (sama arvio näytetään pääikkunan tilapalkissa kun makro on valittuna). Makron päätyttyä ikkuna häviää ruudulta. Makro voidaan myös lopettaa kesken painamalla näppäinyhdistelmää `Ctrl-Break/Pause` (jos käytössä on läppäri, voi komento olla merkistä riippuen esim. `Fn-Ctrl-B`). Myös makron keskeytys ja jatkaminen on mahdollista painamalla pelkkää `Break/Pause` -näppäintä (läppärissä esim. `Fn-P`).

## Valikot

**_File / Create backup of all macros_**\
Pääikkunassa näkyvä lista makroista on tallennettu ohjelman kanssa samaan kansioon, nimellä `macrohotkey.lst`. Kyseisestä tiedostosta voidaan ottaa helposti varmuuskopioita, jos makrojen tallennuksessa sattuisi menemään jotain pieleen. Varmuuskopiot makroista tallennetaan samaan paikkaan, tiedostonimellä `macrohotkey_backup_2019-12-23_15-31-42.lst` (jossa siis on varmuuskopiohetken päivämäärä). Varmuuskopion palauttaminen onnistuu kun varmuuskopion nimeää oletusnimellä `macrohotkey.lst`.

**_File / Settings_**\
Avataan ohjelman asetukset.

**_File / Help_**\
Avataan nämä ohjeet.

**_File / Exit_**\
Ohjelma suljetaan, vaikka asetuksista olisi valittu että ohjelma "sulkeutuu" tehtäväpalkkin ilmoitusalueelle.

## Asetukset _(General -välilehti)_

![Asetukset](/docs/settings_general.png)

**_Close to tray_**\
Valinnan ollessa päällä ohjelman sulkeminen ikkunan `X`-painikkeesta ei oikeasti sulje ohjelmaa, vaan piilottaa sen kuvakkeeksi tehtäväpälkin ilmoitusalueelle.

**_Start in tray_**\
Ohjelma käynnistetään piilotettuna tehtäväpalkin ilmoitusalueelle.

**_Minimize when using 'Run' button_**\
Ohjelma pienennetään pois tieltä jos makro käynnistetään `Run`-painikkeesta.

**_Remember main window size_**\
Pääikkunan koko muistetaan seuraavan kerran ohjelmaa käynnistettäessä.

**_Remember main window position_**\
Pääikkunan sijainti näytöllä muistetaan seuraavan kerran ohjelmaa käynnistettäessä.

**_Remember editor window size_**\
Makroeditorin koko muistetaan seuraavan kerran editoria avattaessa.

**_Remember editor window position_**\
Makroeditorin sijainti näytöllä muistetaan seuraavan kerran editoria avattaessa.

**_Return mouse to its original position after macro is finished_**\
Makron päätyttyä hiiren kursori palautetaan siihen pisteeseen jossa se oli ennen kuin makro käynnistettiin.

## Asetukset _(Delays -välilehti)_

![Asetukset](/docs/settings_delays.png)

**_Delay on start_**\
Määritetään kuinka paljon makron suorituksen aloittamista viivästytetään kun makro käynnistetään. Esimerkiksi jos viive on nollassa ja makro käynnistetään pikanäppäimellä, saattaa vielä pohjassa olevat pikanäppäimet häiritä makron ensimmäisen komennon suoritusta. Oletusviive on `500ms`.

**_Delay between commands_**\
Jokaisen komennon suorituksen väliin voidaan määrittää tietynpituinen tauko. Mikäli kahden komennon väliin lisätään makroeditorissa taukokomento (_Delay_), jätetään tässä määritelty tauko huomiotta. Oletusviive on `100ms`.

**_Delay before 'Paste' or 'PasteText' commands_**\
'Paste' ja 'PasteText' komento liittää määritellyn tekstin leikepöydän kautta, ja tällä asetuksella määritellään kuinka kauan odotetaan ennenkuin leikepöydälle asetettu teksti liitetään sovellukseen. Jos liittäminen tapahtuu liian nopeasti, sovelluksesta riippuen teksti ei ole vielä valmiina liitettäväksi. Jos liittämisessä on ongelmia, pidennä tätä aikaa. Oletusviive on `300ms`.

**_Delay after 'Paste' or 'PasteText' commands_**\
'Paste' ja 'PasteText' komento liittää määritellyn tekstin leikepöydän kautta, joutuen väliaikaisesti tyhjentämään siellä mahdollisesti ennestään olleen tekstin. Alkuperäinen teksti palautetaan leikepöydälle liittämisen jälkeen, ja tällä asetuksella määritellään kuinka pitkään odotetaan että alkuperäinen teksti palautetaan leikepöydälle. Jos palautus tapahtuu liian nopeasti, sovelluksesta riippuen ei leikepöydän tekstiä ehkä ehditä liittämään sovellukseen. Jos liittämisessä on ongelmia, pidennä tätä aikaa. Oletusviive on `100ms`.

## Makroeditori

![Makroeditori](/docs/macro_editor.png)

### Editorin käyttö

`Name` -kenttään annetaan makron nimi. `Hotkey` -kenttään voidaan määritellä pikanäppäin tai pikanäppäinyhdistelmä, jolla makro käynnistetään. Kentän ollessa aktiivinen (taustaväri on kellertävä), voidaan näppäimistöstä painaa näppäin tai näppäinyhdistelmä. Pikanäppäimessä kannattaa käyttää `Ctrl`, `Shift` tai `Alt`-näppäimiä, sillä jos syötät esim. pelkän kirjaimen `A`, et voi käyttää `A`-kirjainta enää muualla, sillä se käynnistää aina makron. Pikanäppäimen tyhjennys onnistuu, kun kentässä painaa `ESC`-näppäintä.

Itse makro kirjoitetaan isoon nimeämättömään tekstilaatikkoon. Makro koostuu ikkunan oikealta puolelta löytyvistä komennoista, joita voidaan liittää suoraan makroon klikkaamalla ko. komennon painiketta. Komento koostuu aina komennon nimestä, jonka perässä on sulut. Komennoissa isoilla kirjaimilla ei ole merkitystä, mutta paremman luettavuuden takia niiden sanat ovat oletuksena isolla alkukirjaimella. Sulkujen sisään tulee komennosta riippuen esim. hiiren koordinaatit, liitettävä teksti tai tauon pituus. Koordinaatit sisältävää komentoa tuplaklikkaamalla hiiren kursori siirretään kyseisiin koordinaatteihin, jolloin ne on helppo tarkistaa. Komentojen väliin voidaan luettavuuden helpottamiseksi jättää tyhjiä rivejä, sekä omia tilanteeseen liittyviä kommenteja. Kommenttirivit kannattaa aloittaa risuaidalla `#`, jolloin rivin sisältöä ei yritetä suorittaa. Myös oikeita komentoja voidaan väliaikaisesti poistaa käytöstä lisäämällä risuaita rivin alkuun. Mikäli jonkin rivin suorittaminen ei onnistu (esim. kirjoitusvirhe), siirrytään suorittamaan seuraavaa riviä. Makron alkuun lisätään automaattisesti n. `500ms` (puoli sekuntia) tauko, jotta makro ei ala samantien kun sen käynnistävä näppäinyhdistelmä on vielä pohjassa. Samaten makron jokaisen komennon väliin lisätään automaattisesti n. `100ms` tauko.

Ikkunan alalaidasta näkyy hiiren kursorin koordinaatit, joita voi käyttää apuna komennoissa. `Mouse position (Monitor)` kertoo hiiren koordinaatit tietyllä näytöllä. Näytön koordinaatit `0,0` alkaa aina näytön vasemmasta ylälaidasta. `Mouse position (Windows)` kertoo hiiren koordinaatit kun kaikkien näyttöjen ala otetaan huomioon. Normaalisti koordinaatit `0,0` alkaa päänäytön (_Primary display_) vasemmasta ylälaidasta, ja jos ko. näytön vasemmalla puolella on näyttö, menee sen näytön koordinaatit `X`-akselilta miinusmerkkisiksi. `Windows` -koordinaatteja kannattaa käyttää vain jos kaikki tapahtuu päänäytöllä, sillä Windowsin asetuksista näyttöjen pienikin siirtely esim. korkeussuunnassa muuttaa muiden näyttöjen kuin päänäytön koordinaatit. `Monitor` -koordinaatteja käytettäessä `X` ja `Y` -koordinaattien perään lisätään näytön numero, joka näkyy ikkunan alalaidassa (_Monitor number_). Numero ei välttämättä vastaa Windowsin asetusikkunan numerointia näytöille. `Monitor`-koordinaatteja kannattaa käyttää, jos makro käyttää joko useampaa kuin yhtä näyttöä, tai se käyttää jotain muuta kuin päänäyttöä. Tällöin mahdollisen näyttönumeroinnin muuttuessa, on makrosta helppo käydä vain muuttamassa koordinaattien perässä olevat näytön numerot vastaamaan uutta järjestystä, eikä itse koordinaatteja tarvitse muuttaa.

### Komennot

**_MousePosition(X,Y,Monitor)..._**\
Hiiren kursori siirretään tietyn näytön koordinaatteihin. Vastaa makroeditorin `Mouse position (Monitor)` -koordinaatteja ja `Monitor number` -numeroa näytölle.

Komennon nappia painamalla esiin tulee ikkuna, joka kehottaa siirtämään hiiren haluttuun paikkaan näytöllä ja painamaan `Enter`. Tällöin hiiren sen hetkiset koordinaatit syötetään automaattisesti komentoon.

**_MousePosition(X,Y)..._**\
Hiiren kursori siirretään koordinaatteihin joka ottaa huomioon kaikkien näyttöjen alan. Vastaa makroeditorin `Mouse position (Windows)` -koordinaatteja.

Komennon nappia painamalla esiin tulee ikkuna, joka kehottaa siirtämään hiiren haluttuun paikkaan näytöllä ja painamaan `Enter`. Tällöin hiiren sen hetkiset koordinaatit syötetään automaattisesti komentoon.

**_MouseMove(X,Y)_**\
Hiiren kursoria siirretään `X` pikseliä oikealle ja `Y` pikseliä alaspäin. Negatiivisia lukuja käytettäessä vasemmalle tai ylös.

**_MouseClick(Left)_**\
Hiiren vasemman napin klikkaus.

**_MouseClick(Middle)_**\
Hiiren keskimmäisen napin klikkaus.

**_MouseClick(Right)_**\
Hiiren oikean napin klikkaus.

**_MouseDown(Left)_**\
Hiiren vasen nappi painetaan pohjaan, eikä päästetä ylös. Käytetään kun halutaan esim. maalata tekstiä liikuttaen hiirtä nappi pohjassa. Voidaan käyttää myös `Middle` ja `Right` -määreitä.

**_MouseUp(Left)_**\
Hiiren vasen nappi päästetään ylös. Voidaan käyttää myös `Middle` ja `Right` -määreitä.

**_Copy()_**\
Lähetetään `Ctrl-C` näppäinkomento, eli kopioidaan mahdollisesti valittu teksti leikepöydälle. Sulkujen sisään ei kirjoiteta mitään.

**_Paste()_**\
Lähetetään `Ctrl-V` näppäinkomento, eli leikepöydällä mahdollisesti oleva teksti liitetään. Mikäli leikepöydällä on useampi rivi tekstiä (eroteltuna rivinvaihdoilla), tai esimerkiksi usempi solu Excelistä (päällekkäiset solut erotellaan rivinvaihdolla, ja vierekkäiset solut tabulaattorilla) voidaan komennon kanssa valita liitettävä rivi tai solu. Esim. `Paste(1)` liittää leikepoydän ensimmäisen rivin/solun, `Paste(2)` toisen jne. Ilman numeroa liitetään kaikki leikepöydän tekstisisältö sellaisenaan.

**_TypeText()_**\
Syötetään sulkujen sisällä oleva teksti emuloiden näppäimistön painalluksia merkki kerrallaan, eli teksti ilmestyy "hitaasti". Nopeus saattaa hieman vaihdella koneen ja käyttöjärjestelmän mukaan.

**_PasteText()_**\
Kopioidaan sulkujen sisällä oleva teksti leikepöydälle, ja liitetään se kerralla lähettämällä näppäinkomento `Ctrl-V`. Ennen komentoa leikepöydällä mahdollisesti ollut teksti palautetaan leikepöydälle komennon jälkeen.

**_Key()..._**\
Lähetetään näppäimen painallus, näppäinyhdistelmä tai teksti emuloiden näppäimien painalluksia. Kaikki sulkujen sisällä oleva teksti muutetaan automaattisesti pieniksi kirjaimiksi. Mikäli tarvitsee ison kirjaimen, kirjaimen eteen pitää lisätä `+`. `+` vastaa `Shift`-näppäimen painallusta. `%` vastaa `Alt`-näppäimen painallusta ja `^` vastaa `Ctrl` -näppäintä. Myös näppäimistön erikoisnäppäimillä on omat nimet, esim. `Enter` kirjoitetaan `{ENTER}`.

Komennon nappia painamalla avautuu ikkuna, josta voi pudotusvalikosta valita tarvittavan napin nimen, sekä alapuolella on oma valintaruksi `Shift`, `Alt` ja `Ctrl` -nappien merkille. Lisätietoja komennosta ja siinä käytetyistä näppäimien nimistä löytyy [Microsoftin sivuilta](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.8#remarks).

**_Delay()_**\
Komentojen välille voidaan lisätä taukoja, jotka kirjoitetaan sulkujen sisälle millisekunteina, eli `1000ms` = 1 sekunti. `Delay()`-komentoa käytettäessä sen päälle ei enää lisätä automaattista `100ms` taukoa, joka normaalisti lisätään komentojen väliin.

**_Pause()_**\
Makron suoritus voidaan laittaa tauolle, kunnes käyttäjä päättää jatkaa makroa. Suoritus jatkuu kun painetaan `Pause/Break` -näppäintä. Sulkujen sisään ei kirjoiteta mitään.

**_WindowPosition(X,Y,Monitor)..._**\
Aktiivinen ikkuna voidaan siirtää tiettyyn kohtaan näytöllä. Tarvitaan mm. jos makron suorituksen aikana avautuu uusi ikkuna johon pitää syöttää tietoja, mutta ikkuna ei aina aukeakaan samaan kohtaan näytöllä. Koordinaatit toimii samoin kuin `MousePosition(X,Y,Monitor)` -komennossa.

**_WindowPosition(X,Y)..._**\
Aktiivinen ikkuna voidaan siirtää tiettyyn kohtaan näytöllä. Koordinaatit toimii samoin kuin `MousePosition(X,Y)` -komennossa.

**_WindowSize(Width,Height)_**\
Aktiivisen ikkunan kokoa voidaan tarvittaessa muuttaa. Uusi koko annetaan pikseleissä, ensin leveys, sitten korkeus.

**_ActivateWindow(Name,Title)..._**\
Voidaan aktivoida tietty ikkuna tietojen syöttöä tai siirtelyä varten. `Name` -määre vastaa ohjelman prosessin nimeä, eli yleensä sen suoritettavaa exe-tiedostoa. `Title` -määre taas vastaa ikkunan otsikon tekstiä. Molempia määreitä voidaan käyttää yhdessä, tai haluttaessa vain yhtä jättämällä toinen tyhjäksi. Vain yhtä määrettä käytettäessä pilkun tulee kuitenkin olla mukana, sillä tunnistetaan kumpaa määrettä tarkoitetaan. `Title` -määreen tekstinä voi olla vain osa otsikon tekstistä. Jos samalla prosessilla on useita ikkunoita auki (esim. monta samaa selainta tai tiedostonhallintaikkunaa) ei oikeaa (tai mitään) ikkunaa välttämättä saada aktiiviseksi.

Komennon nappia painamalla esiin tulee ikkuna, joka kehottaa aktivoimaan halutun ikkunan ja painamaan `Enter`. Tällöin ikkunan prosessin ja otsikon nimet lisätään automaattisesti komentoon, ja niitä voidaan haluttaessa muokata.

## Lataus

En ota mitään vastuuta ohjelman mahdollisesti aiheuttamista vahingoista; kukin käyttää ohjelmaa omalla vastuullaan. Toiminta testattu Windows 10 -käyttöjärjestelmällä. Vaatimuksena myös .NET Framework 4.5.2.

**[Lataa uusin versio](https://github.com/arikankainen/macrohotkey-windows/releases)**
