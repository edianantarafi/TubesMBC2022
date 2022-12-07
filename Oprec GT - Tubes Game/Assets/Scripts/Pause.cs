using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject PauseMenu;

    public void Pausee()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Party() 
    {
        SceneManager.LoadScene("Party_Menu");
        Time.timeScale = 1f;
    }
    public void Title()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
