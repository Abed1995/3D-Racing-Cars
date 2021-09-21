using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonOptions : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void SelectTrack()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
