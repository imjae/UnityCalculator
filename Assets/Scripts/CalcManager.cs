using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalcManager : MonoBehaviour
{
    private static CalcManager _instance;


    public static CalcManager Instance
    {
        get { return _instance; }
        set
        {
            if (_instance == null)
                _instance = value;
            else
                Destroy(value);
        }
    }

    public TextMeshProUGUI expression;
    public TextMeshProUGUI result;

    public string ResultText
    {
        get { return result.text; }
        set { result.text = TransNumberFormat(value); }
    }

    public string ExpressionText
    {
        get { return expression.text; }
        set { expression.text = value; }
    }

    public Queue<string> numberQueue;
    public Queue<string> symbolQueue;

    /// <summary>
    /// CalcManager : 싱글톤 클래스로 전역변수로 관리할 오브젝트들을 가지고 있다
    /// </summary>
    void Awake()
    {
        Instance = this;
        numberQueue = new Queue<string>();
        symbolQueue = new Queue<string>();
    }

    public static string TransNumberFormat(string text)
    {
        string result = "";
        if (text == "")
            result = "0";
        else
        {
            if (int.TryParse(text, out int intResult))
                result = intResult + "";
            else if (float.TryParse(text, out float floatResult))
                result = floatResult + "";
            else if (double.TryParse(text, out double doubleResult))
                result = doubleResult + "";
        }

        return result;
    }
}
