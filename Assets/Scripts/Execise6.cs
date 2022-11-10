using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Execise6 : MonoBehaviour
{
    public int x;

    private void Start()
    {
        if (x <= 5)
        {
            Debug.Log($"Day {x} does not belong to the weekend");
        }
        else if(x > 5)
        {
            if (x <= 7)
            {
                Debug.Log($"Day {x} belongs to the weekend");
            }
        }
    }
}
