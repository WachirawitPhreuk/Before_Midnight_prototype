using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Increase : MonoBehaviour
{
    public Troops troops;
    
    public void PlusX6() 
    {
        troops.count = troops.count+6;
        troops.BigGuy += 6;
        troops.BigMen.text = troops.BigGuy.ToString();
    }

    public void PlusX1() 
    {
        troops.count = troops.count+1;
        troops.SmallGuy +=1;
        troops.SmallMen.text = troops.SmallGuy.ToString();
    }

    
}
