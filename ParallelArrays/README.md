# Parallel Arrays

Jantje is bezig met een C# project voor school waar hij redelijk wat bewerkingen moet doen met arrays. Hij beslist dan ook al snel om een nieuwe class te maken met een aantal methodes die hem helpen bij deze taken.

Hij voorziet hierbij de class `ArrayHelper` met volgende methodes:

* `CountDifferentFrom(elements, value): int`: deze methode telt het aantal elementen in de array die verschillend zijn van `value`.
* `SumByElements(int[] first, int[] second): int[]`: deze methode laat toe om de som van de elementen te maken van twee arrays en deze telkens per paar op te tellen en in een nieuwe array te stoppen. De resulterende array bevat dus telkens de som van de elementen uit `first` en `second` op dezelfde index. Je mag er van uit gaan dat de grootte van beide arrays hetzelfde is.
* `DoubleInSize(numbers): int[]`: deze methode maakt een nieuwe array aan die dubbel zo groot is als `numbers`. Het kopieert dan de elementen uit `numbers` in de nieuwe array (startend vanaf het begin) en return deze nieuwe array als resultaat. De overige elementen zouden allemaal de waarde `0` moeten hebben.

De `Main()` methode voorziet reeds een demo applicatie. In principe hoef je hier niets meer aan te passen.

**Probeer er voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.**

Je vindt alle stappen als TODO's terug in Visual Studio onder `View => Task List`.

## Verwachte output

```text
Welcome to Parallel Arrays - A simple array helper ...

Let's make the sum of following arrays:
> 123,34,54,34
> 12,756,43,56

Sum:
> 135,790,97,90

The first array contains 2 numbers different from 34

Let's double the second array in size:
> 12,756,43,56,0,0,0,0
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
