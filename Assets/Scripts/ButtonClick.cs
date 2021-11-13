using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public List<Button> numberButtonList;
    public List<Button> symbolButtonList;
    public Button clearButton;
    public Button clearEditButton;

    private string buttonName;

    void Start()
    {
        // 클릭 이벤트리스터 추가
        #region Button : AddClickListener
        ClearButtonAddListener();
        ClearEditButtonAddListener();
        numberButtonList.ForEach(button => {
            NumberButtonAddListener(button);
        });
        symbolButtonList.ForEach(button => {
            SymbolButtonAddListener(button);
        });
        #endregion


    }


    void NumberButtonAddListener(Button clickedButton)
    {
        clickedButton.onClick.AddListener(() =>
        {
            NumberClick(clickedButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);
        });
    }
    void SymbolButtonAddListener(Button clickedButton)
    {
        clickedButton.onClick.AddListener(() =>
        {
            SymbolClick(clickedButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);
        });
    }

    void ClearButtonAddListener()
    {
        clearButton.onClick.AddListener(() => 
        {
            ClearClick();
        });
    }
    void ClearEditButtonAddListener()
    {
        clearEditButton.onClick.AddListener(() => 
        {
            ClearEditClick();
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
        Debug.Log(text);
        // 심볼 클릭했을 때, 입력되어 있던 숫자가 큐에 들어가야한다.
        if (char.TryParse(text, out char symbol))
        {
            string tmpText = CalcManager.Instance.ResultText;

            // 큐에 숫자, 연산자 가 들어가고
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
    public void ClearEditClick()
    {
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
