using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongLongCalculator<T, U> : CalculatorTemplate<T, U> 
                where T : TypeNumber<long>
                where U : TypeNumber<long>
{
    public T leftValue;
    public U rightValue;

    public object result;
    public void Plus()
    {
        PlusTemplate(this.leftValue, this.rightValue);
    }

    public void Subtract()
    {
        SubtractTemplate(this.leftValue, this.rightValue);
        // SubtractTemplate((leftValue, rightValue) => {
        //     this.result = leftValue - rightValue;
        // });
    }

    public void Multiply()
    {
        MultiplyTemplate(this.leftValue, this.rightValue);
        // MultiplyTemplate((leftValue, rightValue) => {
        //     this.result = leftValue * rightValue;
        // });
    }

    public void Division()
    {
        MultiplyTemplate(this.leftValue, this.rightValue);
    }
}

// public class LongDoubleCalculator : CalculatorTemplate<long, double>
// {
//     public long leftValue;
//     public double rightValue;

//     public object result;
//     public void Plus()
//     {
//         this.result = leftValue + rightValue;
//         // PlusTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue + rightValue;
//         // });
//     }

//     public void Subtract()
//     {
//         this.result = leftValue - rightValue;
//         // SubtractTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue - rightValue;
//         // });
//     }

//     public void Multiply()
//     {
//         this.result = leftValue * rightValue;
//         // MultiplyTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue * rightValue;
//         // });
//     }

//     public void Division()
//     {
//         this.result = leftValue / rightValue;
//         // DivisionTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue / rightValue;
//         // });
//     }
// }


// public class DoubleLongCalculator : CalculatorTemplate<double, long>
// {
//     public double leftValue;
//     public long rightValue;

//     public object result;
//     public void Plus()
//     {
//         this.result = leftValue + rightValue;
//         // PlusTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue + rightValue;
//         // });
//     }

//     public void Subtract()
//     {
//         this.result = leftValue - rightValue;
//         // SubtractTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue - rightValue;
//         // });
//     }

//     public void Multiply()
//     {
//         this.result = leftValue * rightValue;
//         // MultiplyTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue * rightValue;
//         // });
//     }

//     public void Division()
//     {
//         this.result = leftValue / rightValue;
//         // DivisionTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue / rightValue;
//         // });
//     }
// }



// public class DoubleDoubleCalculator : CalculatorTemplate<double, double>
// {
//     public double leftValue;
//     public double rightValue;

//     public object result;
//     public void Plus()
//     {
//         this.result = leftValue + rightValue;
//         // PlusTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue + rightValue;
//         // });
//     }

//     public void Subtract()
//     {
//         this.result = leftValue - rightValue;
//         // SubtractTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue - rightValue;
//         // });
//     }

//     public void Multiply()
//     {
//         this.result = leftValue * rightValue;
//         // MultiplyTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue * rightValue;
//         // });
//     }

//     public void Division()
//     {
//         this.result = leftValue / rightValue;
//         // DivisionTemplate((leftValue, rightValue) => {
//         //     this.result = leftValue / rightValue;
//         // });
//     }
// }