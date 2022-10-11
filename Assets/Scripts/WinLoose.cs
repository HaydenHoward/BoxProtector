using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoose : MonoBehaviour
{
    private bool gameEnded;
    public string nextLevelName;

    public GameObject winPanel;
    public GameObject loosePanel;


   public void WinLevel()
   {
        if(!gameEnded) 
        {
            Debug.Log("You Win!");

            winPanel.SetActive(true);

            gameEnded = true;
        }
   }

    public void LoadNextLevel()
    {
        if(nextLevelName != "")
            {
                SceneManager.LoadScene(nextLevelName);

            }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("titleScreen");
    }

   public void LooseLevel()
   {
        if(!gameEnded) 
        {
            Debug.Log("You Loose?");
            loosePanel.SetActive(true);
            gameEnded = true;
        }
   }
}
