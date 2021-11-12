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
        if (int.TryParse(text, out int result))
        {
            string prevResult = CalcManager.Instance.ResultText;
            prevResult += (result+"");
            CalcManager.Instance.ResultText = prevResult;
        }
    }

    public void symbolClick(string text)
    {
        if(char.TryParse(text, out char symbol))
        {
            
        }
    }
}
