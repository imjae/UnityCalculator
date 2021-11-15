using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PairType<T, U>
{
    private T _lValue;
    private U _rValue;

    public T lValue
    {
        get { return _lValue; }
        set { _lValue = value; }
    }
    public U rValue
    {
        get { return _rValue; }
        set { _rValue = value; }
    }
}


