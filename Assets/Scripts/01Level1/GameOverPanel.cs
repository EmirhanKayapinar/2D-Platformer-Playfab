using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    
    
    public void RestartOnClick()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }

    
    
}
