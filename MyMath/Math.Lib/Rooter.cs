using System;

namespace Math.Lib
{
    public class Rooter
    {
        public double SquareRoot(double input)
        {
            // Si el valor es ≤ 0, lanzamos nuestra excepción personalizada
            if (input <= 0.0)
                throw new InvalidInputException(
                    "El valor ingresado es invalido, solo se puede ingresar números positivos");

            // Algoritmo de Newton para la raíz cuadrada
            double result = input;
            double previousResult = -input;
            while (System.Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
    }
}
