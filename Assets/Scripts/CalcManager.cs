using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalcManager : MonoBehaviour
{
    private static CalcManager _instance;

    public static CalcManager Instance {
        get {
            return _instance;
        }
        set {
            if(_instance == null)
                _instance = value;
            else
                Destroy(value);
        }
    }

    public TextMeshProUGUI expression; 
    public TextMeshProUGUI result; 


    /// <summary>
    /// CalcManager : �̱��� Ŭ������ ���������� ������ ������Ʈ���� ������ �ִ�
    /// </summary>
    void Awake()
    {
        Instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
