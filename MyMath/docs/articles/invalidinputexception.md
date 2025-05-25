# InvalidInputException

`Math.Lib.InvalidInputException` extiende de `Exception` y se usa cuando el valor de entrada no es válido.

## Constructores

### `InvalidInputException(string message)`

- **Parámetro:**  
  - `message`: Texto descriptivo del error.

## Ejemplo

```csharp
try
{
    var rooter = new Rooter();
    rooter.SquareRoot(-1);
}
catch (InvalidInputException ex)
{
    Console.WriteLine(ex.Message);
}
