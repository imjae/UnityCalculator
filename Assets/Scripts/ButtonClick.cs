using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public Button[] numberButtonArr;
    public Button[] symbolButtonArr;
    public Button clearButton;
    public Button clearEditButton;

    private string buttonName;

    void Start()
    {
        ClearButtonAddListener();
        for (int i = 0; i <= 9; i++)
        {
            NumberButtonAddListener(numberButtonArr[i]);
        }
    }

    void NumberButtonAddListener(Button clickedButton)
    {
        clickedButton.onClick.AddListener(() =>
        {
            NumberClick(clickedButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);
        });
    }

    void ClearButtonAddListener()
    {
        clearButton.onClick.AddListener(() => 
        {
            ClearClick();
        });
    }

    public void NumberClick(string text)
    {
        if (long.TryParse(text, out long result))
        {
            string prevResult = CalcManager.Instance.ResultText;
            prevResult += (result + "");
            CalcManager.Instance.ResultText = String.Format("{0:#,0}", prevResult);
        }
    }

    public void SymbolClick(string text)
    {
        // �ɺ� Ŭ������ ��, �ԷµǾ� �ִ� ���ڰ� ť�� �����Ѵ�.
        if (char.TryParse(text, out char symbol))
        {
            string tmpText = CalcManager.Instance.ResultText;

            // ť�� ����, ������ �� ����
            CalcManager.Instance.numberQueue.Enqueue(tmpText);

            CalcManager.Instance.symbolQueue.Enqueue(text);


            // CalcManager.Instance.ExpressionText = 
        }
    }

    public void ClearClick()
    {
        CalcManager.Instance.numberQueue.Clear();
        CalcManager.Instance.symbolQueue.Clear();
        CalcManager.Instance.ResultText = "";
    }

    public Calculator CalcQueue(Queue<string> numberQueue, Queue<string> symbolQueue)
    {
        string leftValue = numberQueue.Dequeue();
        string rightValue = numberQueue.Dequeue();

        string symbol = symbolQueue.Dequeue();

        Calculator calc = new Calculator() { leftValue = leftValue, rightValue = rightValue };

        if (symbol.Equals("+"))
            calc.Plus();
        else if (symbol.Equals("-"))
            calc.Subtract();
        else if (symbol.Equals("*"))
            calc.Multiply();
        else if (symbol.Equals("/"))
            calc.Division();

        return calc;
    }
}
