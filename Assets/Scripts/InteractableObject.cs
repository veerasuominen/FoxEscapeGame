using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    private PauseMenu pauseMenu;

    public int itemNumber = 0;
    public TMP_Text text;
    public int maxNumObjects = 5;

    private void Start()
    {
        text.text = itemNumber.ToString(itemNumber + "/" + maxNumObjects);
    }

    private void OnTriggerEnter()

    {
        Debug.Log("item");
        itemNumber++;
        gameObject.SetActive(false);
        text.text = itemNumber.ToString(itemNumber + "/" + maxNumObjects);
    }
}