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
    /// CalcManager : 싱글톤 클래스로 전역변수로 관리할 오브젝트들을 가지고 있다
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
