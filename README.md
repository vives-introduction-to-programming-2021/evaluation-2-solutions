# Introduction to Programming - Evaluatie December 2021

Naam: NAME_GOES_HERE

## Clone maken van repo

Om te starten dien je eerst een eigen kopie te creëren van deze repository. Volg de stappen hieronder.

1. Ga naar Toledo en klik op de GitHub classroom invitation link
2. Accepteer de assignment
3. Wacht tot je persoonlijke kopie is gemaakt (dit kan een paar minuten duren)
4. Open de GitHub pagina van je repository
5. Kopieer de ssh clone-url (groene knop) die eruit zoiets als `git@github.com:vives-introduction-to-programming-2021/csharp-evaluation-2-2021-<username>.git`
6. Ga naar een lokale directory op je systeem waar je de repository wenst te maken. Neem geen directory heel diep genest. Open PowerShell op deze locatie.
7. Voer het commando `git clone` uit gevolgd door de ssh-url die je net kopieerde zoals hieronder aangegeven

```shell
git clone <place-ssh-url-here>
```

Je zou een gelijkaardige output als deze moeten krijgen:

```text
Cloning into 'csharp-evaluation-2-2021-BioBoost'...
Warning: Permanently added the RSA host key for IP address '192.30.253.113' to the list of known hosts.
remote: Enumerating objects: 185, done.
remote: Compressing objects: 100% (109/109), done.
Receiving objects: 100% (185/185), 128.22 KiB | 625.00 KiB/s, done.
Resolving deltas: 100% (57/57), done.
```

## Aanpassingen committen en pushen

Aanpassingen dienen te worden gecommit en gepushed via de terminal (PowerShell).

Ga naar je lokale kopie van de repository en start PowerShell hier op. Zorg dat je in de directory `csharp-evaluation-2-2021-<username>` zit.

1. Toevoegen van alle aangepaste files: `git add .`
2. Committen van de aanpassingen en meegeven van een bericht: `git commit -m "My message goes here"`
3. Pushen van aanpassingen naar GitHub: `git push origin master`
4. Om te controleren of alles goed verloopt kan je steeds het commando `git status` uitvoeren.

Vervolgens dien je ook naar de GitHub pagina te surfen en te zorgen dat alles online terug te vinden is.

**Opgelet!** Probeer enkel code te committen die compileert. Indien je er niet geraakt plaats dan niet-werkende code in commentaar vooraleer te committen.

## Overzicht

| Challenge | Description | Percentage |
| --- | --- | :---: |
| [Super String Theory](./SuperStringTheory/README.md) | Breidt de SuperString class verder uit | `34%` |
| [Parallel Arrays](./ParallelArrays/README.md) | Een aantal handige array methodes | `33%` |
| [Kings of Nothing](./KingsOfNothing/README.md) | Bouw een player class voor een spel | `33%` |
