# Aufgabe 08 UML

Link zu HF-Sphinx-Dokumentation: 

## Eigenes Fallbeispiel (Online-Essen)

Dieses Modul behandelt ein eigenes Fallbeispiel: Ein **Online-Essen-Bestellsystem**, welches Kunden, Warenkörbe, Produkte und Lieferungen verwaltet.

## Klassendiagramm

Hier ist die visuelle Darstellung der Klassenstruktur für das Bestellsystem:

```plantuml
@startuml
skinparam classAttributeIconSize 0

package OnlineEssenSystem {

    class Produkt {
        + Name : string
        + Preis : double
        + Produkt(name : string, preis : double)
    }

    class Warenkorb {
        + Artikel : List<Produkt>
        + Gesamtpreis : double
        + ArtikelHinzufuegen(p : Produkt) : void
    }

    class Kunde {
        + Name : string
        + Adresse : string
        + AktuellerWarenkorb : Warenkorb
        + Kunde(name : string, adresse : string)
    }

    class Lieferung {
        + LieferID : int
        + Status : string
        + ZielKunde : Kunde
        + Lieferung(id : int, kunde : Kunde)
    }

    Kunde "1" *-- "1" Warenkorb : besitzt
    Warenkorb "1" o-- "*" Produkt : enthält
    Lieferung "1" --> "1" Kunde : wird geliefert an
}
@enduml