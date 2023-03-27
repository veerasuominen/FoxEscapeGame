using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject settingsPanel;
    public bool paused;
    public bool b_isActive;
    public bool b_isClosed;

    private void Start()
    {
        //panel = GameObject.Find("Canvas");
        //panel.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (b_isActive == false && Input.GetKeyDown(KeyCode.Escape))
        {
            IsActive();
        }
        else if (b_isActive == true && Input.GetKeyDown(KeyCode.Escape))
        {
            IsClosed();
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void IsActive()
    {
        panel.SetActive(true);
        b_isActive = true;
        Debug.Log("Opened");
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }

    public void IsClosed()
    {
        panel.SetActive(false);
        b_isActive = false;
        Debug.Log("Closed");
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Settings()
    {
        paused = true;
        panel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Resume()
    {
        IsActive();
    }
}