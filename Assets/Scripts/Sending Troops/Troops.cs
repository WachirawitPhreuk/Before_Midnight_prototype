using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Troops : MonoBehaviour
{
    public int count = 0;
    public TextMeshProUGUI BigMen;
    public TextMeshProUGUI SmallMen;
    public WorkSceneManager wsm;
    public GameObject troopsSending;

    public int BigGuy=0;
    public int SmallGuy=0;

    public void Update() {
    if(count == 15) 
    {
        wsm.MinigameDone(1);
        troopsSending.SetActive(false);
        count = 0;
        Destroy(troopsSending);
    }
    }
}
