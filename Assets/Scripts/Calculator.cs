using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator<T, U>
{
    T leftValue;
    U rightValue;

    public void Plus(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }

    public void Subtract(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }

    public void Multiply(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }

    public void Division(Action<T, U> calc)
    {
        calc(leftValue, rightValue);
    }
}
