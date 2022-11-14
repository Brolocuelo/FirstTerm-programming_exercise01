using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
      public string month;

    private void Start()
    {
        if (month == "January" || month == "March" || month == "May" || month == "July" || month == "August" || month == "October" || month == "December")
        {
            Debug.Log("This month has 31 days");
        }
        else if (month == "April" || month == "June" || month == "September" || month == "November")
        {
            Debug.Log("This month has 30 days");
        }
        else
        {
            Debug.Log("This month has 28 or 29 days");
        }
    }
}
