using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    public static class URLS
    {
        public static Dictionary<string, string> _websiteProducts = new Dictionary<string, string>
    {

        { "Laptopuri", "https://www.itgalaxy.ro/laptopuri/pagina1/" },
        { "Memorii Laptop", "https://www.itgalaxy.ro/memorii-laptop/pagina1/" },
        { "HDD Laptop", "https://www.itgalaxy.ro/hdd-laptop/pagina1/" },
        { "Unitati Optice", "https://www.itgalaxy.ro/unitati-optice/pagina1/" },
        { "Baterii Laptop", "https://www.itgalaxy.ro/baterii-laptop/pagina1/" },
        { "Incarcatoare Laptop", "https://www.itgalaxy.ro/incarcatoare-laptop/pagina1/" },
        { "Genti si Huse Laptop", "https://www.itgalaxy.ro/genti-si-huse-laptop/pagina1/" },
        { "Standuri Coolere", "https://www.itgalaxy.ro/standuri-coolere/pagina1/" },
        { "Accesorii Laptop", "https://www.itgalaxy.ro/accesorii-laptop/pagina1/" },
        { "Telefoane Mobile", "https://www.itgalaxy.ro/telefoane-mobile/pagina1/" },
        { "Folii Telefon", "https://www.itgalaxy.ro/folii-telefon/pagina1/" },
        { "Huse Telefon", "https://www.itgalaxy.ro/huse-telefon/pagina1/" },
        { "Incarcatoare Telefoane", "https://www.itgalaxy.ro/incarcatoare-telefoane/pagina1/" },
        { "Cabluri de Date", "https://www.itgalaxy.ro/cabluri-de-date/pagina1/" },
        { "Suport Telefon", "https://www.itgalaxy.ro/suport-telefon/pagina1/" },
        { "Baterii Telefon", "https://www.itgalaxy.ro/baterii-telefon/pagina1/" },
        { "Accesorii Telefon", "https://www.itgalaxy.ro/accesorii-telefon/pagina1/" },
        { "Selfie Stick", "https://www.itgalaxy.ro/selfie-stick/pagina1/" },
        { "Acumulator Extern", "https://www.itgalaxy.ro/acumulator-extern/pagina1/" },
        { "Casti Telefon", "https://www.itgalaxy.ro/casti-telefon/pagina1/" },
        { "Tablete", "https://www.itgalaxy.ro/tablete/pagina1/" },
        { "Folii Tablete", "https://www.itgalaxy.ro/folii-tablete/pagina1/" },
        { "Huse Tablete", "https://www.itgalaxy.ro/huse-tablete/pagina1/" },
        { "Cabluri si Adaptoare Tablete", "https://www.itgalaxy.ro/cabluri-si-adaptoare-tablete/pagina1/" },
        { "Accesorii Tablete", "https://www.itgalaxy.ro/accesorii-tablete/pagina1/" },
        { "Tablete Grafice", "https://www.itgalaxy.ro/tablete-grafice/pagina1/" },
        { "Accesorii Tablete Grafice", "https://www.itgalaxy.ro/accesorii-tablete-grafice/pagina1/" },
        { "Ebook Reader", "https://www.itgalaxy.ro/ebook-reader/pagina1/" },
        { "Boxe Portabile", "https://www.itgalaxy.ro/boxe-portabile/pagina1/" },
        { "Telefoane Fixe", "https://www.itgalaxy.ro/telefoane-fixe/pagina1/" },
        { "Centrale Telefonice", "https://www.itgalaxy.ro/centrale-telefonice/pagina1/" },
        { "Desktop PC", "https://www.itgalaxy.ro/desktop-pc/pagina1/" },
{ "All-in-One PC", "https://www.itgalaxy.ro/all-in-one-pc/pagina1/" },
{ "Barebones", "https://www.itgalaxy.ro/barebones/pagina1/" },
{ "Placi de Baza", "https://www.itgalaxy.ro/placi-de-baza/pagina1/" },
{ "Procesoare", "https://www.itgalaxy.ro/procesoare/pagina1/" },
{ "Coolere", "https://www.itgalaxy.ro/coolere/pagina1/" },
{ "Memorii", "https://www.itgalaxy.ro/memorii/pagina1/" },
{ "HDD", "https://www.itgalaxy.ro/hdd/pagina1/" },
{ "SSD", "https://www.itgalaxy.ro/ssd/pagina1/" },
{ "Placi Video", "https://www.itgalaxy.ro/placi-video/pagina1/" },
{ "Placi de Sunet", "https://www.itgalaxy.ro/placi-de-sunet/pagina1/" },
{ "TV Tunere", "https://www.itgalaxy.ro/tv-tunere/pagina1/" },
{ "DVD Writere", "https://www.itgalaxy.ro/dvd-writere/pagina1/" },
{ "Blu-ray", "https://www.itgalaxy.ro/blu-ray/pagina1/" },
{ "Carcase", "https://www.itgalaxy.ro/carcase/pagina1/" },
{ "Surse PC", "https://www.itgalaxy.ro/surse-pc/pagina1/" },
{ "Ventilatoare PC", "https://www.itgalaxy.ro/ventilatoare-pc/pagina1/" },
{ "PC Modding", "https://www.itgalaxy.ro/pc-modding/pagina1/" },
{ "Fan Controlere", "https://www.itgalaxy.ro/fan-controllere/pagina1/" },
{ "Tastaturi", "https://www.itgalaxy.ro/tastaturi/pagina1/" },
{ "Kit Tastatura si Mouse", "https://www.itgalaxy.ro/kit-tastatura-si-mouse/pagina1/" },
{ "Mouse", "https://www.itgalaxy.ro/mouse/pagina1/" },
{ "Mousepad", "https://www.itgalaxy.ro/mousepad/pagina1/" },
{ "Monitoare", "https://www.itgalaxy.ro/monitoare/pagina1/" },
{ "Boxe", "https://www.itgalaxy.ro/boxe/pagina1/" },
{ "Casti", "https://www.itgalaxy.ro/casti/pagina1/" },
{ "Microfoane", "https://www.itgalaxy.ro/microfoane/pagina1/" },
{ "UPS", "https://www.itgalaxy.ro/ups/pagina1/" },
{ "Accesorii UPS", "https://www.itgalaxy.ro/accesorii-ups/pagina1/" },
{ "Memorii USB", "https://www.itgalaxy.ro/memorii-usb/pagina1/" },
{ "Hub USB", "https://www.itgalaxy.ro/hub-usb/pagina1/" },
{ "HDD Extern", "https://www.itgalaxy.ro/hdd-extern/pagina1/" },
{ "Rack-uri HDD", "https://www.itgalaxy.ro/rack-uri-hdd/pagina1/" },
{ "SSD Extern", "https://www.itgalaxy.ro/ssd-extern/pagina1/" },
{ "Medii Optice", "https://www.itgalaxy.ro/medii-optice/pagina1/" },
{ "Conectica Cabluri si Adaptoare", "https://www.itgalaxy.ro/conectica-cabluri-si-adaptoare/pagina1/" },
{ "Sisteme de Operare", "https://www.itgalaxy.ro/sisteme-de-operare/pagina1/" },
{ "Solutii de Securitate", "https://www.itgalaxy.ro/solutii-de-securitate/pagina1/" },
{ "Aplicatii Desktop", "https://www.itgalaxy.ro/aplicatii-desktop/pagina1/" },
{ "Power Station", "https://www.itgalaxy.ro/power-station/pagina1/" },
{ "Accesorii Power Station", "https://www.itgalaxy.ro/accesorii-power-station/pagina1/" },
{ "Camere Web", "https://www.itgalaxy.ro/camere-web/pagina1/" },
{ "Multifunctionale", "https://www.itgalaxy.ro/multifunctionale/pagina1/" },
{ "Imprimante Inkjet", "https://www.itgalaxy.ro/imprimante-inkjet/pagina1/" },
{ "Imprimante Laser Alb-Negru", "https://www.itgalaxy.ro/imprimante-laser-alb-negru/pagina1/" },
{ "Imprimante Laser Color", "https://www.itgalaxy.ro/imprimante-laser-color/pagina1/" },
{ "Imprimante Foto", "https://www.itgalaxy.ro/imprimante-foto/pagina1/" },
{ "Imprimante Termice", "https://www.itgalaxy.ro/imprimante-termice/pagina1/" },
{ "Imprimante 3D", "https://www.itgalaxy.ro/imprimante-3d/pagina1/" },
{ "Matriciale", "https://www.itgalaxy.ro/matriciale/pagina1/" },
{ "Plottere", "https://www.itgalaxy.ro/plottere/pagina1/" },
{ "Scannere", "https://www.itgalaxy.ro/scannere/pagina1/" },
{ "Distrugatoare Documente", "https://www.itgalaxy.ro/distrugatoare-documente/pagina1/" },
{ "Consumabile Imprimanta", "https://www.itgalaxy.ro/consumabile-imprimanta/pagina1/" },
{ "Accesorii Imprimante", "https://www.itgalaxy.ro/accesorii-imprimante/pagina1/" },
{ "Calculatoare de Birou", "https://www.itgalaxy.ro/calculatoare-de-birou/pagina1/" },
{ "Accesorii Birotica", "https://www.itgalaxy.ro/accesorii-birotica/pagina1/" },
{ "Caiete", "https://www.itgalaxy.ro/caiete/pagina1/" },
{ "Instrumente Scris", "https://www.itgalaxy.ro/instrumente-scris/pagina1/" },
{ "Accesorii Scoala", "https://www.itgalaxy.ro/accesorii-scoala/pagina1/" },
{ "Acuarele, Pensule, Blocuri Desen", "https://www.itgalaxy.ro/acuarele-pensule-blocuri-desen/pagina1/" },
{ "Cititoare Coduri Bare", "https://www.itgalaxy.ro/cititoare-coduri-bare/pagina1/" },
{ "Albume Foto", "https://www.itgalaxy.ro/albume-foto/pagina1/" },
{ "Hartie Foto", "https://www.itgalaxy.ro/hartie-foto/pagina1/" },
{ "Aparate Foto Compacte", "https://www.itgalaxy.ro/aparate-foto-compacte/pagina1/" },
{ "Aparate Foto Mirrorless", "https://www.itgalaxy.ro/aparate-foto-mirrorless/pagina1/" },
{ "Aparate Foto DSLR", "https://www.itgalaxy.ro/aparate-foto-dslr/pagina1/" },
{ "Obiective", "https://www.itgalaxy.ro/obiective/pagina1/" },
{ "Filtre Foto", "https://www.itgalaxy.ro/filtre-foto/pagina1/" },
{ "Blitzuri", "https://www.itgalaxy.ro/blitzuri/pagina1/" },
{ "Huse si Genti Foto", "https://www.itgalaxy.ro/huse-si-genti-foto/pagina1/" },
{ "Accesorii Foto Video", "https://www.itgalaxy.ro/accesorii-foto-video/pagina1/" },
{ "Acumulatori si Incarcatoare", "https://www.itgalaxy.ro/acumulatori-si-incarcatoare/pagina1/" },
{ "Camere Video", "https://www.itgalaxy.ro/camere-video/pagina1/" },
{ "Camere Video de Actiune", "https://www.itgalaxy.ro/camere-video-de-actiune/pagina1/" },
{ "Accesorii Camere Video de Actiune", "https://www.itgalaxy.ro/accesorii-camere-video-de-actiune/pagina1/" },
{ "Carduri de Memorie", "https://www.itgalaxy.ro/carduri-de-memorie/pagina1/" },
{ "Cititoare Carduri", "https://www.itgalaxy.ro/cititoare-carduri/pagina1/" },
{ "Rame Foto", "https://www.itgalaxy.ro/rame-foto/pagina1/" },
{ "Trepiede", "https://www.itgalaxy.ro/trepiede/pagina1/" },
{ "Binocluri si Lunete", "https://www.itgalaxy.ro/binocluri-si-lunete/pagina1/" },
{ "Televizoare", "https://www.itgalaxy.ro/televizoare/pagina1/" },
{ "Suport TV", "https://www.itgalaxy.ro/suport-tv/pagina1/" },
{ "Telecomenzi", "https://www.itgalaxy.ro/telecomenzi/pagina1/" },
{ "Videoproiectoare", "https://www.itgalaxy.ro/videoproiectoare/pagina1/" },
{ "Ecrane de Proiectie", "https://www.itgalaxy.ro/ecrane-de-proiectie/pagina1/" },
{ "Accesorii Videoproiectoare", "https://www.itgalaxy.ro/accesorii-videoproiectoare/pagina1/" },
{ "Media Playere", "https://www.itgalaxy.ro/media-playere/pagina1/" },
{ "Table Interactive", "https://www.itgalaxy.ro/table-interactive/pagina1/" },
{ "Sisteme Home Cinema Audio", "https://www.itgalaxy.ro/sisteme-home-cinema-audio/pagina1/" },
{ "DVD si Blu-ray Playere", "https://www.itgalaxy.ro/dvd-si-blu-ray-playere/pagina1/" },
{ "CD Player", "https://www.itgalaxy.ro/cd-player/pagina1/" },
{ "MP3 si MP4 Playere", "https://www.itgalaxy.ro/mp3-si-mp4-playere/pagina1/" },
{ "Reportofoane", "https://www.itgalaxy.ro/reportofoane/pagina1/" },
{ "Radiouri", "https://www.itgalaxy.ro/radiouri/pagina1/" },
{ "Statii Radio CB", "https://www.itgalaxy.ro/statii-radio-cb/pagina1/" },
{ "Accesorii Multimedia", "https://www.itgalaxy.ro/accesorii-multimedia/pagina1/" },
{ "Ochelari VR", "https://www.itgalaxy.ro/ochelari-vr/pagina1/" },
{ "Smartwatch", "https://www.itgalaxy.ro/smartwatch/pagina1/" },
{ "Accesorii Smartwatch", "https://www.itgalaxy.ro/accesorii-smartwatch/pagina1/" },
{ "Bratari Fitness", "https://www.itgalaxy.ro/bratari-fitness/pagina1/" },
{ "Accesorii Bratari Fitness", "https://www.itgalaxy.ro/accesorii-bratari-fitness/pagina1/" },
{ "Drone", "https://www.itgalaxy.ro/drone/pagina1/" },
{ "Accesorii Drone", "https://www.itgalaxy.ro/accesorii-drone/pagina1/" },
{ "Trotinete Electrice", "https://www.itgalaxy.ro/trotinete-electrice/pagina1/" },
{ "Alte Vehicule Electrice", "https://www.itgalaxy.ro/alte-vehicule-electrice/pagina1/" },
{ "Console Gaming", "https://www.itgalaxy.ro/console-gaming/pagina1/" },
{ "Scaune Gaming, Birouri", "https://www.itgalaxy.ro/scaune-gaming-birouri/pagina1/" },
{ "Accesorii Console", "https://www.itgalaxy.ro/accesorii-console/pagina1/" },
{ "Jocuri Consola", "https://www.itgalaxy.ro/jocuri-consola/pagina1/" },
{ "Jocuri PC", "https://www.itgalaxy.ro/jocuri-pc/pagina1/" },
{ "Gamepad", "https://www.itgalaxy.ro/gamepad/pagina1/" },
{ "Joystick", "https://www.itgalaxy.ro/joystick/pagina1/" },
{ "Volane Gaming", "https://www.itgalaxy.ro/volane-gaming/pagina1/" },
{ "Accesorii Gaming", "https://www.itgalaxy.ro/accesorii-gaming/pagina1/" },
{ "Trolere, Genti Voiaj", "https://www.itgalaxy.ro/trolere-genti-voiaj/pagina1/" },
{ "Rucsacuri Drumetie", "https://www.itgalaxy.ro/rucsacuri-drumetie/pagina1/" },
{ "Corturi Camping", "https://www.itgalaxy.ro/corturi-camping/pagina1/" },
{ "Saltele, Paturi Camping", "https://www.itgalaxy.ro/saltele-paturi-camping/pagina1/" },
{ "Saci Dormit", "https://www.itgalaxy.ro/saci-dormit/pagina1/" },
{ "Vesela Camping", "https://www.itgalaxy.ro/vesela-camping/pagina1/" },
{ "Arzatoare Camping", "https://www.itgalaxy.ro/arzatoare-camping/pagina1/" },
{ "Bricege", "https://www.itgalaxy.ro/bricege/pagina1/" },
{ "Lanterne", "https://www.itgalaxy.ro/lanterne/pagina1/" },
{ "Accesorii Camping, Drumetii", "https://www.itgalaxy.ro/accesorii-camping-drumetii/pagina1/" },
{ "Statii Meteo", "https://www.itgalaxy.ro/statii-meteo/pagina1/" },
{ "Lumini Biciclete", "https://www.itgalaxy.ro/lumini-biciclete/pagina1/" },
{ "Accesorii Biciclete", "https://www.itgalaxy.ro/accesorii-biciclete/pagina1/" },
{ "Masini de Spalat Rufe", "https://www.itgalaxy.ro/masini-de-spalat-rufe/pagina1/" },
{ "Uscatoare de Rufe", "https://www.itgalaxy.ro/uscatoare-de-rufe/pagina1/" },
{ "Combine Frigorifice", "https://www.itgalaxy.ro/combine-frigorifice/pagina1/" },
{ "Congelatoare", "https://www.itgalaxy.ro/congelatoare/pagina1/" },
{ "Frigidere", "https://www.itgalaxy.ro/frigidere/pagina1/" },
{ "Lazi Frigorifice", "https://www.itgalaxy.ro/lazi-frigorifice/pagina1/" },
{ "Side by Side", "https://www.itgalaxy.ro/side-by-side/pagina1/" },
{ "Racitoare Vinuri", "https://www.itgalaxy.ro/racitoare-vinuri/pagina1/" },
{ "Plite", "https://www.itgalaxy.ro/plite/pagina1/" },




{ "Cuptoare Incorporabile", "https://www.itgalaxy.ro/cuptoare-incorporabile/pagina1/" },
{ "Cuptoare Electrice", "https://www.itgalaxy.ro/cuptoare-electrice/pagina1/" },
{ "Cuptoare cu Microunde", "https://www.itgalaxy.ro/cuptoare-cu-microunde/pagina1/" },
{ "Aragazuri", "https://www.itgalaxy.ro/aragazuri/pagina1/" },
{ "Hote", "https://www.itgalaxy.ro/hote/pagina1/" },
{ "Masini de Spalat Vase", "https://www.itgalaxy.ro/masini-de-spalat-vase/pagina1/" },
{ "Espressoare Cafea", "https://www.itgalaxy.ro/espressoare-cafea/pagina1/" },
{ "Cafetiere", "https://www.itgalaxy.ro/cafetiere/pagina1/" },
{ "Rasnite Cafea", "https://www.itgalaxy.ro/rasnite-cafea/pagina1/" },
{ "Fierbatoare", "https://www.itgalaxy.ro/fierbatoare/pagina1/" },
{ "Roboti de Bucatarie", "https://www.itgalaxy.ro/roboti-de-bucatarie/pagina1/" },
{ "Multicooker", "https://www.itgalaxy.ro/multicooker/pagina1/" },
{ "Friteuze", "https://www.itgalaxy.ro/friteuze/pagina1/" },
{ "Mixere", "https://www.itgalaxy.ro/mixere/pagina1/" },
{ "Blendere", "https://www.itgalaxy.ro/blendere/pagina1/" },
{ "Storcatoare de Fructe si Legume", "https://www.itgalaxy.ro/storcatoare-de-fructe-si-legume/pagina1/" },
{ "Sandwich Maker", "https://www.itgalaxy.ro/sandwich-maker/pagina1/" },
{ "Gratare Electrice", "https://www.itgalaxy.ro/gratare-electrice/pagina1/" },
{ "Masini de Paine", "https://www.itgalaxy.ro/masini-de-paine/pagina1/" },
{ "Prajitoare de Paine", "https://www.itgalaxy.ro/prajitoare-de-paine/pagina1/" },
{ "Masini de Tocat", "https://www.itgalaxy.ro/masini-de-tocat/pagina1/" },
{ "Feliatoare", "https://www.itgalaxy.ro/feliatoare/pagina1/" },
{ "Tocatoare", "https://www.itgalaxy.ro/tocatoare/pagina1/" },
{ "Aparate de Preparat Desert", "https://www.itgalaxy.ro/aparate-de-preparat-desert/pagina1/" },
{ "Cantare de Bucatarie", "https://www.itgalaxy.ro/cantare-de-bucatarie/pagina1/" },
{ "Aspiratoare", "https://www.itgalaxy.ro/aspiratoare/pagina1/" },
{ "Fiare de Calcat", "https://www.itgalaxy.ro/fiare-de-calcat/pagina1/" },
{ "Diverse Electrocasnice Mici", "https://www.itgalaxy.ro/diverse-electrocasnice-mici/pagina1/" },
{ "Accesorii Electrocasnice", "https://www.itgalaxy.ro/accesorii-electrocasnice/pagina1/" },
{ "Vitrine Frigorifice", "https://www.itgalaxy.ro/vitrine-frigorifice/pagina1/" },
{ "Parfumuri", "https://www.itgalaxy.ro/parfumuri/pagina1/" },
{ "Pachete Cadouri", "https://www.itgalaxy.ro/pachete-cadouri/pagina1/" },
{ "Articole Ortopedice", "https://www.itgalaxy.ro/articole-ortopedice/pagina1/" },
{ "Epilatoare", "https://www.itgalaxy.ro/epilatoare/pagina1/" },
{ "Accesorii Epilatoare", "https://www.itgalaxy.ro/accesorii-epilatoare/pagina1/" },
{ "Aparate Masaj", "https://www.itgalaxy.ro/aparate-masaj/pagina1/" },
{ "Masini de Tuns", "https://www.itgalaxy.ro/masini-de-tuns/pagina1/" },
{ "Aparate de Ras", "https://www.itgalaxy.ro/aparate-de-ras/pagina1/" },
{ "Accesorii Aparate de Ras", "https://www.itgalaxy.ro/accesorii-aparate-de-ras/pagina1/" },
{ "Perii de Par", "https://www.itgalaxy.ro/perii-de-par/pagina1/" },
{ "Placi de Indreptat Parul", "https://www.itgalaxy.ro/placi-de-indreptat-parul/pagina1/" },
{ "Ondulatoare", "https://www.itgalaxy.ro/ondulatoare/pagina1/" },
{ "Uscatoare de Par", "https://www.itgalaxy.ro/uscatoare-de-par/pagina1/" },
{ "Ingrijire Orala", "https://www.itgalaxy.ro/ingrijire-orala/pagina1/" },
{ "Accesorii Ingrijire Orala", "https://www.itgalaxy.ro/accesorii-ingrijire-orala/pagina1/" },
{ "Articole Manichiura Pedichiura", "https://www.itgalaxy.ro/articole-manichiura-pedichiura/pagina1/" },
{ "Tensiometre", "https://www.itgalaxy.ro/tensiometre/pagina1/" },
{ "Glucometre", "https://www.itgalaxy.ro/glucometre/pagina1/" },
{ "Termometre", "https://www.itgalaxy.ro/termometre/pagina1/" },
{ "Cantare Corporale", "https://www.itgalaxy.ro/cantare-corporale/pagina1/" },
{ "Incalzitoare Corporale", "https://www.itgalaxy.ro/incalzitoare-corporale/pagina1/" },
{ "Articole Fitness", "https://www.itgalaxy.ro/articole-fitness/pagina1/" },
{ "Intretinere Ingrijire Corporala", "https://www.itgalaxy.ro/intretinere-ingrijire-corporala/pagina1/" },
{ "Sampon si Balsam", "https://www.itgalaxy.ro/sampon-si-balsam/pagina1/" },
{ "Vopsea de Par si Accesorii", "https://www.itgalaxy.ro/vopsea-de-par-si-accesorii/pagina1/" },
{ "Sapun si Gel de Dus", "https://www.itgalaxy.ro/sapun-si-gel-de-dus/pagina1/" },
{ "Diverse Cosmetice", "https://www.itgalaxy.ro/diverse-cosmetice/pagina1/" },
{ "Absorbante", "https://www.itgalaxy.ro/absorbante/pagina1/" },
{ "Produse de Prim Ajutor", "https://www.itgalaxy.ro/produse-de-prim-ajutor/pagina1/" },
{ "Masti Manusi Chirurgicale Dezinfectant", "https://www.itgalaxy.ro/masti-manusi-chirurgicale-dezinfectant/pagina1/" },
{ "Foarfeci", "https://www.itgalaxy.ro/foarfeci/pagina1/" },
{ "Oglinzi Cosmetice", "https://www.itgalaxy.ro/oglinzi-cosmetice/pagina1/" },
{ "Geluri Dus", "https://www.itgalaxy.ro/geluri-dus/pagina1/" },
{ "Palete Tenis Masa", "https://www.itgalaxy.ro/palete-tenis-masa/pagina1/" },
{ "Mingi", "https://www.itgalaxy.ro/mingi/pagina1/" },
{ "Biciclete", "https://www.itgalaxy.ro/biciclete/pagina1/" },
{ "Scaune Auto Copii", "https://www.itgalaxy.ro/scaune-auto-copii/pagina1/" },
{ "Carucioare Copii", "https://www.itgalaxy.ro/carucioare-copii/pagina1/" },
{ "Triciclete Copii", "https://www.itgalaxy.ro/triciclete-copii/pagina1/" },
{ "Biciclete Copii", "https://www.itgalaxy.ro/biciclete-copii/pagina1/" },
{ "Trotinete", "https://www.itgalaxy.ro/trotinete/pagina1/" },
{ "Paturi Copii", "https://www.itgalaxy.ro/paturi-copii/pagina1/" },
{ "Lenjerii si Huse Patut", "https://www.itgalaxy.ro/lenjerii-si-huse-patut/pagina1/" },
{ "Marsupii Bebelusi", "https://www.itgalaxy.ro/marsupii-bebelusi/pagina1/" },
{ "Balansoare Leagane Hamace Copii", "https://www.itgalaxy.ro/balansoare-leagane-hamace-copii/pagina1/" },
{ "Accesorii Baie Copii", "https://www.itgalaxy.ro/accesorii-baie-copii/pagina1/" },
{ "Saci de Dormit Bebe si Copii", "https://www.itgalaxy.ro/saci-de-dormit-bebe-si-copii/pagina1/" },
{ "Jucarii", "https://www.itgalaxy.ro/jucarii/pagina1/" },
{ "Seturi de Constructie", "https://www.itgalaxy.ro/seturi-de-constructie/pagina1/" },
{ "Machete", "https://www.itgalaxy.ro/machete/pagina1/" },
{ "LEGO", "https://www.itgalaxy.ro/lego/pagina1/" },
{ "Cereale Copii", "https://www.itgalaxy.ro/cereale-copii/pagina1/" },
{ "Monitorizare Bebelusi", "https://www.itgalaxy.ro/monitorizare-bebelusi/pagina1/" },
{ "Scutece", "https://www.itgalaxy.ro/scutece/pagina1/" },
{ "Biberoane", "https://www.itgalaxy.ro/biberoane/pagina1/" },
{ "Alimentatie Bebe Accesorii", "https://www.itgalaxy.ro/alimentatie-bebe-accesorii/pagina1/" },
{ "Premergatoare", "https://www.itgalaxy.ro/premergatoare/pagina1/" },
{ "Suzete", "https://www.itgalaxy.ro/suzete/pagina1/" },
{ "Tetine", "https://www.itgalaxy.ro/tetine/pagina1/" },
{ "Pompe de San", "https://www.itgalaxy.ro/pompe-de-san/pagina1/" },
{ "Accesorii Alaptare", "https://www.itgalaxy.ro/accesorii-alaptare/pagina1/" },
{ "Tarc Copii", "https://www.itgalaxy.ro/tarc-copii/pagina1/" },
{ "Piscine Copii", "https://www.itgalaxy.ro/piscine-copii/pagina1/" },
{ "Scaune de Masa Bebelusi", "https://www.itgalaxy.ro/scaune-de-masa-bebelusi/pagina1/" },
{ "Accesorii Camera Copii", "https://www.itgalaxy.ro/accesorii-camera-copii/pagina1/" },
{ "Tampoane San", "https://www.itgalaxy.ro/tampoane-san/pagina1/" },
{ "Puzzle", "https://www.itgalaxy.ro/puzzle/pagina1/" },
{ "Tobogane", "https://www.itgalaxy.ro/tobogane/pagina1/" },
{ "Carusele Patut", "https://www.itgalaxy.ro/carusele-patut/pagina1/" },
{ "Figurine", "https://www.itgalaxy.ro/figurine/pagina1/" },
{ "Papusi", "https://www.itgalaxy.ro/papusi/pagina1/" },
{ "Masinute", "https://www.itgalaxy.ro/masinute/pagina1/" },
{ "Centre Activitati", "https://www.itgalaxy.ro/centre-activitati/pagina1/" },
{ "Jocuri Societate", "https://www.itgalaxy.ro/jocuri-societate/pagina1/" },
{ "Colaci Ochelari Accesorii Inot", "https://www.itgalaxy.ro/colaci-ochelari-accesorii-inot/pagina1/" },
{ "Trambuline", "https://www.itgalaxy.ro/trambuline/pagina1/" },
{ "Aparate Aer Conditionat", "https://www.itgalaxy.ro/aparate-aer-conditionat/pagina1/" },
{ "Boilere", "https://www.itgalaxy.ro/boilere/pagina1/" },
{ "Centrale Termice", "https://www.itgalaxy.ro/centrale-termice/pagina1/" },
{ "Pompe Caldura", "https://www.itgalaxy.ro/pompe-caldura/pagina1/" },
{ "Aeroterme", "https://www.itgalaxy.ro/aeroterme/pagina1/" },
{ "Radiatoare", "https://www.itgalaxy.ro/radiatoare/pagina1/" },
{ "Calorifere", "https://www.itgalaxy.ro/calorifere/pagina1/" },
{ "Ventilatoare de Camera", "https://www.itgalaxy.ro/ventilatoare-de-camera/pagina1/" },
{ "Umidificatoare", "https://www.itgalaxy.ro/umidificatoare/pagina1/" },
{ "Dezumidificatoare", "https://www.itgalaxy.ro/dezumidificatoare/pagina1/" },
{ "Purificatoare de Aer", "https://www.itgalaxy.ro/purificatoare-de-aer/pagina1/" },
{ "Accesorii Climatizare", "https://www.itgalaxy.ro/accesorii-climatizare/pagina1/" },
{ "Termostate", "https://www.itgalaxy.ro/termostate/pagina1/" },
{ "Compresoare", "https://www.itgalaxy.ro/compresoare/pagina1/" },
{ "Motocoase", "https://www.itgalaxy.ro/motocoase/pagina1/" },
{ "Masini de Tuns Iarba", "https://www.itgalaxy.ro/masini-de-tuns-iarba/pagina1/" },
{ "Foarfece Gradinarit", "https://www.itgalaxy.ro/foarfece-gradinarit/pagina1/" },
{ "Motosape", "https://www.itgalaxy.ro/motosape/pagina1/" },
{ "Suflante Frunze", "https://www.itgalaxy.ro/suflante-frunze/pagina1/" },
{ "Aparate de Spalat cu Presiune", "https://www.itgalaxy.ro/aparate-de-spalat-cu-presiune/pagina1/" },
{ "Pompe Apa", "https://www.itgalaxy.ro/pompe-apa/pagina1/" },
{ "Hidrofoare", "https://www.itgalaxy.ro/hidrofoare/pagina1/" },
{ "Statii Dedurizare Tratare Apa", "https://www.itgalaxy.ro/statii-dedurizare-tratare-apa/pagina1/" },
{ "Filtre Apa si Accesorii", "https://www.itgalaxy.ro/filtre-apa-si-accesorii/pagina1/" },
{ "Generatoare Curent", "https://www.itgalaxy.ro/generatoare-curent/pagina1/" },
{ "Freze de Zapada", "https://www.itgalaxy.ro/freze-de-zapada/pagina1/" },
{ "Mori Electrice", "https://www.itgalaxy.ro/mori-electrice/pagina1/" },
{ "Betoniere", "https://www.itgalaxy.ro/betoniere/pagina1/" },
{ "Roabe", "https://www.itgalaxy.ro/roabe/pagina1/" },
{ "Lacate", "https://www.itgalaxy.ro/lacate/pagina1/" },
{ "Seifuri", "https://www.itgalaxy.ro/seifuri/pagina1/" },
{ "Reflectoare Panouri LED", "https://www.itgalaxy.ro/reflectoare-panouri-led/pagina1/" },
{ "Sisteme Panouri Solare", "https://www.itgalaxy.ro/sisteme-panouri-solare/pagina1/" },
{ "Accesorii Panouri Solare", "https://www.itgalaxy.ro/accesorii-panouri-solare/pagina1/" },
{ "Veioze Lampi", "https://www.itgalaxy.ro/veioze-lampi/pagina1/" },
{ "Lustre", "https://www.itgalaxy.ro/lustre/pagina1/" },
{ "Becuri", "https://www.itgalaxy.ro/becuri/pagina1/" },
{ "Prize si Prelungitoare", "https://www.itgalaxy.ro/prize-si-prelungitoare/pagina1/" },
{ "Intrerupatoare", "https://www.itgalaxy.ro/intrerupatoare/pagina1/" },
{ "Accesorii Prize Intrerupatoare", "https://www.itgalaxy.ro/accesorii-prize-intrerupatoare/pagina1/" },
{ "Chiuvete", "https://www.itgalaxy.ro/chiuvete/pagina1/" },
{ "Baterii Baie", "https://www.itgalaxy.ro/baterii-baie/pagina1/" },
{ "Baterii Bucatarie", "https://www.itgalaxy.ro/baterii-bucatarie/pagina1/" },
{ "Tacamuri si Ustensile Gatit", "https://www.itgalaxy.ro/tacamuri-si-ustensile-gatit/pagina1/" },
{ "Ibrice", "https://www.itgalaxy.ro/ibrice/pagina1/" },
{ "Tigai", "https://www.itgalaxy.ro/tigai/pagina1/" },
{ "Oale si Cratite", "https://www.itgalaxy.ro/oale-si-cratite/pagina1/" },
{ "Cutite", "https://www.itgalaxy.ro/cutite/pagina1/" },
{ "Tavi", "https://www.itgalaxy.ro/tavi/pagina1/" },
{ "Accesorii Bucatarie", "https://www.itgalaxy.ro/accesorii-bucatarie/pagina1/" },
{ "Saltele Pat", "https://www.itgalaxy.ro/saltele-pat/pagina1/" },
{ "Lenjerii Pat", "https://www.itgalaxy.ro/lenjerii-pat/pagina1/" },
{ "Perne", "https://www.itgalaxy.ro/perne/pagina1/" },
{ "Prosoape", "https://www.itgalaxy.ro/prosoape/pagina1/" },
{ "Curatenie si Intretinere", "https://www.itgalaxy.ro/curatenie-si-intretinere/pagina1/" },
{ "Detergenti si Balsam", "https://www.itgalaxy.ro/detergenti-si-balsam/pagina1/" },
{ "Oferta Diversa Casa Gradina", "https://www.itgalaxy.ro/oferta-diversa-casa-gradina/pagina1/" },
{ "Aparate Stropit Gradina", "https://www.itgalaxy.ro/aparate-stropit-gradina/pagina1/" },
{ "Canapele", "https://www.itgalaxy.ro/canapele/pagina1/" },
{ "Fotolii", "https://www.itgalaxy.ro/fotolii/pagina1/" },
{ "Aparate Curatat Abur", "https://www.itgalaxy.ro/aparate-curatat-abur/pagina1/" },
{ "Mopuri Maturi Galeti", "https://www.itgalaxy.ro/mopuri-maturi-galeti/pagina1/" },
{ "Gratare Gradina", "https://www.itgalaxy.ro/gratare-gradina/pagina1/" },
{ "Covoare", "https://www.itgalaxy.ro/covoare/pagina1/" },
{ "Scaune", "https://www.itgalaxy.ro/scaune/pagina1/" },
{ "Aparate de Sudura", "https://www.itgalaxy.ro/aparate-de-sudura/pagina1/" },
{ "Accesorii Sudura", "https://www.itgalaxy.ro/accesorii-sudura/pagina1/" },
{ "Aparate Taiere cu Plasma", "https://www.itgalaxy.ro/aparate-taiere-cu-plasma/pagina1/" },
{ "Roto­per­cu­toa­re", "https://www.itgalaxy.ro/rotopercutoare/pagina1/" },
{ "Masini de Gaurit", "https://www.itgalaxy.ro/masini-de-gaurit/pagina1/" },
{ "Polizoare", "https://www.itgalaxy.ro/polizoare/pagina1/" },
{ "Fierastraie Electrice", "https://www.itgalaxy.ro/fierastraie-electrice/pagina1/" },
{ "Surubelnite", "https://www.itgalaxy.ro/surubelnite/pagina1/" },
{ "Masini de Cusut", "https://www.itgalaxy.ro/masini-de-cusut/pagina1/" },
{ "Accesorii Masini de Cusut", "https://www.itgalaxy.ro/accesorii-masini-de-cusut/pagina1/" },
{ "Te­vi Ac­ce­so­rii", "https://www.itgalaxy.ro/tevi-accesorii/pagina1/" },
{ "Routere Wireless", "https://www.itgalaxy.ro/routere-wireless/pagina1/" },
{ "Routere", "https://www.itgalaxy.ro/routere/pagina1/" },
{ "Switch-uri", "https://www.itgalaxy.ro/switch-uri/pagina1/" },
{ "Bridge Range Extender", "https://www.itgalaxy.ro/bridge-range-extender/pagina1/" },
{ "Puncte de Acces", "https://www.itgalaxy.ro/puncte-de-acces/pagina1/" },
{ "Placi de Retea", "https://www.itgalaxy.ro/placi-de-retea/pagina1/" },
{ "Placi de Retea Wireless", "https://www.itgalaxy.ro/placi-de-retea-wireless/pagina1/" },
{ "Adaptoare Wireless", "https://www.itgalaxy.ro/adaptoare-wireless/pagina1/" },
{ "Network Attached Storage", "https://www.itgalaxy.ro/network-attached-storage/pagina1/" },
{ "Powerline", "https://www.itgalaxy.ro/powerline/pagina1/" },
{ "PDU", "https://www.itgalaxy.ro/pdu/pagina1/" },
{ "KVM", "https://www.itgalaxy.ro/kvm/pagina1/" },
{ "Media Convertoare", "https://www.itgalaxy.ro/media-convertoare/pagina1/" },
{ "Sisteme de Alarma", "https://www.itgalaxy.ro/sisteme-de-alarma/pagina1/" },
{ "Senzori", "https://www.itgalaxy.ro/senzori/pagina1/" },
{ "Camere Supraveghere", "https://www.itgalaxy.ro/camere-supraveghere/pagina1/" },
{ "DVR", "https://www.itgalaxy.ro/dvr/pagina1/" },
{ "Antene", "https://www.itgalaxy.ro/antene/pagina1/" },
{ "Accesorii Supraveghere", "https://www.itgalaxy.ro/accesorii-supraveghere/pagina1/" },
{ "Servere", "https://www.itgalaxy.ro/servere/pagina1/" },
{ "Placi de Baza Server", "https://www.itgalaxy.ro/placi-de-baza-server/pagina1/" },
{ "Procesoare Server", "https://www.itgalaxy.ro/procesoare-server/pagina1/" },
{ "Memorii Server", "https://www.itgalaxy.ro/memorii-server/pagina1/" },
{ "HDD Server", "https://www.itgalaxy.ro/hdd-server/pagina1/" },
{ "SSD Server", "https://www.itgalaxy.ro/ssd-server/pagina1/" },
{ "Carcase Server", "https://www.itgalaxy.ro/carcase-server/pagina1/" },
{ "Surse Server", "https://www.itgalaxy.ro/surse-server/pagina1/" },
{ "Sisteme de Operare Server", "https://www.itgalaxy.ro/sisteme-de-operare-server/pagina1/" },
{ "Accesorii Servere", "https://www.itgalaxy.ro/accesorii-servere/pagina1/" },
{ "Accesorii Retele", "https://www.itgalaxy.ro/accesorii-retelistica/pagina1/" },
{ "Cabinete Metalice", "https://www.itgalaxy.ro/cabinete-metalice/pagina1/" },
{ "Accesorii Cabinete Metalice", "https://www.itgalaxy.ro/accesorii-cabinete-metalice/pagina1/" },
{ "Boxe Auto", "https://www.itgalaxy.ro/boxe-auto/pagina1/" },
{ "Subwoofer Auto", "https://www.itgalaxy.ro/subwoofer-auto/pagina1/" },
{ "Amplificatoare Auto", "https://www.itgalaxy.ro/amplificatoare-auto/pagina1/" },
{ "Player Auto", "https://www.itgalaxy.ro/player-auto/pagina1/" },
{ "Frigidere Auto", "https://www.itgalaxy.ro/frigidere-auto/pagina1/" },
{ "Camere Auto DVR", "https://www.itgalaxy.ro/camere-auto-dvr/pagina1/" },
{ "Anvelope", "https://www.itgalaxy.ro/anvelope/pagina1/" },
{ "Jante", "https://www.itgalaxy.ro/jante/pagina1/" },
{ "Redresoare Auto", "https://www.itgalaxy.ro/redresoare-auto/pagina1/" },
{ "Invertoare Auto", "https://www.itgalaxy.ro/invertoare-auto/pagina1/" },
{ "Roboti Pornire", "https://www.itgalaxy.ro/roboti-pornire/pagina1/" },
{ "Monitoare Auto", "https://www.itgalaxy.ro/monitoare-auto/pagina1/" },
{ "GPS", "https://www.itgalaxy.ro/gps/pagina1/" },
{ "Suporturi Auto Biciclete Ski Snowboard", "https://www.itgalaxy.ro/suporturi-auto-biciclete-ski-snowboard/pagina1/" },
{ "Aspiratoare Auto", "https://www.itgalaxy.ro/aspiratoare-auto/pagina1/" },
{ "Cutii Portbagaj Auto", "https://www.itgalaxy.ro/cutii-portbagaj-auto/pagina1/" },
{ "Becuri Auto", "https://www.itgalaxy.ro/becuri-auto/pagina1/" },
{ "Odorizante Auto", "https://www.itgalaxy.ro/odorizante-auto/pagina1/" },
{ "Accesorii Auto", "https://www.itgalaxy.ro/accesorii-auto/pagina1/" },
{ "Modulatoare FM", "https://www.itgalaxy.ro/modulatoare-fm/pagina1/" },
{ "Compresoare Auto", "https://www.itgalaxy.ro/compresoare-auto/pagina1/" }

    };
    }
    /*public static string UrlDispenser(string selection)
    {
        switch (selection)
        {
            case "Laptopuri":
                return "https://www.itgalaxy.ro/laptopuri/pagina1/";
            case "Memorii Laptop":
                return "https://www.itgalaxy.ro/memorii-laptop/pagina1/";
            case "HDD Laptop":
                return "https://www.itgalaxy.ro/hdd-laptop/pagina1/";
            case "Unitati Optice":
                return "https://www.itgalaxy.ro/unitati-optice/pagina1/";
            case "Baterii Laptop":
                return "https://www.itgalaxy.ro/baterii-laptop/pagina1/";
            case "Incarcatoare Laptop":
                return "https://www.itgalaxy.ro/incarcatoare-laptop/pagina1/";
            case "Genti si Huse Laptop":
                return "https://www.itgalaxy.ro/genti-si-huse-laptop/pagina1/";
            case "Standuri Coolere":
                return "https://www.itgalaxy.ro/standuri-coolere/pagina1/";
            case "Accesorii Laptop":
                return "https://www.itgalaxy.ro/accesorii-laptop/pagina1/";
            case "Telefoane Mobile":
                return "https://www.itgalaxy.ro/telefoane-mobile/pagina1/";
            case "Folii Telefon":
                return "https://www.itgalaxy.ro/folii-telefon/pagina1/";
            case "Huse Telefon":
                return "https://www.itgalaxy.ro/huse-telefon/pagina1/";
            case "Incarcatoare Telefoane":
                return "https://www.itgalaxy.ro/incarcatoare-telefoane/pagina1/";
            case "Cabluri de Date":
                return "https://www.itgalaxy.ro/cabluri-de-date/pagina1/";
            case "Suport Telefon":
                return "https://www.itgalaxy.ro/suport-telefon/pagina1/";
            case "Baterii Telefon":
                return "https://www.itgalaxy.ro/baterii-telefon/pagina1/";
            case "Accesorii Telefon":
                return "https://www.itgalaxy.ro/accesorii-telefon/pagina1/";
            case "Selfie Stick":
                return "https://www.itgalaxy.ro/selfie-stick/pagina1/";
            case "Acumulator Extern":
                return "https://www.itgalaxy.ro/acumulator-extern/pagina1/";
            case "Casti Telefon":
                return "https://www.itgalaxy.ro/casti-telefon/pagina1/";
            case "Tablete":
                return "https://www.itgalaxy.ro/tablete/pagina1/";
            case "Folii Tablete":
                return "https://www.itgalaxy.ro/folii-tablete/pagina1/";
            case "Huse Tablete":
                return "https://www.itgalaxy.ro/huse-tablete/pagina1/";
            case "Cabluri si Adaptoare Tablete":
                return "https://www.itgalaxy.ro/cabluri-si-adaptoare-tablete/pagina1/";
            case "Accesorii Tablete":
                return "https://www.itgalaxy.ro/accesorii-tablete/pagina1/";
            case "Tablete Grafice":
                return "https://www.itgalaxy.ro/tablete-grafice/pagina1/";
            case "Accesorii Tablete Grafice":
                return "https://www.itgalaxy.ro/accesorii-tablete-grafice/pagina1/";
            case "Ebook Reader":
                return "https://www.itgalaxy.ro/ebook-reader/pagina1/";
            case "Boxe Portabile":
                return "https://www.itgalaxy.ro/boxe-portabile/pagina1/";
            case "Telefoane Fixe":
                return "https://www.itgalaxy.ro/telefoane-fixe/pagina1/";
            case "Centrale Telefonice":
                return "https://www.itgalaxy.ro/centrale-telefonice/pagina1/";
            case "Desktop PC":
                return "https://www.itgalaxy.ro/desktop-pc/pagina1/";
            case "All-in-One PC":
                return "https://www.itgalaxy.ro/all-in-one-pc/pagina1/";
            case "Barebones":
                return "https://www.itgalaxy.ro/barebones/pagina1/";
            case "Placi de Baza":
                return "https://www.itgalaxy.ro/placi-de-baza/pagina1/";
            case "Procesoare":
                return "https://www.itgalaxy.ro/procesoare/pagina1/";
            case "Coolere":
                return "https://www.itgalaxy.ro/coolere/pagina1/";
            case "Memorii":
                return "https://www.itgalaxy.ro/memorii/pagina1/";
            case "HDD":
                return "https://www.itgalaxy.ro/hdd/pagina1/";
            case "SSD":
                return "https://www.itgalaxy.ro/ssd/pagina1/";
            case "Placi Video":
                return "https://www.itgalaxy.ro/placi-video/pagina1/";
            case "Placi de Sunet":
                return "https://www.itgalaxy.ro/placi-de-sunet/pagina1/";
            case "TV Tunere":
                return "https://www.itgalaxy.ro/tv-tunere/pagina1/";
            case "DVD Writere":
                return "https://www.itgalaxy.ro/dvd-writere/pagina1/";
            case "Blu-ray":
                return "https://www.itgalaxy.ro/blu-ray/pagina1/";
            case "Carcase":
                return "https://www.itgalaxy.ro/carcase/pagina1/";
            case "Surse PC":
                return "https://www.itgalaxy.ro/surse-pc/pagina1/";
            case "Ventilatoare PC":
                return "https://www.itgalaxy.ro/ventilatoare-pc/pagina1/";
            case "PC Modding":
                return "https://www.itgalaxy.ro/pc-modding/pagina1/";
            case "Fan Controller":
                return "https://www.itgalaxy.ro/fan-controllere/pagina1/";
            case "Tastaturi":
                return "https://www.itgalaxy.ro/tastaturi/pagina1/";
            case "Kit Tastatura si Mouse":
                return "https://www.itgalaxy.ro/kit-tastatura-si-mouse/pagina1/";
            case "Mouse":
                return "https://www.itgalaxy.ro/mouse/pagina1/";
            case "Mousepad":
                return "https://www.itgalaxy.ro/mousepad/pagina1/";
            case "Monitoare":
                return "https://www.itgalaxy.ro/monitoare/pagina1/";
            case "Boxe":
                return "https://www.itgalaxy.ro/boxe/pagina1/";
            case "Casti":
                return "https://www.itgalaxy.ro/casti/pagina1/";
            case "Microfoane":
                return "https://www.itgalaxy.ro/microfoane/pagina1/";
            case "UPS":
                return "https://www.itgalaxy.ro/ups/pagina1/";
            case "Accesorii UPS":
                return "https://www.itgalaxy.ro/accesorii-ups/pagina1/";
            case "Memorii USB":
                return "https://www.itgalaxy.ro/memorii-usb/pagina1/";
            case "Hub USB":
                return "https://www.itgalaxy.ro/hub-usb/pagina1/";
            case "HDD Extern":
                return "https://www.itgalaxy.ro/hdd-extern/pagina1/";
            case "Rack-uri HDD":
                return "https://www.itgalaxy.ro/rack-uri-hdd/pagina1/";
            case "SSD Extern":
                return "https://www.itgalaxy.ro/ssd-extern/pagina1/";
            case "Medii Optice":
                return "https://www.itgalaxy.ro/medii-optice/pagina1/";
            case "Conectica, Cabluri si Adaptoare":
                return "https://www.itgalaxy.ro/conectica-cabluri-si-adaptoare/pagina1/";
            case "Sisteme de Operare":
                return "https://www.itgalaxy.ro/sisteme-de-operare/pagina1/";
            case "Solutii de Securitate":
                return "https://www.itgalaxy.ro/solutii-de-securitate/pagina1/";
            case "Aplicatii Desktop":
                return "https://www.itgalaxy.ro/aplicatii-desktop/pagina1/";
            case "Power Station":
                return "https://www.itgalaxy.ro/power-station/pagina1/";
            case "Accesorii Power Station":
                return "https://www.itgalaxy.ro/accesorii-power-station/pagina1/";
            case "Camere Web":
                return "https://www.itgalaxy.ro/camere-web/pagina1/";
            case "Multifunctionale":
                return "https://www.itgalaxy.ro/multifunctionale/pagina1/";
            case "Imprimante Inkjet":
                return "https://www.itgalaxy.ro/imprimante-inkjet/pagina1/";
            case "Imprimante Laser Alb-Negru":
                return "https://www.itgalaxy.ro/imprimante-laser-alb-negru/pagina1/";
            case "Imprimante Laser Color":
                return "https://www.itgalaxy.ro/imprimante-laser-color/pagina1/";
            case "Imprimante Foto":
                return "https://www.itgalaxy.ro/imprimante-foto/pagina1/";
            case "Imprimante Termice":
                return "https://www.itgalaxy.ro/imprimante-termice/pagina1/";
            case "Imprimante 3D":
                return "https://www.itgalaxy.ro/imprimante-3d/pagina1/";
            case "Matriciale":
                return "https://www.itgalaxy.ro/matriciale/pagina1/";
            case "Plottere":
                return "https://www.itgalaxy.ro/plottere/pagina1/";
            case "Scannere":
                return "https://www.itgalaxy.ro/scannere/pagina1/";
            case "Distrugatoare Documente":
                return "https://www.itgalaxy.ro/distrugatoare-documente/pagina1/";
            case "Consumabile Imprimanta":
                return "https://www.itgalaxy.ro/consumabile-imprimanta/pagina1/";
            case "Accesorii Imprimante":
                return "https://www.itgalaxy.ro/accesorii-imprimante/pagina1/";
            case "Calculatoare de Birou":
                return "https://www.itgalaxy.ro/calculatoare-de-birou/pagina1/";
            case "Accesorii Birotica":
                return "https://www.itgalaxy.ro/accesorii-birotica/pagina1/";
            case "Caiete":
                return "https://www.itgalaxy.ro/caiete/pagina1/";
            case "Instrumente Scris":
                return "https://www.itgalaxy.ro/instrumente-scris/pagina1/";
            case "Accesorii Scoala":
                return "https://www.itgalaxy.ro/accesorii-scoala/pagina1/";
            case "Acuarele, Pensule, Blocuri Desen":
                return "https://www.itgalaxy.ro/acuarele-pensule-blocuri-desen/pagina1/";
            case "Cititoare Coduri Bare":
                return "https://www.itgalaxy.ro/cititoare-coduri-bare/pagina1/";
            case "Albume Foto":
                return "https://www.itgalaxy.ro/albume-foto/pagina1/";
            case "Hartie Foto":
                return "https://www.itgalaxy.ro/hartie-foto/pagina1/";
            case "Aparate Foto Compacte":
                return "https://www.itgalaxy.ro/aparate-foto-compacte/pagina1/";
            case "Aparate Foto Mirrorless":
                return "https://www.itgalaxy.ro/aparate-foto-mirrorless/pagina1/";
            case "Aparate Foto DSLR":
                return "https://www.itgalaxy.ro/aparate-foto-dslr/pagina1/";
            case "Obiective":
                return "https://www.itgalaxy.ro/obiective/pagina1/";
            case "Filtre Foto":
                return "https://www.itgalaxy.ro/filtre-foto/pagina1/";
            case "Blitzuri":
                return "https://www.itgalaxy.ro/blitzuri/pagina1/";
            case "Huse si Genti Foto":
                return "https://www.itgalaxy.ro/huse-si-genti-foto/pagina1/";
            case "Accesorii Foto Video":
                return "https://www.itgalaxy.ro/accesorii-foto-video/pagina1/";
            case "Acumulatori si Incarcatoare":
                return "https://www.itgalaxy.ro/acumulatori-si-incarcatoare/pagina1/";
            case "Camere Video":
                return "https://www.itgalaxy.ro/camere-video/pagina1/";
            case "Camere Video de Actiune":
                return "https://www.itgalaxy.ro/camere-video-de-actiune/pagina1/";
            case "Accesorii Camere Video de Actiune":
                return "https://www.itgalaxy.ro/accesorii-camere-video-de-actiune/pagina1/";
            case "Carduri de Memorie":
                return "https://www.itgalaxy.ro/carduri-de-memorie/pagina1/";
            case "Cititoare Carduri":
                return "https://www.itgalaxy.ro/cititoare-carduri/pagina1/";
            case "Rame Foto":
                return "https://www.itgalaxy.ro/rame-foto/pagina1/";
            case "Trepiede":
                return "https://www.itgalaxy.ro/trepiede/pagina1/";
            case "Binocluri si Lunete":
                return "https://www.itgalaxy.ro/binocluri-si-lunete/pagina1/";
            case "Televizoare":
                return "https://www.itgalaxy.ro/televizoare/pagina1/";
            case "Suport TV":
                return "https://www.itgalaxy.ro/suport-tv/pagina1/";
            case "Telecomenzi":
                return "https://www.itgalaxy.ro/telecomenzi/pagina1/";
            case "Videoproiectoare":
                return "https://www.itgalaxy.ro/videoproiectoare/pagina1/";
            case "Ecrane de Proiectie":
                return "https://www.itgalaxy.ro/ecrane-de-proiectie/pagina1/";
            case "Accesorii Videoproiectoare":
                return "https://www.itgalaxy.ro/accesorii-videoproiectoare/pagina1/";
            case "Media Playere":
                return "https://www.itgalaxy.ro/media-playere/pagina1/";
            case "Table Interactive":
                return "https://www.itgalaxy.ro/table-interactive/pagina1/";
            case "Sisteme Home Cinema Audio":
                return "https://www.itgalaxy.ro/sisteme-home-cinema-audio/pagina1/";
            case "DVD si Blu-ray Playere":
                return "https://www.itgalaxy.ro/dvd-si-blu-ray-playere/pagina1/";
            case "CD Player":
                return "https://www.itgalaxy.ro/cd-player/pagina1/";
            case "MP3 si MP4 Playere":
                return "https://www.itgalaxy.ro/mp3-si-mp4-playere/pagina1/";
            case "Reportofoane":
                return "https://www.itgalaxy.ro/reportofoane/pagina1/";
            case "Radiouri":
                return "https://www.itgalaxy.ro/radiouri/pagina1/";
            case "Statii Radio CB":
                return "https://www.itgalaxy.ro/statii-radio-cb/pagina1/";
            case "Accesorii Multimedia":
                return "https://www.itgalaxy.ro/accesorii-multimedia/pagina1/";
            case "Ochelari VR":
                return "https://www.itgalaxy.ro/ochelari-vr/pagina1/";
            case "Smartwatch":
                return "https://www.itgalaxy.ro/smartwatch/pagina1/";
            case "Accesorii Smartwatch":
                return "https://www.itgalaxy.ro/accesorii-smartwatch/pagina1/";
            case "Bratari Fitness":
                return "https://www.itgalaxy.ro/bratari-fitness/pagina1/";
            case "Accesorii Bratari Fitness":
                return "https://www.itgalaxy.ro/accesorii-bratari-fitness/pagina1/";
            case "Drone":
                return "https://www.itgalaxy.ro/drone/pagina1/";
            case "Accesorii Drone":
                return "https://www.itgalaxy.ro/accesorii-drone/pagina1/";
            case "Trotinete Electrice":
                return "https://www.itgalaxy.ro/trotinete-electrice/pagina1/";
            case "Alte Vehicule Electrice":
                return "https://www.itgalaxy.ro/alte-vehicule-electrice/pagina1/";
            case "Console Gaming":
                return "https://www.itgalaxy.ro/console-gaming/pagina1/";
            case "Scaune Gaming Birouri":
                return "https://www.itgalaxy.ro/scaune-gaming-birouri/pagina1/";
            case "Accesorii Console":
                return "https://www.itgalaxy.ro/accesorii-console/pagina1/";
            case "Jocuri Consola":
                return "https://www.itgalaxy.ro/jocuri-consola/pagina1/";
            case "Jocuri PC":
                return "https://www.itgalaxy.ro/jocuri-pc/pagina1/";
            case "Gamepad":
                return "https://www.itgalaxy.ro/gamepad/pagina1/";
            case "Joystick":
                return "https://www.itgalaxy.ro/joystick/pagina1/";
            case "Volane Gaming":
                return "https://www.itgalaxy.ro/volane-gaming/pagina1/";
            case "Accesorii Gaming":
                return "https://www.itgalaxy.ro/accesorii-gaming/pagina1/";
            case "Trolere Genti Voiaj":
                return "https://www.itgalaxy.ro/trolere-genti-voiaj/pagina1/";
            case "Rucsacuri Drumetie":
                return "https://www.itgalaxy.ro/rucsacuri-drumetie/pagina1/";
            case "Corturi Camping":
                return "https://www.itgalaxy.ro/corturi-camping/pagina1/";
            case "Saltele Paturi Camping":
                return "https://www.itgalaxy.ro/saltele-paturi-camping/pagina1/";
            case "Saci Dormit":
                return "https://www.itgalaxy.ro/saci-dormit/pagina1/";
            case "Vesela Camping":
                return "https://www.itgalaxy.ro/vesela-camping/pagina1/";
            case "Arzatoare Camping":
                return "https://www.itgalaxy.ro/arzatoare-camping/pagina1/";
            case "Bricege":
                return "https://www.itgalaxy.ro/bricege/pagina1/";
            case "Lanterne":
                return "https://www.itgalaxy.ro/lanterne/pagina1/";
            case "Accesorii Camping Drumetii":
                return "https://www.itgalaxy.ro/accesorii-camping-drumetii/pagina1/";
            case "Statii Meteo":
                return "https://www.itgalaxy.ro/statii-meteo/pagina1/";
            case "Lumini Biciclete":
                return "https://www.itgalaxy.ro/lumini-biciclete/pagina1/";
            case "Accesorii Biciclete":
                return "https://www.itgalaxy.ro/accesorii-biciclete/pagina1/";
            case "Masini de Spalat Rufe":
                return "https://www.itgalaxy.ro/masini-de-spalat-rufe/pagina1/";
            case "Uscatoare de Rufe":
                return "https://www.itgalaxy.ro/uscatoare-de-rufe/pagina1/";
            case "Combine Frigorifice":
                return "https://www.itgalaxy.ro/combine-frigorifice/pagina1/";
            case "Congelatoare":
                return "https://www.itgalaxy.ro/congelatoare/pagina1/";
            case "Frigidere":
                return "https://www.itgalaxy.ro/frigidere/pagina1/";
            case "Lazi Frigorifice":
                return "https://www.itgalaxy.ro/lazi-frigorifice/pagina1/";
            case "Side-by-Side":
                return "https://www.itgalaxy.ro/side-by-side/pagina1/";
            case "Racitoare Vinuri":
                return "https://www.itgalaxy.ro/racitoare-vinuri/pagina1/";
            case "Plite":
                return "https://www.itgalaxy.ro/plite/pagina1/";
            case "Cuptoare Incorporabile":
                return "https://www.itgalaxy.ro/cuptoare-incorporabile/pagina1/";
            case "Cuptoare Electrice":
                return "https://www.itgalaxy.ro/cuptoare-electrice/pagina1/";
            case "Cuptoare cu Microunde":
                return "https://www.itgalaxy.ro/cuptoare-cu-microunde/pagina1/";
            case "Aragazuri":
                return "https://www.itgalaxy.ro/aragazuri/pagina1/";
            case "Hote":
                return "https://www.itgalaxy.ro/hote/pagina1/";
            case "Masini de Spalat Vase":
                return "https://www.itgalaxy.ro/masini-de-spalat-vase/pagina1/";
            case "Espressoare Cafea":
                return "https://www.itgalaxy.ro/espressoare-cafea/pagina1/";
            case "Cafetiere":
                return "https://www.itgalaxy.ro/cafetiere/pagina1/";
            case "Rasnite Cafea":
                return "https://www.itgalaxy.ro/rasnite-cafea/pagina1/";
            case "Fierbatoare":
                return "https://www.itgalaxy.ro/fierbatoare/pagina1/";
            case "Roboti de Bucatarie":
                return "https://www.itgalaxy.ro/roboti-de-bucatarie/pagina1/";
            case "Multicooker":
                return "https://www.itgalaxy.ro/multicooker/pagina1/";
            case "Friteuze":
                return "https://www.itgalaxy.ro/friteuze/pagina1/";
            case "Mixere":
                return "https://www.itgalaxy.ro/mixere/pagina1/";
            case "Blendere":
                return "https://www.itgalaxy.ro/blendere/pagina1/";
            case "Storcatoare de Fructe si Legume":
                return "https://www.itgalaxy.ro/storcatoare-de-fructe-si-legume/pagina1/";
            case "Sandwich Maker":
                return "https://www.itgalaxy.ro/sandwich-maker/pagina1/";
            case "Gratare Electrice":
                return "https://www.itgalaxy.ro/gratare-electrice/pagina1/";
            case "Masini de Paine":
                return "https://www.itgalaxy.ro/masini-de-paine/pagina1/";
            case "Prajitoare de Paine":
                return "https://www.itgalaxy.ro/prajitoare-de-paine/pagina1/";
            case "Masini de Tocat":
                return "https://www.itgalaxy.ro/masini-de-tocat/pagina1/";
            case "Feliatoare":
                return "https://www.itgalaxy.ro/feliatoare/pagina1/";
            case "Tocatoare":
                return "https://www.itgalaxy.ro/tocatoare/pagina1/";
            case "Aparate de Preparat Desert":
                return "https://www.itgalaxy.ro/aparate-de-preparat-desert/pagina1/";
            case "Cantare de Bucatarie":
                return "https://www.itgalaxy.ro/cantare-de-bucatarie/pagina1/";
            case "Aspiratoare":
                return "https://www.itgalaxy.ro/aspiratoare/pagina1/";
            case "Fiere de Calcat":
                return "https://www.itgalaxy.ro/fiere-de-calcat/pagina1/";
            case "Diverse Electrocasnice Mici":
                return "https://www.itgalaxy.ro/diverse-electrocasnice-mici/pagina1/";
            case "Accesorii Electrocasnice":
                return "https://www.itgalaxy.ro/accesorii-electrocasnice/pagina1/";
            case "Vitrine Frigorifice":
                return "https://www.itgalaxy.ro/vitrine-frigorifice/pagina1/";


            case "Parfumuri":
                return "https://www.itgalaxy.ro/parfumuri/pagina1/";
            case "Pachete Cadouri":
                return "https://www.itgalaxy.ro/pachete-cadouri/pagina1/";
            case "Articole Ortopedice":
                return "https://www.itgalaxy.ro/articole-ortopedice/pagina1/";
            case "Epilatoare":
                return "https://www.itgalaxy.ro/epilatoare/pagina1/";
            case "Accesorii Epilatoare":
                return "https://www.itgalaxy.ro/accesorii-epilatoare/pagina1/";
            case "Aparate Masaj":
                return "https://www.itgalaxy.ro/aparate-masaj/pagina1/";
            case "Masini de Tuns":
                return "https://www.itgalaxy.ro/masini-de-tuns/pagina1/";
            case "Aparate de Ras":
                return "https://www.itgalaxy.ro/aparate-de-ras/pagina1/";
            case "Accesorii Aparate de Ras":
                return "https://www.itgalaxy.ro/accesorii-aparate-de-ras/pagina1/";
            case "Perii de Par":
                return "https://www.itgalaxy.ro/perii-de-par/pagina1/";
            case "Placi de Indreptat Parul":
                return "https://www.itgalaxy.ro/placi-de-indreptat-parul/pagina1/";
            case "Ondulatoare":
                return "https://www.itgalaxy.ro/ondulatoare/pagina1/";
            case "Uscatoare de Par":
                return "https://www.itgalaxy.ro/uscatoare-de-par/pagina1/";
            case "Ingrijire Orala":
                return "https://www.itgalaxy.ro/ingrijire-orala/pagina1/";
            case "Accesorii Ingrijire Orala":
                return "https://www.itgalaxy.ro/accesorii-ingrijire-orala/pagina1/";
            case "Articole Manichiura Pedichiura":
                return "https://www.itgalaxy.ro/articole-manichiura-pedichiura/pagina1/";
            case "Tensiometre":
                return "https://www.itgalaxy.ro/tensiometre/pagina1/";
            case "Glucometre":
                return "https://www.itgalaxy.ro/glucometre/pagina1/";
            case "Termometre":
                return "https://www.itgalaxy.ro/termometre/pagina1/";
            case "Cantare Corporale":
                return "https://www.itgalaxy.ro/cantare-corporale/pagina1/";
            case "Incalzitoare Corporale":
                return "https://www.itgalaxy.ro/incalzitoare-corporale/pagina1/";
            case "Articole Fitness":
                return "https://www.itgalaxy.ro/articole-fitness/pagina1/";
            case "Intretinere Ingrijire Corporala":
                return "https://www.itgalaxy.ro/intretinere-ingrijire-corporala/pagina1/";
            case "Sampon si Balsam":
                return "https://www.itgalaxy.ro/sampon-si-balsam/pagina1/";
            case "Vopsea de Par si Accesorii":
                return "https://www.itgalaxy.ro/vopsea-de-par-si-accesorii/pagina1/";
            case "Sapun si Gel de Dus":
                return "https://www.itgalaxy.ro/sapun-si-gel-de-dus/pagina1/";
            case "Diverse Cosmetice":
                return "https://www.itgalaxy.ro/diverse-cosmetice/pagina1/";
            case "Absorbante":
                return "https://www.itgalaxy.ro/absorbante/pagina1/";
            case "Produse de Prim Ajutor":
                return "https://www.itgalaxy.ro/produse-de-prim-ajutor/pagina1/";
            case "Masti Manusi Chirurgicale Dezinfectant":
                return "https://www.itgalaxy.ro/masti-manusi-chirurgicale-dezinfectant/pagina1/";
            case "Foarfeci":
                return "https://www.itgalaxy.ro/foarfeci/pagina1/";
            case "Oglinzi Cosmetice":
                return "https://www.itgalaxy.ro/oglinzi-cosmetice/pagina1/";
            case "Geluri Dus":
                return "https://www.itgalaxy.ro/geluri-dus/pagina1/";
            case "Palete Tenis Masa":
                return "https://www.itgalaxy.ro/palete-tenis-masa/pagina1/";
            case "Mingi":
                return "https://www.itgalaxy.ro/mingi/pagina1/";
            case "Biciclete":
                return "https://www.itgalaxy.ro/biciclete/pagina1/";
            case "Scaune Auto Copii":
                return "https://www.itgalaxy.ro/scaune-auto-copii/pagina1/";
            case "Carucioare Copii":
                return "https://www.itgalaxy.ro/carucioare-copii/pagina1/";
            case "Triciclete Copii":
                return "https://www.itgalaxy.ro/triciclete-copii/pagina1/";
            case "Biciclete Copii":
                return "https://www.itgalaxy.ro/biciclete-copii/pagina1/";
            case "Trotinete":
                return "https://www.itgalaxy.ro/trotinete/pagina1/";
            case "Paturi Copii":
                return "https://www.itgalaxy.ro/paturi-copii/pagina1/";
            case "Lenjerii si Huse Patut":
                return "https://www.itgalaxy.ro/lenjerii-si-huse-patut/pagina1/";
            case "Marsupii Bebelusi":
                return "https://www.itgalaxy.ro/marsupii-bebelusi/pagina1/";
            case "Balansoare Leagane Hamace Copii":
                return "https://www.itgalaxy.ro/balansoare-leagane-hamace-copii/pagina1/";
            case "Accesorii Baie Copii":
                return "https://www.itgalaxy.ro/accesorii-baie-copii/pagina1/";
            case "Saci de Dormit Bebe si Copii":
                return "https://www.itgalaxy.ro/saci-de-dormit-bebe-si-copii/pagina1/";
            case "Jucarii":
                return "https://www.itgalaxy.ro/jucarii/pagina1/";
            case "Cereale Copii":
                return "https://www.itgalaxy.ro/cereale-copii/pagina1/";
            case "Monitorizare Bebelusi":
                return "https://www.itgalaxy.ro/monitorizare-bebelusi/pagina1/";
            case "Scutece":
                return "https://www.itgalaxy.ro/scutece/pagina1/";
            case "Biberoane":
                return "https://www.itgalaxy.ro/biberoane/pagina1/";
            case "Alimentatie Bebe Accesorii":
                return "https://www.itgalaxy.ro/alimentatie-bebe-accesorii/pagina1/";
            case "Premergatoare":
                return "https://www.itgalaxy.ro/premergatoare/pagina1/";
            case "Suzete":
                return "https://www.itgalaxy.ro/suzete/pagina1/";
            case "Tetine":
                return "https://www.itgalaxy.ro/tetine/pagina1/";
            case "Pompe de San":
                return "https://www.itgalaxy.ro/pompe-de-san/pagina1/";
            case "Accesorii Alaptare":
                return "https://www.itgalaxy.ro/accesorii-alaptare/pagina1/";
            case "Tarc Copii":
                return "https://www.itgalaxy.ro/tarc-copii/pagina1/";
            case "Piscine Copii":
                return "https://www.itgalaxy.ro/piscine-copii/pagina1/";
            case "Scaune de Masa Bebelusi":
                return "https://www.itgalaxy.ro/scaune-de-masa-bebelusi/pagina1/";
            case "Accesorii Camera Copii":
                return "https://www.itgalaxy.ro/accesorii-camera-copii/pagina1/";
            case "Tampoane San":
                return "https://www.itgalaxy.ro/tampoane-san/pagina1/";
            case "Puzzle":
                return "https://www.itgalaxy.ro/puzzle/pagina1/";
            case "Tobogane":
                return "https://www.itgalaxy.ro/tobogane/pagina1/";
            case "Carusele Patut":
                return "https://www.itgalaxy.ro/carusele-patut/pagina1/";
            case "Figurine":
                return "https://www.itgalaxy.ro/figurine/pagina1/";
            case "Papusi":
                return "https://www.itgalaxy.ro/papusi/pagina1/";
            case "Masinute":
                return "https://www.itgalaxy.ro/masinute/pagina1/";
            case "Centre Activitati":
                return "https://www.itgalaxy.ro/centre-activitati/pagina1/";
            case "Jocuri Societate":
                return "https://www.itgalaxy.ro/jocuri-societate/pagina1/";
            case "Colaci Ochelari Accesorii Inot":
                return "https://www.itgalaxy.ro/colaci-ochelari-accesorii-inot/pagina1/";
            case "Trambuline":
                return "https://www.itgalaxy.ro/trambuline/pagina1/";
            case "Aparate Aer Conditionat":
                return "https://www.itgalaxy.ro/aparate-aer-conditionat/pagina1/";
            case "Boilere":
                return "https://www.itgalaxy.ro/boilere/pagina1/";
            case "Centrale Termice":
                return "https://www.itgalaxy.ro/centrale-termice/pagina1/";
            case "Pompe Caldura":
                return "https://www.itgalaxy.ro/pompe-caldura/pagina1/";
            case "Aeroterme":
                return "https://www.itgalaxy.ro/aeroterme/pagina1/";
            case "Radiatoare":
                return "https://www.itgalaxy.ro/radiatoare/pagina1/";
            case "Calorifere":
                return "https://www.itgalaxy.ro/calorifere/pagina1/";
            case "Ventilatoare de Camera":
                return "https://www.itgalaxy.ro/ventilatoare-de-camera/pagina1/";
            case "Umidificatoare":
                return "https://www.itgalaxy.ro/umidificatoare/pagina1/";
            case "Dezumidificatoare":
                return "https://www.itgalaxy.ro/dezumidificatoare/pagina1/";
            case "Purificatoare de Aer":
                return "https://www.itgalaxy.ro/purificatoare-de-aer/pagina1/";
            case "Accesorii Climatizare":
                return "https://www.itgalaxy.ro/accesorii-climatizare/pagina1/";
            case "Termostate":
                return "https://www.itgalaxy.ro/termostate/pagina1/";
            case "Compresoare":
                return "https://www.itgalaxy.ro/compresoare/pagina1/";
            case "Motocoase":
                return "https://www.itgalaxy.ro/motocoase/pagina1/";
            case "Masini de Tuns iarba":
                return "https://www.itgalaxy.ro/masini-de-tuns-iarba/pagina1/";
            case "Foarfece Gradinarit":
                return "https://www.itgalaxy.ro/foarfece-gradinarit/pagina1/";
            case "Motosape":
                return "https://www.itgalaxy.ro/motosape/pagina1/";
            case "Suflante Frunze":
                return "https://www.itgalaxy.ro/suflante-frunze/pagina1/";
            case "Aparate de Spalat cu Presiune":
                return "https://www.itgalaxy.ro/aparate-de-spalat-cu-presiune/pagina1/";
            case "Pompe Apa":
                return "https://www.itgalaxy.ro/pompe-apa/pagina1/";
            case "Hidrofoare":
                return "https://www.itgalaxy.ro/hidrofoare/pagina1/";
            case "Statii Dedurizare Tratare Apa":
                return "https://www.itgalaxy.ro/statii-dedurizare-tratare-apa/pagina1/";
            case "Filtre Apa si Accesorii":
                return "https://www.itgalaxy.ro/filtre-apa-si-accesorii/pagina1/";
            case "Generatoare Curent":
                return "https://www.itgalaxy.ro/generatoare-curent/pagina1/";
            case "Freze de Zapada":
                return "https://www.itgalaxy.ro/freze-de-zapada/pagina1/";
            case "Mori Electrice":
                return "https://www.itgalaxy.ro/mori-electrice/pagina1/";
            case "Betoniere":
                return "https://www.itgalaxy.ro/betoniere/pagina1/";
            case "Roabe":
                return "https://www.itgalaxy.ro/roabe/pagina1/";
            case "Lacate":
                return "https://www.itgalaxy.ro/lacate/pagina1/";
            case "Seifuri":
                return "https://www.itgalaxy.ro/seifuri/pagina1/";
            case "Reflectoare Panouri LED":
                return "https://www.itgalaxy.ro/reflectoare-panouri-led/pagina1/";
            case "Sisteme Panouri Solare":
                return "https://www.itgalaxy.ro/sisteme-panouri-solare/pagina1/";
            case "Accesorii Panouri Solare":
                return "https://www.itgalaxy.ro/accesorii-panouri-solare/pagina1/";
            case "Veioze Lampi":
                return "https://www.itgalaxy.ro/veioze-lampi/pagina1/";
            case "Lustre":
                return "https://www.itgalaxy.ro/lustre/pagina1/";
            case "Becuri":
                return "https://www.itgalaxy.ro/becuri/pagina1/";
            case "Prize si Prelungitoare":
                return "https://www.itgalaxy.ro/prize-si-prelungitoare/pagina1/";
            case "Intrerupatoare":
                return "https://www.itgalaxy.ro/intrerupatoare/pagina1/";
            case "Accesorii Prize Intrerupatoare":
                return "https://www.itgalaxy.ro/accesorii-prize-intrerupatoare/pagina1/";
            case "Chiuvete":
                return "https://www.itgalaxy.ro/chiuvete/pagina1/";
            case "Baterii Baie":
                return "https://www.itgalaxy.ro/baterii-baie/pagina1/";
            case "Baterii Bucatarie":
                return "https://www.itgalaxy.ro/baterii-bucatarie/pagina1/";
            case "Tacamuri si Ustensile Gatit":
                return "https://www.itgalaxy.ro/tacamuri-si-ustensile-gatit/pagina1/";
            case "Ibrice":
                return "https://www.itgalaxy.ro/ibrice/pagina1/";
            case "Tigai":
                return "https://www.itgalaxy.ro/tigai/pagina1/";
            case "Oale si Cratite":
                return "https://www.itgalaxy.ro/oale-si-cratite/pagina1/";
            case "Cutite":
                return "https://www.itgalaxy.ro/cutite/pagina1/";
            case "Tavi":
                return "https://www.itgalaxy.ro/tavi/pagina1/";
            case "Accesorii Bucatarie":
                return "https://www.itgalaxy.ro/accesorii-bucatarie/pagina1/";
            case "Saltele Pat":
                return "https://www.itgalaxy.ro/saltele-pat/pagina1/";
            case "Lenjerii Pat":
                return "https://www.itgalaxy.ro/lenjerii-pat/pagina1/";
            case "Perne":
                return "https://www.itgalaxy.ro/perne/pagina1/";
            case "Prosoape":
                return "https://www.itgalaxy.ro/prosoape/pagina1/";
            case "Curatenie si Intretinere":
                return "https://www.itgalaxy.ro/curatenie-si-intretinere/pagina1/";
            case "Detergenti si Balsam":
                return "https://www.itgalaxy.ro/detergenti-si-balsam/pagina1/";
            case "Oferta Diversa Casa Gradina":
                return "https://www.itgalaxy.ro/oferta-diversa-casa-gradina/pagina1/";
            case "Aparate Stropit Gradina":
                return "https://www.itgalaxy.ro/aparate-stropit-gradina/pagina1/";
            case "Canapele":
                return "https://www.itgalaxy.ro/canapele/pagina1/";
            case "Fotolii":
                return "https://www.itgalaxy.ro/fotolii/pagina1/";
            case "Aparate Curatat Abur":
                return "https://www.itgalaxy.ro/aparate-curatat-abur/pagina1/";
            case "Mopuri Maturi Galeti":
                return "https://www.itgalaxy.ro/mopuri-maturi-galeti/pagina1/";
            case "Gratare Gradina":
                return "https://www.itgalaxy.ro/gratare-gradina/pagina1/";
            case "Covoare":
                return "https://www.itgalaxy.ro/covoare/pagina1/";
            case "Scaune":
                return "https://www.itgalaxy.ro/scaune/pagina1/";
            case "Aparate de Sudura":
                return "https://www.itgalaxy.ro/aparate-de-sudura/pagina1/";
            case "Accesorii Sudura":
                return "https://www.itgalaxy.ro/accesorii-sudura/pagina1/";
            case "Aparate Taiere cu Plasma":
                return "https://www.itgalaxy.ro/aparate-taiere-cu-plasma/pagina1/";
            case "Rotopercutoare":
                return "https://www.itgalaxy.ro/rotopercutoare/pagina1/";
            case "Masini de Gaurit":
                return "https://www.itgalaxy.ro/masini-de-gaurit/pagina1/";
            case "Polizoare":
                return "https://www.itgalaxy.ro/polizoare/pagina1/";
            case "Fierastraie Electrice":
                return "https://www.itgalaxy.ro/fierastraie-electrice/pagina1/";
            case "Surubelnite":
                return "https://www.itgalaxy.ro/surubelnite/pagina1/";
            case "Masini de Cusut":
                return "https://www.itgalaxy.ro/masini-de-cusut/pagina1/";
            case "Accesorii Masini de Cusut":
                return "https://www.itgalaxy.ro/accesorii-masini-de-cusut/pagina1/";
            case "Tevi Accesorii":
                return "https://www.itgalaxy.ro/tevi-accesorii/pagina1/";
            case "Robinete Instalatii":
                return "https://www.itgalaxy.ro/robinete-instalatii/pagina1/";
            case "Accesorii Scule si Unelte":
                return "https://www.itgalaxy.ro/accesorii-scule-si-unelte/pagina1/";
            case "Accesorii Fierastraie":
                return "https://www.itgalaxy.ro/accesorii-fierastraie/pagina1/";
            case "Ciocane":
                return "https://www.itgalaxy.ro/ciocane/pagina1/";
            case "Seturi Accesorii Gaurit Insurubat":
                return "https://www.itgalaxy.ro/seturi-accesorii-gaurit-insurubat/pagina1/";
            case "Aparate Masura Control":
                return "https://www.itgalaxy.ro/aparate-masura-control/pagina1/";
            case "Routere Wireless":
                return "https://www.itgalaxy.ro/routere-wireless/pagina1/";
            case "Routere":
                return "https://www.itgalaxy.ro/routere/pagina1/";
            case "Switch-uri":
                return "https://www.itgalaxy.ro/switch-uri/pagina1/";
            case "Bridge Range Extender":
                return "https://www.itgalaxy.ro/bridge-range-extender/pagina1/";
            case "Puncte de Acces":
                return "https://www.itgalaxy.ro/puncte-de-acces/pagina1/";
            case "Placi de Retea":
                return "https://www.itgalaxy.ro/placi-de-retea/pagina1/";
            case "Placi de Retea Wireless":
                return "https://www.itgalaxy.ro/placi-de-retea-wireless/pagina1/";
            case "Adaptoare Wireless":
                return "https://www.itgalaxy.ro/adaptoare-wireless/pagina1/";
            case "Network Attached Storage":
                return "https://www.itgalaxy.ro/network-attached-storage/pagina1/";
            case "Powerline":
                return "https://www.itgalaxy.ro/powerline/pagina1/";
            case "PDU":
                return "https://www.itgalaxy.ro/pdu/pagina1/";
            case "KVM":
                return "https://www.itgalaxy.ro/kvm/pagina1/";
            case "Media Convertoare":
                return "https://www.itgalaxy.ro/media-convertoare/pagina1/";
            case "Sisteme de Alarma":
                return "https://www.itgalaxy.ro/sisteme-de-alarma/pagina1/";
            case "Senzori":
                return "https://www.itgalaxy.ro/senzori/pagina1/";
            case "Camere Supraveghere":
                return "https://www.itgalaxy.ro/camere-supraveghere/pagina1/";
            case "DVR":
                return "https://www.itgalaxy.ro/dvr/pagina1/";
            case "Antene":
                return "https://www.itgalaxy.ro/antene/pagina1/";
            case "Accesorii Supraveghere":
                return "https://www.itgalaxy.ro/accesorii-supraveghere/pagina1/";
            case "Servere":
                return "https://www.itgalaxy.ro/servere/pagina1/";
            case "Placi de Baza Server":
                return "https://www.itgalaxy.ro/placi-de-baza-server/pagina1/";
            case "Procesoare Server":
                return "https://www.itgalaxy.ro/procesoare-server/pagina1/";
            case "Memorii Server":
                return "https://www.itgalaxy.ro/memorii-server/pagina1/";
            case "HDD Server":
                return "https://www.itgalaxy.ro/hdd-server/pagina1/";
            case "SSD Server":
                return "https://www.itgalaxy.ro/ssd-server/pagina1/";
            case "Carcase Server":
                return "https://www.itgalaxy.ro/carcase-server/pagina1/";
            case "Surse Server":
                return "https://www.itgalaxy.ro/surse-server/pagina1/";
            case "Sisteme de Operare Server":
                return "https://www.itgalaxy.ro/sisteme-de-operare-server/pagina1/";
            case "Accesorii Servere":
                return "https://www.itgalaxy.ro/accesorii-servere/pagina1/";
            case "Accesorii Retelistica":
                return "https://www.itgalaxy.ro/accesorii-retelistica/pagina1/";
            case "Cabinete Metalice":
                return "https://www.itgalaxy.ro/cabinete-metalice/pagina1/";
            case "Accesorii Cabinete Metalice":
                return "https://www.itgalaxy.ro/accesorii-cabinete-metalice/pagina1/";
            case "Boxe Auto":
                return "https://www.itgalaxy.ro/boxe-auto/pagina1/";
            case "Subwoofere Auto":
                return "https://www.itgalaxy.ro/subwoofer-auto/pagina1/";
            case "Amplificatoare Auto":
                return "https://www.itgalaxy.ro/amplificatoare-auto/pagina1/";
            case "Playere Auto":
                return "https://www.itgalaxy.ro/player-auto/pagina1/";
            case "Frigidere Auto":
                return "https://www.itgalaxy.ro/frigidere-auto/pagina1/";
            case "Camere Auto DVR":
                return "https://www.itgalaxy.ro/camere-auto-dvr/pagina1/";
            case "Anvelope":
                return "https://www.itgalaxy.ro/anvelope/pagina1/";
            case "Jante":
                return "https://www.itgalaxy.ro/jante/pagina1/";
            case "Redresoare Auto":
                return "https://www.itgalaxy.ro/redresoare-auto/pagina1/";
            case "Invertoare Auto":
                return "https://www.itgalaxy.ro/invertoare-auto/pagina1/";
            case "Roboti Pornire":
                return "https://www.itgalaxy.ro/roboti-pornire/pagina1/";
            case "Monitoare Auto":
                return "https://www.itgalaxy.ro/monitoare-auto/pagina1/";
            case "GPS":
                return "https://www.itgalaxy.ro/gps/pagina1/";
            case "Suporturi Auto Biciclete Ski Snowboard":
                return "https://www.itgalaxy.ro/suporturi-auto-biciclete-ski-snowboard/pagina1/";
            case "Aspiratoare Auto":
                return "https://www.itgalaxy.ro/aspiratoare-auto/pagina1/";
            case "Cutii Portbagaj Auto":
                return "https://www.itgalaxy.ro/cutii-portbagaj-auto/pagina1/";
            case "Becuri Auto":
                return "https://www.itgalaxy.ro/becuri-auto/pagina1/";
            case "Odorizante Auto":
                return "https://www.itgalaxy.ro/odorizante-auto/pagina1/";
            case "Accesorii Auto":
                return "https://www.itgalaxy.ro/accesorii-auto/pagina1/";
            case "Modulatoare FM":
                return "https://www.itgalaxy.ro/modulatoare-fm/pagina1/";
            case "Compresoare Auto":
                return "https://www.itgalaxy.ro/compresoare-auto/pagina1/";
            default:
                return null;
        }
    }*/
}

