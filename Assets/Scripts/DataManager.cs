using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<Character> characters = new List <Character>();
    [SerializeField] private GameObject buttonContainer;
    [SerializeField] private CharacterButtonManager characterButtonManager;
    
    public List<Character> CharacterList {get {return characters; }}
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnParacite += CreateCharacters;
    }

    private void CreateCharacters()
    {
        foreach (var character in characters)
        {
            CharacterButtonManager characterButton;
            characterButton = Instantiate(characterButtonManager, buttonContainer.transform);
            characterButton.CharacterName = character.CharacterName;
            characterButton.CharacterDescription = character.CharacterDescription;
            characterButton.CharacterImage = character.CharacterImage;
            characterButton.Character3DModel = character.Character3DModel;
        }

        GameManager.instance.OnParacite -= CreateCharacters;
    }
}
