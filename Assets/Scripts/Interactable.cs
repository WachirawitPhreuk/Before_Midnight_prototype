using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public Button interactButton;
    public GameObject Minigame;
    private bool isObjectShown = false; 
    // Start is called before the first frame update
    void Start()
    {
        interactButton.enabled = false;
        Minigame.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            isInRange = true;
            interactButton.enabled = true;
            Debug.Log("Player now in range");
            interactButton.onClick.AddListener(ShowMinigame);
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            isInRange = false;
            interactButton.enabled = false;
            Debug.Log("Player now not in range");
            interactButton.onClick.RemoveListener(ShowMinigame);
        }
    }

    private void ShowMinigame() {
        isObjectShown = !isObjectShown;
        Minigame.SetActive(isObjectShown);
        
    }
}