using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongLongCalculator : CalculatorTemplate<long, long>
{
    public long leftValue, rightValue;

    public object result;
    public void Plus()
    {
        this.result = leftValue + rightValue;
        // Debug.Log($"{leftValue} {rightValue}");
        // PlusTemplate((leftValue, rightValue) => {
        //     // Debug.Log($"LongLongCalculator ¿¡¼­ {leftValue} {rightValue} {leftValue + rightValue}");
        //     this.result = leftValue + rightValue;
        // });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            this.result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            this.result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            this.result = leftValue / rightValue;
        });
    }
}

public class LongDoubleCalculator : CalculatorTemplate<long, double>
{
    public long leftValue;
    public double rightValue;

    public object result;
    public void Plus()
    {
        PlusTemplate((leftValue, rightValue) => {
            this.result = leftValue + rightValue;
        });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            this.result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            this.result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            this.result = leftValue / rightValue;
        });
    }
}


public class DoubleLongCalculator : CalculatorTemplate<double, long>
{
    public double leftValue;
    public long rightValue;

    public object result;
    public void Plus()
    {
        PlusTemplate((leftValue, rightValue) => {
            this.result = leftValue + rightValue;
        });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            this.result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            this.result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            this.result = leftValue / rightValue;
        });
    }
}



public class DoubleDoubleCalculator : CalculatorTemplate<double, double>
{
    public double leftValue;
    public double rightValue;

    public object result;
    public void Plus()
    {
        PlusTemplate((leftValue, rightValue) => {
            this.result = leftValue + rightValue;
        });
    }

    public void Subtract()
    {
        SubtractTemplate((leftValue, rightValue) => {
            this.result = leftValue - rightValue;
        });
    }
    
    public void Multiply()
    {
        MultiplyTemplate((leftValue, rightValue) => {
            this.result = leftValue * rightValue;
        });
    }
    
    public void Division()
    {
        DivisionTemplate((leftValue, rightValue) => {
            this.result = leftValue / rightValue;
        });
    }
}