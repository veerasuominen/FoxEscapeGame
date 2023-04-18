using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public InteractableObject interactableObject;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject settingsPanel;
    public TMP_Text text;
    public bool paused;
    public bool b_isActive;
    public bool b_isClosed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        text = GetComponentInChildren<TMP_Text>();
        //panel = GameObject.Find("Canvas");
        //panel.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        text.text = interactableObject.itemNumber.ToString();
        if (b_isActive == false && Input.GetKeyDown(KeyCode.Escape))
        {
            IsActive();
        }
        else if (b_isActive == true && Input.GetKeyDown(KeyCode.Escape))
        {
            IsClosed();
        }

        void Quit()
        {
            Application.Quit();
        }

        void IsActive()
        {
            panel.SetActive(true);
            b_isActive = true;
            Debug.Log("Opened");
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        void IsClosed()
        {
            panel.SetActive(false);
            b_isActive = false;
            Debug.Log("Closed");
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Settings()
        {
            paused = true;
            panel.SetActive(false);
            settingsPanel.SetActive(true);
        }

        void Resume()
        {
            IsActive();
        }
    }
}