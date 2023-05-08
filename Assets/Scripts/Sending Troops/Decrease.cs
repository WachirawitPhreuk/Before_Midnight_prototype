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
            troops.BigGuy -= 6;
            troops.BigMen.text = troops.BigGuy.ToString();
        }
    }

    public void MinusX1() 
    {
        if (troops.count > 0) 
        {
        troops.count = troops.count-1;
        troops.SmallGuy -= 1;
        troops.SmallMen.text = troops.SmallGuy.ToString();
        }
    }
}
