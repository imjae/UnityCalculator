using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorTemplate<T, U>
                where T : TypeNumber<long>
                where U : TypeNumber<long>
{

    public Func<T, U, object> PlusTemplate =
        (lValue, rValue) => lValue.value + rValue.value;

    public Func<T, U, object> SubtractTemplate =
        (lValue, rValue) => lValue.value - rValue.value;

    public Func<T, U, object> MultiplyTemplate =
        (lValue, rValue) => lValue.value * rValue.value;

    public Func<T, U, object> DivisionTemplate = 
    (lValue, rValue) => {
        object result = null;

        double tmpLeftValue = 0.0;
        if (rValue.value == 0)
        {
            result = "Cannot be divided by 0";
        }
        else
        {
            if (lValue.value % rValue.value != 0)
            {
                tmpLeftValue = lValue.value;
                result = tmpLeftValue / rValue.value;
            }
            else
            {
                result = lValue.value / rValue.value;
            }
        }

        return result;
    };// lValue.value / rValue.value;
}
