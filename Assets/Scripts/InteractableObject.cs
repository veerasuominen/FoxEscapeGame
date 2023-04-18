using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private PauseMenu pauseMenu;

    public float itemNumber = 0f;

    private void OnTriggerEnter()

    {
        Debug.Log("item");
        itemNumber++;
        gameObject.SetActive(false);
    }
}