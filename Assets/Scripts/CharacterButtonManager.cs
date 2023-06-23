using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class CharacterButtonManager : MonoBehaviour
{
    // Character Variables
    private string characterName;
    private string characterDescription;
    private Sprite characterImage;
    private GameObject character3DModel;
    private CharacterManager characterManager;

    // Character Data Value
    public string CharacterName { set => characterName = value; }
    public string CharacterDescription { set => characterDescription = value; }
    public Sprite CharacterImage { set => characterImage = value; }
    public GameObject Character3DModel { set => character3DModel = value; }

    // UI GameObjects
    private GameObject paraciteName;
    private GameObject paraciteDesc;

    // Text Components
    Text txtParaciteName;
    Text txtParaciteDesc;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<RawImage>().texture = characterImage.texture;

        var button = GetComponent<Button>();
        button.onClick.AddListener(LoadInfo);
        button.onClick.AddListener(Create3DModel);

        characterManager = FindObjectOfType<CharacterManager>();
    }
    
    void Update()
    {
    }

    private void LoadInfo()
    {
        
        paraciteName = GameObject.Find("UIManager/MainPanel/Info-panel/txt-paraciteName");
        paraciteDesc = GameObject.Find("UIManager/MainPanel/Info-panel/txt-description");

        txtParaciteName = paraciteName.GetComponent<Text>();
        txtParaciteDesc = paraciteDesc.GetComponent<Text>();
        
        txtParaciteName.text = characterName;
        txtParaciteDesc.text = characterDescription;
    }

    private void Create3DModel()
    {
        characterManager.Char3DModel = Instantiate(character3DModel);
    }
}
