using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSwitch : MonoBehaviour
{
    static public MainSwitch Instance;
    public WorkSceneManager wsm;
    public GameObject theSwitch;
    public int switchCount;
    private int onCount = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }
    
    public void SwitchChange(int points) {
        onCount = onCount + points;
        if (onCount == switchCount)
        {
            wsm.MinigameDone(1);
            theSwitch.SetActive(false);
            Destroy(theSwitch);
        }
    }
}
