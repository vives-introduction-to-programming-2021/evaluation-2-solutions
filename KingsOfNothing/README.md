# Kings of Nothing

Kings of Nothing is de start van een browser based platform game.

Om een speler voor te stellen werd er reeds een `Player` class voorzien maar er ontbreekt nog redelijk wat implementatie. Om deftig van start te kunnen gaan zouden een `Player` moeten kunnen verplaatsen en ook schade (damage) laten incasseren. Een `Player` zou tevens moeten kunnen herstellen van schade (healen).

Om dit te realiseren heeft de `Player` class volgende functionaliteit nodig:

* `Move(int deltaX, int deltaY)`: verplaatst de huidige locatie van de speler met de opgegeven delta-waarden. `deltaX` en `deltaY` kunnen negatief zijn, maar hier hoef je geen speciale rekening mee te houden.
* `Damage(int damage)`: richt schade toe aan de speler en verlaagt zijn leven (`health`) met de opgegeven `damage`. Let op dat het leven van de speler niet lager mag gaan dan `0`.
* `IsAlive(): bool`: geeft aan of de speler nog in leven is of niet. Een speler wordt aanzien als *in leven* wanneer zijn `health` groter is dan `0`.
* `Heal(int amount)`: verhoogt de speler zijn leven indien deze niet dood is. Dus een dode speler kan niet worden gehealed. Daarnaast dien je ook te bewaken dat de health van de speler niet boven de `100` gaat.

De `Main()` methode voorziet reeds een demo applicatie. In principe hoef je hier niets meer aan te passen.

**Probeer er voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.**

Je vindt alle stappen als TODO's terug in Visual Studio onder `View => Task List`.

## Verwachte output

```text
Kings of Noodles - Player bashing 101

Current player health: 100

Beating the player with 24 damage.
Current player health: 76

Healing the player with 20 health.
Current player health: 96

Healing the player again with 20 health.
Current player health: 100

Beating the player to death.
Current player health: 0
Is player alive? False

Moving the player with (12, 10).
 > Player x-coordinate: 12
 > Player y-coordinate: 10

Moving the player with (5, 8).
 > Player x-coordinate: 17
 > Player y-coordinate: 18
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
