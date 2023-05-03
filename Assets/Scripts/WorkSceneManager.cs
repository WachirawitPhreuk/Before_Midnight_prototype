using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorkSceneManager : MonoBehaviour
{
    private int progress;
    
    // Start is called before the first frame update
    void Start()
    {
        progress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(progress >= 100) {
            SceneManager.LoadScene(3);
        }
    }
}
