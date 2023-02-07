using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMenuGameScene()
    {
        SceneManager.LoadScene("MenuGameScene");
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToParacitesScene()
    {
        SceneManager.LoadScene("ParacitesScene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    /*
    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
    */
}
