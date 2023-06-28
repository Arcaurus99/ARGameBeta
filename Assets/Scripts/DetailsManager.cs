using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailsManager : MonoBehaviour
{
    [SerializeField] private List<Detail> details = new List <Detail>();
    [SerializeField] private GameObject detailContainer;
    [SerializeField] private DetailContentManager detailContentManager;
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnParacite += CreateDetails;
    }

    private void CreateDetails()
    {
        foreach (var detail in details)
        {
            DetailContentManager detailCont;
            detailCont = Instantiate(detailContentManager, detailContainer.transform);
            detailCont.DetailName = detail.DetailName;
            detailCont.DetailImage = detail.DetailImage;
        }

        GameManager.instance.OnParacite -= CreateDetails;
    }
}
