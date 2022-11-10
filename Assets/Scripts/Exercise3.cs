using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public string name;
    public int age;

    private void Start()
    {
        Debug.Log($"Hello, {name}! You are {age} years old");
    }
}
