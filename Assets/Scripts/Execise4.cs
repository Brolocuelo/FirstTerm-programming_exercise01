using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Execise4 : MonoBehaviour
{
    public int birthYear;
    public int currentYear;

    public int age;

    private void Start()
    {
        age = currentYear - birthYear;
        Debug.Log($"if we are in the year {currentYear} and you were born in {birthYear}, you are {age} years old");
    }
}
