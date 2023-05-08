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

    public void MainTroops(int full) {
    count = count + full;
    if(count == 15) 
    {
        wsm.MinigameDone(1);
        troopsSending.SetActive(false);
        Destroy(troopsSending);
    }
    }
}
