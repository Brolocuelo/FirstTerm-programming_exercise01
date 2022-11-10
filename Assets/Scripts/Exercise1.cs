using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public float value1 = 2.4f;
    public float value2 = 5.2f;
    public float value3 = 1.8f;

    public float result;

    private void Start()
    {
        result = value1 + value2 + value3;
        Debug.Log(result);
    }
}
