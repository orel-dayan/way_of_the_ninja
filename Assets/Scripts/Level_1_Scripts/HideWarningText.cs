using System;
using System.Collections;
using UnityEngine;

public class HideWarningText : MonoBehaviour
{
    [SerializeField] float waitingTime = 5f;
 
    void Update()
    {
        StartCoroutine(WaitAndDeactivate());
    }

    IEnumerator WaitAndDeactivate()
    {
        yield return new WaitForSeconds(waitingTime);
        gameObject.SetActive(false);
    }
}
