using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    bool paused = false;

    public GameObject panel;
    public GameObject playerCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == false)
            {
                PauseGame();
            }
            else
            {
                UnPauseGame();
            }
        }
    }

    public void PauseGame()
    {
        paused = true;
        playerCam.GetComponent<PlayerLook>().enabled = false;
        Time.timeScale = 0;
        panel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void UnPauseGame()
    {
        paused = false;
        playerCam.GetComponent<PlayerLook>().enabled = true;
        Time.timeScale = 1;
        panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
