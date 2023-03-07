using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject detailsMenuPanel;
    [SerializeField] private GameObject btnMore;
    
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
        //mainPanel.transform.GetChild(5).transform.DOScale(new Vector3(0,1,1), 0.3f); # it's the same
        detailsMenuPanel.transform.DOScale(new Vector3(0,1,1), 0.3f);
        //mainPanel.transform.GetChild(2).transform.DOMoveX(26, 0.3f);
        btnMore.transform.DOScale(new Vector3(1,1,1), 0.3f);
    }

    private void ActivateDetailsMenu()
    {
        //mainPanel.transform.GetChild(5).transform.DOScale(new Vector3(1,1,1), 0.3f);
        detailsMenuPanel.transform.DOScale(new Vector3(1,1,1), 0.3f);
        //mainPanel.transform.GetChild(2).transform.DOMoveX(28, 0.3f);
        //btnMore.transform.DOScale(1, 0.3f);
        btnMore.transform.DOScale(new Vector3(0,0,0), 0.3f);
    }
}
