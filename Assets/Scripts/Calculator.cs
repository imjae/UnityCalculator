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
        object result = null;
        if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
        {
            PairType<long, long> tempCalc = new PairType<long, long>() { lValue = longLeftValue, rValue = longRightValue };
            result = tempCalc.lValue + tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
        {
            PairType<long, double> tempCalc = new PairType<long, double>() { lValue = longLeftValue, rValue = doubleRightValue };
            result = tempCalc.lValue + tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
        {
            PairType<double, long> tempCalc = new PairType<double, long>() { lValue = doubleLeftValue, rValue = longRightValue };
            result = tempCalc.lValue + tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
        {
            PairType<double, double> tempCalc = new PairType<double, double>() { lValue = doubleLeftValue, rValue = doubleRightValue };
            result = tempCalc.lValue + tempCalc.rValue;

            return result;
        }
        else
            return (object)0;
    }

    public object Subtract()
    {
        object result = null;
        if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
        {
            PairType<long, long> tempCalc = new PairType<long, long>() { lValue = longLeftValue, rValue = longRightValue };
            result = tempCalc.lValue - tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
        {
            PairType<long, double> tempCalc = new PairType<long, double>() { lValue = longLeftValue, rValue = doubleRightValue };
            result = tempCalc.lValue - tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
        {
            PairType<double, long> tempCalc = new PairType<double, long>() { lValue = doubleLeftValue, rValue = longRightValue };
            result = tempCalc.lValue - tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
        {
            PairType<double, double> tempCalc = new PairType<double, double>() { lValue = doubleLeftValue, rValue = doubleRightValue };
            result = tempCalc.lValue - tempCalc.rValue;

            return result;
        }
        else
            return (object)0;
    }

    public object Multiply()
    {
        object result = null;
        if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
        {
            PairType<long, long> tempCalc = new PairType<long, long>() { lValue = longLeftValue, rValue = longRightValue };
            result = tempCalc.lValue * tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
        {
            PairType<long, double> tempCalc = new PairType<long, double>() { lValue = longLeftValue, rValue = doubleRightValue };
            result = tempCalc.lValue * tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
        {
            PairType<double, long> tempCalc = new PairType<double, long>() { lValue = doubleLeftValue, rValue = longRightValue };
            result = tempCalc.lValue * tempCalc.rValue;

            return result;
        }
        else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
        {
            PairType<double, double> tempCalc = new PairType<double, double>() { lValue = doubleLeftValue, rValue = doubleRightValue };
            result = tempCalc.lValue * tempCalc.rValue;

            return result;
        }
        else
            return (object)0;
    }

    public object Division()
    {
        object result = null;

        if (rightValue == "0")
        {
            result = "Cannot devied by 0";
            return result;
        }
        else
        {
            if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGLONG)
            {
                PairType<long, long> tempCalc = new PairType<long, long>() { lValue = longLeftValue, rValue = longRightValue };
                if(tempCalc.lValue % tempCalc.rValue != 0)
                    result = tempCalc.lValue / (double)tempCalc.rValue;
                else
                    result = tempCalc.lValue / tempCalc.rValue;
            }
            else if (CheckOperator(leftValue, rightValue) == OPERATOR.LONGDOUBLE)
            {
                PairType<long, double> tempCalc = new PairType<long, double>() { lValue = longLeftValue, rValue = doubleRightValue };
                result = tempCalc.lValue / tempCalc.rValue;
            }
            else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLELONG)
            {
                PairType<double, long> tempCalc = new PairType<double, long>() { lValue = doubleLeftValue, rValue = longRightValue };
                result = tempCalc.lValue / tempCalc.rValue;
            }
            else if (CheckOperator(leftValue, rightValue) == OPERATOR.DOUBLEDOUBLE)
            {
                PairType<double, double> tempCalc = new PairType<double, double>() { lValue = doubleLeftValue, rValue = doubleRightValue };
                result = tempCalc.lValue / tempCalc.rValue;
            }
            else
                result = (object)0;
        }

        return result;

    }
}
