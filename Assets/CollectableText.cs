using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectableText : MonoBehaviour
{
    public TMP_Text healthtext;
    public TMP_Text countertext;
    public int counter;
    public int maxNumObjects = 5;

    public PlayerController s_playerController;

    private void Start()
    {
        //countertext = GetComponentInChildren<TMP_Text>();
        //healthtext = GetComponentInChildren<TMP_Text>();
    }

    private void Update()
    {
        //keeps the counter up to date
        countertext.text = counter.ToString(counter + "/" + maxNumObjects);
        if (counter == maxNumObjects)
        {
            Debug.Log("won");
            Invoke("Won", 2);
        }

        healthtext.text = s_playerController.health.ToString();
    }

    private void Won()
    {
        SceneManager.LoadScene(0);
    }
}