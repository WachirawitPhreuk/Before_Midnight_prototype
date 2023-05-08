using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decrease : MonoBehaviour
{
    public Troops troops;
    
    public void MinusX6() 
    {
        if (troops.count > 0)
        {
            troops.count = troops.count-6;
        }
    }

    public void MinusX1() 
    {
        if (troops.count > 0) 
        {
        troops.count = troops.count-1;
        }
    }
}
