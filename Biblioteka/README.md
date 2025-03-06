# Biblioteka
Potrebno je kreirati aplikaciju za upravljanje bibliotekom. Aplikacija ima tri taba u vrhu glavnog prozora.

Prvi tab je namenjen za pregled svih knjiga u biblioteci. Na ovom tabu se prikazuje lista knjiga u obliku 
tabele sa informacijama kao što su šifra, naslov knjige, autor, žanr i dostupnost. Svaka knjiga treba imati 
ikonicu prikazanu u tabeli. Korisnik može pretraživati knjige po naslovu i/ili autoru i/ili dostupnosti i
tom prilikom u tabeli prikazati samo one knjige koje odgovaraju pretrazi. Na ovom tabu treba da postoji 
i mogućnost dodavanja, uklanjanja i izmenu knjige (uključujući i promenu ikonice). Korisnik može uneti 
podatke o novoj knjizi, uključujući naslov, autora, žanr i ikonicu (svaka nova knjiga mora biti inicijalno 
dostupna). Nakon unosa, nova knjiga se dodaje u biblioteku i odmah je vidljiva.

Drugi tab je namenjen za iznajmljivanje knjiga. Sa leve strane se treba nalaziti TreeView sa knjigama
grupisanih po žanru. Knjige treba da budu prikazane sa ikonicom u TreeView-u. Knjige koje nisu
dostupne (a dostupne su one knjige koje nisu izajmljene) treba da su disable-ovane. Sa desne strane 
se nalazi TreeView sa korisnicima gde za svakog korisnika treba prikazati trenutno iznajmljene knjige. 
Iznajmljivanje knjiga se vrši tako što knjigu iz levog TreeView-a prevučemo u desni TreeView sa 
korisnicima, tako da prilikom otpuštanja klika miš bude pozicioniran na konkretnog korisnika. Ovo znači 
da je korisnik iznajmio navedenu knjigu i odmah istu prikazujemo ispod korisnika. Ovaj tab treba da 
sadrži i dugme za dodavanje novog korisnika u biblioteku (svaki korisnik ima id, ime, prezime i listu 
knjiga koje iznajmljuje). 

Treći tab je namenjen za istoriju iznajmljivanja. Neophodno je napraviti napraviti dve tabele sa 
statistikama. U prvoj se nalaze knjige iz biblioteke sa informacijama – naslov knjige, žanr, broj 
iznajmljivanja, trenutna dostupnost. U drugoj se nalaze korisnici sa informacijama – ime, prezime, 
ukupan broj iznajmljivanja knjiga, omiljena knjiga (knjiga koju je najveći broj puta iznajmio). Pored toga, 
treba da postoji i dugme Export koje čuva trenutno stanje i korisnika i biblioteke u fajl (uključujući 
ikonice i sve ostale informacije). 
Svi podaci o knjigama, korisnicima i pozajmicama se čuvaju u fajlu ili bazi podataka. Možete koristiti 
tekstualne datoteke, binarne datoteke, bazu podataka ili neku drugu formu za čuvanje podataka.

DIZAJN APLIKACIJE
1. Dizajn je ostavljen studentu na izbor. Voditi računa da sam izgled ima smisla, da forma za
unos i izmenu ima izgled standardne forme tj. da ne budu sva polja u jednom redu i/ili da
dugmad ne budu razmaknuta itd.
2. Ikonica je ostavljena na izboru studenta (bitno je samo da je to ikonica neke knjige).

FUNKCIONALNOSTI

Napomene:
- za čuvanja podataka se može koristiti binarna i/ili tekstualna datoteka i/ili baza podataka
- ikonica - nije bitna dimenzija ikonice, bitno je samo da slika bude mala kada se prikaže u tabeli ili
TreeView-u
- VALIDACIJA – za sve forme u zadatku (unos i izmena) neophodna je validacija tako da ne
možemo imati dve knjige sa istim ID-jem, kao ni dva korisnika sa istim ID-om
PODELA POSLA U TIMU
Podelu predmetnog projekta izvršiti tako da svako od članova tima radi po 1 tab (unos,
izmenu, brisanje, drag&drop, validacija itd.). Samo treći tab (tabelarni prikaz) odraditi
zajedno sa kolegom/koleginicom
