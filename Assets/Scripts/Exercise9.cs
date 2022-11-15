using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise9 : MonoBehaviour
{
    public int avaibleCandy;
    public int amountOfPeople;
    private int result;
    private int result2;

    private void Start()
    {
        result = avaibleCandy % amountOfPeople;
        result2 = avaibleCandy / amountOfPeople;
        Debug.Log(string.Format("Each person takes {0}, and {1} are left",result2,result));
    }
}
