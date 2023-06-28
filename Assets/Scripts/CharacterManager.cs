using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class CharacterManager : MonoBehaviour
{

    private GameObject modelParent;
    private GameObject model;
    
    public GameObject Char3DModel
    {
        set
        {
            DeleteModel();
            model = value;
            model.transform.position = modelParent.transform.position;
            model.transform.parent = modelParent.transform;
            model.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        modelParent = new GameObject("ModelParent"); // Creation of the GameObject to handle the new models on scene.
        
    }

    // Update is called once per frame
    void Update()
    {
        if (model != null)
        {
            model.transform.Rotate(Vector3.up, Time.deltaTime * 20f); // Rotation of the model on scene
        }
    }

    public void DeleteModel()
    {
        if (modelParent != null)
        {
            Destroy(modelParent);
            modelParent = new GameObject("ModelParent");
            GameManager.instance.Paracite();
        }
    }
}
