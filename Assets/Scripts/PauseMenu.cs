using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}