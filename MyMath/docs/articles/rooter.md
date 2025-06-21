# Rooter

`Math.Lib.Rooter` es la clase que implementa el cálculo de la raíz cuadrada con el método de Newton.

## Métodos

### `SquareRoot(double input)`

- **Descripción:** Calcula la raíz cuadrada de `input` validando que sea positivo.  
- **Excepciones:**
  - `ArgumentOutOfRangeException` si `input <= 0` con mensaje `"El valor ingresado es invalido, solo se puede ingresar números positivos"`.

## Ejemplo de uso

```csharp
var rooter = new Rooter();
double result = rooter.SquareRoot(25); // 5.0
