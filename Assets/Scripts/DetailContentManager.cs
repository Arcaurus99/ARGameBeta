using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class DetailContentManager : MonoBehaviour
{
    // Character Variables
    [SerializeField] private GameObject detailInfo;
    [SerializeField] private GameObject detailCont;
    [SerializeField] private GameObject conteiner;
    private RectTransform rt;
    private LayoutElement le;
    private string detailName;
    private Sprite detailImage;

    public bool flag = true;

    // Character Data Value
    //public string DetailName { set => detailName = value; }
    //public Sprite DetailImage { set => detailImage = value; }

    // Start is called before the first frame update
    void Start()
    {
        //transform.GetChild(0).GetComponent<RawImage>().texture = detailImage.texture;
        //transform.GetChild(1).GetComponent<Text>().text = detailName;

        var button = GetComponent<Button>();
        //button.onClick.AddListener(Expand);
        Expand();
    }

    // Update is called once per frame
    void Update()
    {
        Expand();
    }
    
    // Expand method to interact as a hide info
    private void Expand()
    {   
        detailInfo.SetActive(true);
        var rtInfo = (RectTransform)detailInfo.transform;
        var leCont = detailCont.GetComponent<LayoutElement>();
        float h = LayoutUtility.GetPreferredHeight(rtInfo);
        leCont.preferredHeight = h + 55;
        RefreshSpacing();
    }

    private void RefreshSpacing()
    {   
        var cont = conteiner.GetComponent<HorizontalOrVerticalLayoutGroup>();
        if (flag == true)
        {
            cont.spacing += 0.001f;
            flag = false;
        }
        else
        {
            cont.spacing -= 0.001f;
            flag = true;
        }
    }

}
