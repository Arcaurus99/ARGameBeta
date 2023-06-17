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
    private static bool isGameMenu = false;
    public bool IsGameMenu {get {return isGameMenu; }}
    public event Action OnARPosition; // Posicionando objeto
    private static bool isARPosition = false; 
    public bool IsARPosition {get {return isARPosition; }}

    public event Action OnParacite; // Paracites escene
    private static bool isParacite = false;
    public bool IsParacite {get {return isParacite; }}
    public event Action OnDetailsMenu; // Details menu on Paracites escene
    private static bool isDetailsMenu = false;
    public bool IsDetailsMenu {get {return isDetailsMenu; }}

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
        //isGameMenu = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameMenu()
    {
        OnGameMenu?.Invoke();
        isGameMenu = true;
        isARPosition = false;
        isParacite = false;
        isDetailsMenu = false;
        Status();
    }

    /*public void CharactersMenu()
    {
        OnCharactersMenu?.Invoke();
        Debug.Log("Items Menu Activated");
    }*/

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        isGameMenu = false;
        isARPosition = true;
        isParacite = false;
        isDetailsMenu = false;
        Status();
    }

    public void Paracite()
    {
        OnParacite?.Invoke();
        isGameMenu = false;
        isARPosition = false;
        isParacite = true;
        isDetailsMenu = false;
        Status();
    }

    public void DetailsMenu()
    {
        OnDetailsMenu?.Invoke();
        isGameMenu = false;
        isARPosition = false;
        isParacite = false;
        isDetailsMenu = true;
        Status();
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    //Status
    public void Status()
    {
        //Debug.Log("Game Menu: " + isGameMenu + " / AR Position: " + isARPosition + " / Paracite: " + isParacite + " / Details Menu: " + isDetailsMenu);
    }

}