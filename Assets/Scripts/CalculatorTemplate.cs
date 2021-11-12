using System;
using System.Collections;
using System.Collections.Generic;

public class CalculatorTemplate<T, U>
{
    T leftValue;
    U rightValue;

    public void PlusTemplate(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }

    public void SubtractTemplate(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }

    public void MultiplyTemplate(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }

    public void DivisionTemplate(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }
}
