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

    // Character Data Value
    public string CharacterName { set => characterName = value; }
    public string CharacterDescription { set => characterDescription = value; }
    public Sprite CharacterImage { set => characterImage = value; }
    public GameObject Character3DModel { set => character3DModel = value; }

    // UI GameObjects
    public GameObject modelParent;
    private GameObject model;
    private GameObject paraciteName;
    private GameObject paraciteDesc;

    // Text Components
    Text txtParaciteName;
    Text txtParaciteDesc;

    //public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        // Button Creation
        transform.GetChild(0).GetComponent<RawImage>().texture = characterImage.texture;

        var button = GetComponent<Button>();
        button.onClick.AddListener(LoadInfo);
        button.onClick.AddListener(Create3DModel);
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
        
        
        //modelParent = GameObject.Find("UIManager/MainPanel/ModelParent");
        /*if (ModelParent != null)
        {
            Destroy(ModelParent);
            Create(ModelParent);
        }*/
        model = Instantiate(character3DModel);
        //model.transform.position = modelParent.transform.position;
        //model.transform.parent = modelParent.transform;
        //character3DModel.transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }

    /*private void SetCharacterPosition()
    {
        if (character3DModel != null)
        {
            
        }
    }*/
}
