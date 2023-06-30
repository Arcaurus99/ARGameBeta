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

	private string characterPresence;
	private string characterContact;
	private string characterPopulation;
	private string characterLifecycle;
	private string characterSymptoms;
	private string characterDiagnosis;
	private string characterTreatment;

    // Character Data Value
    public string CharacterName { set => characterName = value; }
    public string CharacterDescription { set => characterDescription = value; }
    public Sprite CharacterImage { set => characterImage = value; }
    public GameObject Character3DModel { set => character3DModel = value; }

	public string CharacterPresence { set => characterPresence = value; }
	public string CharacterContact { set => characterContact= value; }
	public string CharacterPopulation { set => characterPopulation = value; }
	public string CharacterLifecycle { set => characterLifecycle = value; }
	public string CharacterSymptoms { set => characterSymptoms = value; }
	public string CharacterDiagnosis { set => characterDiagnosis = value; }
	public string CharacterTreatment { set => characterTreatment = value; }
    
    // Model Manager
    private CharacterManager characterManager;

    // UI GameObjects
    private GameObject paraciteName;
    private GameObject paraciteDesc;

	private GameObject parasitePresence;
	private GameObject parasiteContact;
	private GameObject parasitePopulation;
	private GameObject parasiteLifecycle;
	private GameObject parasiteSymptoms;
	private GameObject parasiteDiagnosis;
	private GameObject parasiteTreatment;

    // Text Components
    Text txtParaciteName;
    Text txtParaciteDesc;

	Text txtParasitePresence;
	Text txtParasiteContact;
	Text txtParasitePopulation;
	Text txtParasiteLifecycle;
	Text txtParasiteSymptoms;
	Text txtParasiteDiagnosis;
	Text txtParasiteTreatment;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<RawImage>().texture = characterImage.texture;

        var button = GetComponent<Button>();
        button.onClick.AddListener(LoadInfo);
        button.onClick.AddListener(Create3DModel);

        characterManager = FindObjectOfType<CharacterManager>();
    }
    
    void Update()
    {
    }

    private void LoadInfo()
    {
        
        paraciteName = GameObject.Find("UIManager/MainPanel/Info-panel/txt-paraciteName");
        paraciteDesc = GameObject.Find("UIManager/MainPanel/Info-panel/txt-description");

	    parasitePresence = GameObject.Find("UIManager/MainPanel/DetailsPanel/ScrollView/Viewport/Content/detailPresence/detailInfo");
	    parasiteContact = GameObject.Find("UIManager/MainPanel/DetailsPanel/ScrollView/Viewport/Content/detailContact/detailInfo");
	    parasitePopulation = GameObject.Find("UIManager/MainPanel/DetailsPanel/ScrollView/Viewport/Content/detailPopulation/detailInfo");
	    parasiteLifecycle = GameObject.Find("UIManager/MainPanel/DetailsPanel/ScrollView/Viewport/Content/detailLifecycle/detailInfo");
	    parasiteSymptoms = GameObject.Find("UIManager/MainPanel/DetailsPanel/ScrollView/Viewport/Content/detailSymptoms/detailInfo");
	    parasiteDiagnosis = GameObject.Find("UIManager/MainPanel/DetailsPanel/ScrollView/Viewport/Content/detailDiagnosis/detailInfo");
	    parasiteTreatment = GameObject.Find("UIManager/MainPanel/DetailsPanel/ScrollView/Viewport/Content/detailTreatment/detailInfo");

        txtParaciteName = paraciteName.GetComponent<Text>();
        txtParaciteDesc = paraciteDesc.GetComponent<Text>();

	    txtParasitePresence = parasitePresence.GetComponent<Text>();
	    txtParasiteContact = parasiteContact.GetComponent<Text>();
	    txtParasitePopulation = parasitePopulation.GetComponent<Text>();
	    txtParasiteLifecycle = parasiteLifecycle.GetComponent<Text>();
	    txtParasiteSymptoms = parasiteSymptoms.GetComponent<Text>();
	    txtParasiteDiagnosis = parasiteDiagnosis.GetComponent<Text>();
	    txtParasiteTreatment = parasiteTreatment.GetComponent<Text>();
        
        txtParaciteName.text = characterName;
        txtParaciteDesc.text = characterDescription;

	    txtParasitePresence.text = characterPresence;
	    txtParasiteContact.text = characterContact;
	    txtParasitePopulation.text = characterPopulation;
	    txtParasiteLifecycle.text = characterLifecycle;
	    txtParasiteSymptoms.text = characterSymptoms;
	    txtParasiteDiagnosis.text = characterDiagnosis;
	    txtParasiteTreatment.text = characterTreatment;
    }

    private void Create3DModel()
    {
        characterManager.Char3DModel = Instantiate(character3DModel);
    }
}
