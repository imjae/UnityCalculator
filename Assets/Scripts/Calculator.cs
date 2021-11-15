using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OPERATOR
{
    NONE,
    LONGLONG,
    LONGDOUBLE,
    DOUBLELONG,
    DOUBLEDOUBLE
}

public class Calculator
{
    public string leftValue, rightValue;

    long longLeftValue, longRightValue;
    double doubleLeftValue, doubleRightValue;

    public OPERATOR CheckOperator(string leftValue, string rightValue)
    {
        if (long.TryParse(leftValue, out longLeftValue) && long.TryParse(rightValue, out longRightValue))
            return OPERATOR.LONGLONG;
        else if (long.TryParse(leftValue, out longLeftValue) && double.TryParse(rightValue, out doubleRightValue))
            return OPERATOR.LONGDOUBLE;
        else if (double.TryParse(leftValue, out doubleLeftValue) && long.TryParse(rightValue, out longRightValue))
            return OPERATOR.DOUBLELONG;
        else if (double.TryParse(leftValue, out doubleLeftValue) && double.TryParse(rightValue, out doubleRightValue))
            return OPERATOR.DOUBLEDOUBLE;
        else
            return OPERATOR.NONE;
    }

    public object Plus()
    {
        if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
        {
            LongLongCalculator<long, long> tempCalc = new LongLongCalculator<long, long>() { leftValue = longLeftValue, rightValue = longRightValue };
            tempCalc.Plus();
            
            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
        {
            
            LongDoubleCalculator tempCalc = new LongDoubleCalculator() { leftValue = longLeftValue, rightValue = doubleRightValue };
            tempCalc.Plus();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
        {
            
            DoubleLongCalculator tempCalc = new DoubleLongCalculator() { leftValue = doubleLeftValue, rightValue = longRightValue };
            tempCalc.Plus();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
        {
            
            DoubleDoubleCalculator tempCalc = new DoubleDoubleCalculator() { leftValue = doubleLeftValue, rightValue = doubleRightValue };
            tempCalc.Plus();

            return tempCalc.result;
        }
        else
            return (object)0;
    }

    public object Subtract()
    {
        if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
        {
            LongLongCalculator<long, long> tempCalc = new LongLongCalculator<long, long>() { leftValue = longLeftValue, rightValue = longRightValue };
            tempCalc.Subtract();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
        {
            LongDoubleCalculator tempCalc = new LongDoubleCalculator() { leftValue = longLeftValue, rightValue = doubleRightValue };
            tempCalc.Subtract();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
        {
            DoubleLongCalculator tempCalc = new DoubleLongCalculator() { leftValue = doubleLeftValue, rightValue = longRightValue };
            tempCalc.Subtract();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
        {
            DoubleDoubleCalculator tempCalc = new DoubleDoubleCalculator() { leftValue = doubleLeftValue, rightValue = doubleRightValue };
            tempCalc.Subtract();

            return tempCalc.result;
        }
        else
            return (object)0;
    }

    public object Multiply()
    {
        if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
        {
            LongLongCalculator<long, long> tempCalc = new LongLongCalculator<long, long>() { leftValue = longLeftValue, rightValue = longRightValue };
            tempCalc.Multiply();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
        {
            LongDoubleCalculator tempCalc = new LongDoubleCalculator() { leftValue = longLeftValue, rightValue = doubleRightValue };
            tempCalc.Multiply();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
        {
            DoubleLongCalculator tempCalc = new DoubleLongCalculator() { leftValue = doubleLeftValue, rightValue = longRightValue };
            tempCalc.Multiply();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
        {
            DoubleDoubleCalculator tempCalc = new DoubleDoubleCalculator() { leftValue = doubleLeftValue, rightValue = doubleRightValue };
            tempCalc.Multiply();

            return tempCalc.result;
        }
        else
            return (object)0;
    }

    public object Division()
    {
        if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
        {
            LongLongCalculator<long, long> tempCalc = new LongLongCalculator<long, long>() { leftValue = longLeftValue, rightValue = longRightValue };
            tempCalc.Division();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
        {
            LongDoubleCalculator tempCalc = new LongDoubleCalculator() { leftValue = longLeftValue, rightValue = doubleRightValue };
            tempCalc.Division();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
        {
            DoubleLongCalculator tempCalc = new DoubleLongCalculator() { leftValue = doubleLeftValue, rightValue = longRightValue };
            tempCalc.Division();

            return tempCalc.result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
        {
            DoubleDoubleCalculator tempCalc = new DoubleDoubleCalculator() { leftValue = doubleLeftValue, rightValue = doubleRightValue };
            tempCalc.Division();

            return tempCalc.result;
        }
        else
            return (object)0;
    }
}
