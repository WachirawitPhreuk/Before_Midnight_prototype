using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorkSceneManager : MonoBehaviour
{
    public int progress = 0;
    
    public void MinigameDone (int gameDone) {
        progress = progress + gameDone;
        if(progress == 3) {
            SceneManager.LoadScene(3);
        }
    }
}
