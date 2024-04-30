using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    // Start is called before the first frame update
     private GameObject popup = null;
       // Start is called before the first frame update
    void Start()
    {
        popup = GameObject.Find("GameplayPopup");
        popup.SetActive(false);
      
        popup.SetActive(true);

        Time.timeScale = 0f; // Pause game

    }
        

    // Update is called once per frame
    void Update()
    {
        
        if (popup != null && popup.gameObject.activeSelf && (Input.anyKeyDown || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Time.timeScale = 1f; // Resume game
                popup.gameObject.SetActive(false);
        }
        
    }
}
