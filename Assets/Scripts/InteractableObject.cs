using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    public CollectableText s_text;

    private void OnTriggerEnter(Collider collider)

    {
        //checks if object has the player tag before adding to the counter and deactivating the object
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("item");
            s_text.counter++;

            gameObject.SetActive(false);
        }
    }
}