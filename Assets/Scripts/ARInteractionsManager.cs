using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEditor;
using System;


public class ARInteractionsManager : MonoBehaviour
{
    [SerializeField] private Camera aRCamera;
    [SerializeField] private GameObject btnCatch;

    private ARRaycastManager aRRaycastManager;
    private List <ARRaycastHit> hits = new List<ARRaycastHit>();

    public List<Character> ParasiteList;
    private DataManager data;

    private GameObject item3DModel;
    private bool isInitialPosition;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.ARPosition();
        //aRRaycastManager = FindObjectOfType<ARRaycastManager>();
        data = FindObjectOfType<DataManager>();
        ParasiteList = data.CharacterList;
        SpawnParasite();
        GameManager.instance.OnARPosition += SetItemPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (item3DModel != null)
        {
            btnCatch.SetActive(true);
            float dim = 0.3f;
            //item3DModel.transform.localScale = new Vector3(dim, dim, dim);
        }
        else
        {
            btnCatch.SetActive(false);
            SpawnParasite();
        }

        if(isInitialPosition)
        {
            Vector2 middlePointScreen = new Vector2(Screen.width / 2, Screen.height / 2);
            aRRaycastManager.Raycast(middlePointScreen, hits, TrackableType.Planes);
        }
    }

    private void SpawnParasite()
    {   
        // Measure and random pick of model to instance
        var length = 0;
        foreach (var character in ParasiteList)
        {
            length += 1;
            /*item3DModel = character.Character3DModel;
            Instantiate(item3DModel);*/
        }
        int rand = UnityEngine.Random.Range(0, length);
        Debug.Log(length + " length, pick " + rand);
        var parasite = ParasiteList[rand];
        item3DModel = Instantiate(parasite.Character3DModel);
        //Instantiate(item3DModel);
        float dim = 0.3f;
        item3DModel.transform.localScale = new Vector3(dim, dim, dim);
    }

    private void CatchParasite(){

    }

    private void SetItemPosition()
    {
        if (item3DModel != null)
        {
            item3DModel.transform.parent = null;
        }
    }

    public void DeleteModel()
    {
        Destroy(item3DModel);
        GameManager.instance.Paracite();
    }
}
