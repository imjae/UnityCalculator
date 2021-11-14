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
    public Button backButton;
    public Button PNButton;
    public Button DotButton;
    public Button EqualButton;

    private string buttonName;

    private bool isCalculation = false;

    void Start()
    {
        // 클릭 이벤트리스터 추가
        #region Button : AddClickListener
        ClearButtonAddListener();
        ClearEditButtonAddListener();
        BackButtonAddListener();
        PNButtonAddListener();
        DotButtonAddListener();
        EqualButtonAddListener();
        numberButtonList.ForEach(button =>
        {
            NumberButtonAddListener(button);
        });
        symbolButtonList.ForEach(button =>
        {
            SymbolButtonAddListener(button);
        });
        #endregion

    }

    #region ButtonAddListener 메소드 모음
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
    void BackButtonAddListener()
    {
        backButton.onClick.AddListener(() =>
        {
            BackButtonClick();
        });
    }
    void PNButtonAddListener()
    {
        PNButton.onClick.AddListener(() =>
        {
            PNButtonClick();
        });
    }
    void DotButtonAddListener()
    {
        DotButton.onClick.AddListener(() =>
        {
            DotButtonClick();
        });
    }
    void EqualButtonAddListener()
    {
        EqualButton.onClick.AddListener(() =>
        {
            EqualButtonClick();
        });
    }
    #endregion
    #region ButtonClick 실제 동작 모음
    public void NumberClick(string text)
    {
        if (isCalculation)
        {
            CalcManager.Instance.ResultText = "";
            isCalculation = false;
        }

        if (long.TryParse(text, out long result))
        {
            string prevResult = CalcManager.Instance.ResultText;
            prevResult += (result + "");
            CalcManager.Instance.ResultText = String.Format("{0:#,0}", prevResult);
        }
    }
    public void SymbolClick(string text)
    {
        string tmpText = CalcManager.Instance.ResultText;
        // symbolClick으로 토글하기전에 true 라는건 숫자를아직 누르지 않았을 경우를 뜻함
        if (isCalculation)
        {
            CalcManager.Instance.symbolQueue.Enqueue(text);
            CalcManager.Instance.symbolQueue.Clear();
        }
        else
        {
            isCalculation = true;

            // 심볼 클릭했을 때, 입력되어 있던 숫자가 큐에 들어가야한다.
            // 큐에 숫자, 연산자 가 들어가고
            CalcManager.Instance.numberQueue.Enqueue(tmpText);
            CalcManager.Instance.symbolQueue.Enqueue(text);
        }

        if (CalcManager.Instance.numberQueue.Count >= 2)
        {
            object result = SymbolCalcQueue();
            CalcManager.Instance.numberQueue.Clear();
            CalcManager.Instance.numberQueue.Enqueue(result.ToString());
            CalcManager.Instance.ResultText = result.ToString();

            CalcManager.Instance.ExpressionText = CalcManager.Instance.numberQueue.Peek() + CalcManager.Instance.symbolQueue.Peek();
        }
        else
        {
            CalcManager.Instance.ExpressionText = tmpText + text;
        }
    }

    public void ClearClick()
    {
        CalcManager.Instance.numberQueue.Clear();
        CalcManager.Instance.symbolQueue.Clear();
        CalcManager.Instance.ResultText = "";
        CalcManager.Instance.ExpressionText = "";
    }
    public void ClearEditClick()
    {
        CalcManager.Instance.ResultText = "";
    }

    public void BackButtonClick()
    {
        string tmpResultText = CalcManager.Instance.ResultText;
        CalcManager.Instance.ResultText = tmpResultText.Substring(0, tmpResultText.Length - 1);
    }
    public void PNButtonClick()
    {
        isCalculation = false;
        string tmpResultText = CalcManager.Instance.ResultText;
        if (tmpResultText.Substring(0, 1) != "-")
        {
            tmpResultText = "-" + tmpResultText;
        }
        else
        {
            tmpResultText = tmpResultText.Substring(1, tmpResultText.Length - 1);
        }
        CalcManager.Instance.ResultText = tmpResultText;
    }
    public void DotButtonClick()
    {
        string tmpResultText = CalcManager.Instance.ResultText;
        if (tmpResultText.IndexOf(".") == -1)
        {
            tmpResultText += ".";
            CalcManager.Instance.ResultText = tmpResultText;
        }

        if (isCalculation)
        {
            CalcManager.Instance.ResultText = "0.";
            isCalculation = false;
        }
        else
        {
            CalcManager.Instance.ResultText = tmpResultText;
        }
    }

    public void EqualButtonClick()
    {
        string tmpText = CalcManager.Instance.ResultText;

        isCalculation = true;
        CalcManager.Instance.numberQueue.Enqueue(tmpText);

        if (CalcManager.Instance.numberQueue.Count >= 2)
        {
            object result = EqualCalcQueue();
            CalcManager.Instance.numberQueue.Clear();
            CalcManager.Instance.numberQueue.Enqueue(result.ToString());
            CalcManager.Instance.ResultText = result.ToString();
        }
    }
    #endregion 

    public object SymbolCalcQueue()
    {
        object result = null;

        string leftValue = CalcManager.Instance.numberQueue.Dequeue();
        string rightValue = CalcManager.Instance.numberQueue.Dequeue();

        string symbol = CalcManager.Instance.symbolQueue.Dequeue();


        Calculator calc = new Calculator() { leftValue = leftValue, rightValue = rightValue };

        if (symbol.Equals("+"))
            result = calc.Plus();
        else if (symbol.Equals("-"))
            result = calc.Subtract();
        else if (symbol.Equals("*"))
            result = calc.Multiply();
        else if (symbol.Equals("/"))
            result = calc.Division();

        return result;
    }

    public object EqualCalcQueue()
    {
        object result = null;

        string leftValue = CalcManager.Instance.numberQueue.Dequeue();
        string rightValue = CalcManager.Instance.numberQueue.Dequeue();

        string symbol = CalcManager.Instance.symbolQueue.Dequeue();

        CalcManager.Instance.ExpressionText = leftValue + symbol + rightValue + "=";

        Calculator calc = new Calculator() { leftValue = leftValue, rightValue = rightValue };

        if (symbol.Equals("+"))
            result = calc.Plus();
        else if (symbol.Equals("-"))
            result = calc.Subtract();
        else if (symbol.Equals("*"))
            result = calc.Multiply();
        else if (symbol.Equals("/"))
            result = calc.Division();

        return result;
    }
}
