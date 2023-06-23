using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARInteractionsManager : MonoBehaviour
{
    [SerializeField] private Camera aRCamera;
    private ARRaycastManager aRRaycastManager;
    private List <ARRaycastHit> hits = new List<ARRaycastHit>();

    private GameObject aRPointer;
    private GameObject item3DModel;
    private bool isInitialPosition;

    public GameObject Item3DModel
    {
        set
        {
            item3DModel = value;
            item3DModel.transform.position = aRPointer.transform.position;
            item3DModel.transform.parent = aRPointer.transform;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        aRPointer = transform.GetChild(0).gameObject; 
        //aRRaycastManager = FindObjectType<ARRaycastManager>();
        GameManager.instance.OnParacite += SetItemPosition;

    }

    // Update is called once per frame
    void Update()
    {
        if(isInitialPosition)
        {
            Vector2 middlePointScreen = new Vector2(Screen.width / 2, Screen.height / 2);
            aRRaycastManager.Raycast(middlePointScreen, hits, TrackableType.Planes);
        }
    }

    private void SetItemPosition()
    {
        if (item3DModel != null)
        {
            item3DModel.transform.parent = null;
            aRPointer.SetActive(false);
            Item3DModel = null;
        }
    }

    public void DeleteModel()
    {
        Destroy(item3DModel);
        aRPointer.SetActive(false);
        GameManager.instance.Paracite();
    }
}
