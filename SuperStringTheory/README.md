# Super String Theory

`SuperString` class is een class die extra functionaliteit voorziet voor de `String` class.

Intern maakt deze gebruik van een gewoon `String` object, welk beschikbaar wordt gesteld naar buiten toe aan de hand van de methodes `GetText()` en `SetText()`.

De echte functionaliteit ontbreekt echter nog. Voorzie volgende methodes voor de class:

* `AppendText(string text)`: voegt achteraan de bestaande interne tekst een nieuw stuk tekst toe.
* `IsValidNumber(): bool`: geeft `true` terug indien de interne tekst enkel bestaat uit cijfers, met andere woorden enkel karakters tussen `0` en `9`.
* `TrimStart()`: verwijdert de spaties aan het begin van de text. Dus `  Hello World` wordt `Hello World`

Je dient bovenstaande functionaliteit te implementeren zonder gebruik te maken van methodes van de class `string`.

Zorg er ook voor dat al deze methodes tevens werken voor lege strings, met andere woorden `""`.

De `Main()` methode voorziet reeds een demo applicatie. In principe hoef je hier niets meer aan te passen.

**Probeer er voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.**

Je vindt alle stappen als TODO's terug in Visual Studio onder `View => Task List`.

## Verwachte output

```text
Welcome to Super String Theory

Lets append the word " World" to "Hello"
 > Before: Hello
 > After: Hello World

Let's check some numbers ...
Is 1234 a valid number? True
Is SDFNBDSF a valid number? False
Is #88 a valid number? False

OK, now for some trimming ...
If we trim at the beginning "  Hello There!", then we get "Hello There!"
If we trim at the beginning "There is no place like home!    ", then we get "There is no place like home!    "
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
