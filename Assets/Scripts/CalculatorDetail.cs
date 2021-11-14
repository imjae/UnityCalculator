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
        // PlusTemplate((leftValue, rightValue) => {
        //     this.result = leftValue + rightValue;
        // });
    }

    public void Subtract()
    {
        this.result = leftValue - rightValue;
        // SubtractTemplate((leftValue, rightValue) => {
        //     this.result = leftValue - rightValue;
        // });
    }

    public void Multiply()
    {
        this.result = leftValue * rightValue;
        // MultiplyTemplate((leftValue, rightValue) => {
        //     this.result = leftValue * rightValue;
        // });
    }

    public void Division()
    {
        double tmpLeftValue = 0.0;
        if (rightValue == 0)
        {
            this.result = "Cannot be divided by 0";
        }
        else
        {
            if (leftValue % rightValue != 0)
            {
                tmpLeftValue = leftValue;
                this.result = tmpLeftValue / rightValue;
            }
            else
            {
                this.result = leftValue / rightValue;
            }
        }
        // DivisionTemplate((leftValue, rightValue) => {
        //     this.result = leftValue / rightValue;
        // });
    }
}

public class LongDoubleCalculator : CalculatorTemplate<long, double>
{
    public long leftValue;
    public double rightValue;

    public object result;
    public void Plus()
    {
        this.result = leftValue + rightValue;
        // PlusTemplate((leftValue, rightValue) => {
        //     this.result = leftValue + rightValue;
        // });
    }

    public void Subtract()
    {
        this.result = leftValue - rightValue;
        // SubtractTemplate((leftValue, rightValue) => {
        //     this.result = leftValue - rightValue;
        // });
    }

    public void Multiply()
    {
        this.result = leftValue * rightValue;
        // MultiplyTemplate((leftValue, rightValue) => {
        //     this.result = leftValue * rightValue;
        // });
    }

    public void Division()
    {
        this.result = leftValue / rightValue;
        // DivisionTemplate((leftValue, rightValue) => {
        //     this.result = leftValue / rightValue;
        // });
    }
}


public class DoubleLongCalculator : CalculatorTemplate<double, long>
{
    public double leftValue;
    public long rightValue;

    public object result;
    public void Plus()
    {
        this.result = leftValue + rightValue;
        // PlusTemplate((leftValue, rightValue) => {
        //     this.result = leftValue + rightValue;
        // });
    }

    public void Subtract()
    {
        this.result = leftValue - rightValue;
        // SubtractTemplate((leftValue, rightValue) => {
        //     this.result = leftValue - rightValue;
        // });
    }

    public void Multiply()
    {
        this.result = leftValue * rightValue;
        // MultiplyTemplate((leftValue, rightValue) => {
        //     this.result = leftValue * rightValue;
        // });
    }

    public void Division()
    {
        this.result = leftValue / rightValue;
        // DivisionTemplate((leftValue, rightValue) => {
        //     this.result = leftValue / rightValue;
        // });
    }
}



public class DoubleDoubleCalculator : CalculatorTemplate<double, double>
{
    public double leftValue;
    public double rightValue;

    public object result;
    public void Plus()
    {
        this.result = leftValue + rightValue;
        // PlusTemplate((leftValue, rightValue) => {
        //     this.result = leftValue + rightValue;
        // });
    }

    public void Subtract()
    {
        this.result = leftValue - rightValue;
        // SubtractTemplate((leftValue, rightValue) => {
        //     this.result = leftValue - rightValue;
        // });
    }

    public void Multiply()
    {
        this.result = leftValue * rightValue;
        // MultiplyTemplate((leftValue, rightValue) => {
        //     this.result = leftValue * rightValue;
        // });
    }

    public void Division()
    {
        this.result = leftValue / rightValue;
        // DivisionTemplate((leftValue, rightValue) => {
        //     this.result = leftValue / rightValue;
        // });
    }
}