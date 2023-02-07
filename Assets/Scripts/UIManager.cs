using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject detailsMenuPanel; //DetailsMenu probably name exception
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnParacite += ActivateParacite;
        GameManager.instance.OnDetailsMenu += ActivateDetailsMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ActivateParacite()
    {
        mainPanel.transform.GetChild(4).transform.DOScale(new Vector3(0,1,1), 0.3f);
        //mainPanel.transform.GetChild(4).transform.DOMoveX(1, 0.3f);
    }

    private void ActivateDetailsMenu()
    {
        mainPanel.transform.GetChild(4).transform.DOScale(new Vector3(1,1,1), 0.3f);
        //mainPanel.transform.GetChild(4).transform.DOMoveX(0, 0.3f);
    }
}
