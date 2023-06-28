using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class DetailContentManager : MonoBehaviour
{
    // Character Variables
    private string detailName;
    private Sprite detailImage;

    // Character Data Value
    public string DetailName { set => detailName = value; }
    public Sprite DetailImage { set => detailImage = value; }

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<RawImage>().texture = detailImage.texture;
        transform.GetChild(1).GetComponent<Text>().text = detailName;

        var detailButton = GetComponent<Button>();
        detailButton.onClick.AddListener(Expand);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void Expand()
    {
        //transform.GetChild().
    }

}
