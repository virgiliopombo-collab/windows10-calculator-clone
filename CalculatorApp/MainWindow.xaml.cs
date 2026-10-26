using System;

namespace CalculatorApp;

public static class CalculatorEngine
{
    public static double Calculate(double left, double right, string operation)
    {
        return operation switch
        {
            "+" => left + right,
            "-" => left - right,
            "*" => left * right,
            "/" => right == 0 ? double.NaN : left / right,
            _ => left
        };
    }
}
