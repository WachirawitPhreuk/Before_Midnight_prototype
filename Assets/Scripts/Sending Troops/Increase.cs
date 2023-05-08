using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Increase : MonoBehaviour
{
    public Troops troops;
    
    public void PlusX6() 
    {
        troops.count = troops.count+6;
    }

    public void PlusX1() 
    {
        troops.count = troops.count+1;
    }

    
}
