using System;
using System.Collections;
using System.Collections.Generic;

public class LongLongCalculator : CalculatorTemplate<long, long>
{
    public long leftValue, rightValue;

    public Object result;
    public void Plus()
    {
        PlusTemplate((leftValue, rightValue) => {
            result = leftValue + rightValue;
        });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            result = leftValue / rightValue;
        });
    }
}

public class LongDoubleCalculator : CalculatorTemplate<long, double>
{
    public long leftValue;
    public double rightValue;

    public Object result;
    public void Plus()
    {
        PlusTemplate((leftValue, rightValue) => {
            result = leftValue + rightValue;
        });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            result = leftValue / rightValue;
        });
    }
}


public class DoubleLongCalculator : CalculatorTemplate<double, long>
{
    public double leftValue;
    public long rightValue;

    public Object result;
    public void Plus()
    {
        PlusTemplate((leftValue, rightValue) => {
            result = leftValue + rightValue;
        });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            result = leftValue / rightValue;
        });
    }
}



public class DoubleDoubleCalculator : CalculatorTemplate<double, double>
{
    public double leftValue;
    public double rightValue;

    public Object result;
    public void Plus()
    {
        PlusTemplate((leftValue, rightValue) => {
            result = leftValue + rightValue;
        });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            result = leftValue / rightValue;
        });
    }
}