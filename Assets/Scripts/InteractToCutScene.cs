using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractToCutScene : MonoBehaviour
{
    public bool isInRange;
    public Button interactButton;

    void Start()
    {
        interactButton.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            isInRange = true;
            interactButton.enabled = true;
            Debug.Log("Player now in range");
            interactButton.onClick.AddListener(CutScene);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            isInRange = false;
            interactButton.enabled = false;
            Debug.Log("Player now not in range");
        }
    }

    private void CutScene() {
        SceneManager.LoadScene(6);
    }
}