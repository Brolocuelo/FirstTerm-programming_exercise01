using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Execise5 : MonoBehaviour
{
    public int x;
    public int y;

    private void Start()
    {
        if (x < y)
        {
            Debug.Log($"The value of y ({y}), is greater than the value of x ({x})");
        }
        else
        {
            Debug.Log($"The value of x ({x}), is greater than the value of y ({y})");
        }
    }
}
