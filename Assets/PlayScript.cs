using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
        // loads the main menu
        pauseMenu.SetActive(true);
    }

    public void Play()
    {
        pauseMenu.SetActive(false);
    }

    public void Stop()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
