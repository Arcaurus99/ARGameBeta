using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class CharacterButtonManager : MonoBehaviour
{
    private string characterName;
    private string characterDescription;
    private Sprite characterImage;
    private GameObject character3DModel;

    public string CharacterName { set => characterName = value; }
    public string CharacterDescription { set => characterDescription = value; }
    public Sprite CharacterImage { set => characterImage = value; }
    public GameObject Character3DModel { set => character3DModel = value; }

    public GameObject modelParent;
    private GameObject model;

    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<RawImage>().texture = characterImage.texture;

        var button = GetComponent<Button>();
        button.onClick.AddListener(LoadInfo);
        button.onClick.AddListener(Create3DModel);
    }
    
    private void LoadInfo()
    {
        
    }

    private void Create3DModel()
    {
        
        /*if (obj3DModelParent != null)
        {
            Destroy(obj3DModelParent);
            Create(obj3DModelParent);
        }*/
        //modelParent = GameObject.Find("UIManager/MainPanel/ModelParent");
        model = Instantiate(character3DModel);
        //model.transform.position = modelParent.transform.position;
        //model.transform.parent = modelParent.transform;
        character3DModel.transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }

    /*private void SetCharacterPosition()
    {
        if (character3DModel != null)
        {
            
        }
    }*/
}
