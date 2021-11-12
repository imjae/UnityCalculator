using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public Button[] numberButtonArr;

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
            string prevResult = CalcManager.Instance.result.text;
            prevResult += text;
            Debug.Log(prevResult);

            CalcManager.Instance.result.text = prevResult;



            // switch (result)
            // {
            //     case 0:
            //         break;
            //     case 1:
            //         break;
            //     case 2:
            //         break;
            //     case 3:
            //         break;
            //     case 4:
            //         break;
            //     case 5:
            //         break;
            //     case 6:
            //         break;
            //     case 7:
            //         break;
            //     case 8:
            //         break;
            //     case 9:
            //         break;
            // }
        }
    }
}
