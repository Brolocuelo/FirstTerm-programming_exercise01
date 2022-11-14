using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public string vowel;

    private void Start()
    {
        if (vowel == "a" || vowel == "e" || vowel == "i" || vowel == "o" || vowel == "u")
        {
            Debug.Log("This letter is a vowel");
        }
        else 
        {
            Debug.Log("This letter is a consonant");
        }
    }
}
