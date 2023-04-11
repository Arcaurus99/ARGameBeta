using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    /*public event Action OnMainMenu; // Menu inicial de juego
    public event Action OnCharactersMenu; // Seleccion de objeto*/
    
    public event Action OnGameMenu; // Menu inicial de juego
    public event Action OnARPosition; // Posicionando objeto 

    public event Action OnParacite; // Paracites escene
    public event Action OnDetailsMenu; // Details menu on Paracites escene

    public static GameManager instance;
    private void Awake() 
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GameMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameMenu()
    {
        OnGameMenu?.Invoke();
        Debug.Log("Game Menu Activated");
    }

    /*public void CharactersMenu()
    {
        OnCharactersMenu?.Invoke();
        Debug.Log("Items Menu Activated");
    }*/

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position Activated");
    }

    public void Paracite()
    {
        OnParacite?.Invoke();
        Debug.Log("Paracite Actived");
    }

    public void DetailsMenu()
    {
        OnDetailsMenu?.Invoke();
        Debug.Log("DetailsMenu Actived");
    }

    public void CloseApp()
    {
        Application.Quit();
    }

}