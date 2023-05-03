using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public Button interactButton;
    public UnityEvent interactAction;
    public GameObject Minigame;
    // Start is called before the first frame update
    void Start()
    {
        interactButton.enabled = false;
        Minigame.SetActive(false);
        interactButton.onClick.AddListener(ShowMinigame);
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange) {
            interactAction.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            isInRange = true;
            interactButton.enabled = true;
            Debug.Log("Player now in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            isInRange = false;
            interactButton.enabled = false;
            Debug.Log("Player now not in range");
        }
    }

    private void ShowMinigame() {
        Minigame.SetActive(true);
    }
}
