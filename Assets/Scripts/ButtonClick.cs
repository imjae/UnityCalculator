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

    private string buttonName;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        for(int i=0; i<=9; i++)
        {
            NumberButtonAddListener(numberButtonArr[i]);
        }
    }

    void NumberButtonAddListener(Button clickedButton)
    {   
        clickedButton.onClick.AddListener(()=>{
            NumberClick(clickedButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);
        });
    }

    public void NumberClick(string text)
    {
        if (long.TryParse(text, out long result))
        {
            string prevResult = CalcManager.Instance.ResultText;
            prevResult += (result+"");
            CalcManager.Instance.ResultText = String.Format("{0:#,0}", prevResult);
        }
    }

    public void symbolClick(string text)
    {
        if(char.TryParse(text, out char symbol))
        {
            string tmpText = CalcManager.Instance.ResultText;

            // 큐에 숫자, 연산자 가 들어가고
            if(long.TryParse(tmpText, out long longText))
                CalcManager.Instance.numberQueue.Enqueue(longText);
            
            CalcManager.Instance.symbolQueue.Enqueue(symbol);


            // CalcManager.Instance.ExpressionText = 
        }
    }

    public void CalcQueue(Queue<long> numberQueue, Queue<char> symbolQueue)
    {
        long leftValue = numberQueue.Dequeue();
        long rightValue = numberQueue.Dequeue();

        char symbol = symbolQueue.Dequeue();


    }
}
