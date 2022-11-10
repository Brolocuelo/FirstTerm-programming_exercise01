using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public string name;
    public string city;

    private void Start()
    {
        Debug.Log($"Hello, {name}! Welcome to {city}");
    }
}
