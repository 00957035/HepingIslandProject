using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterManager : MonoBehaviour
{
    public characterDatabase characterDB;

    public Text nameText;
    //public Sprite currimage;

    private int selectedOption = 0;
    void Start()
    {
        UpdateCharater(selectedOption);
    }

    // Update is called once per frame
    public void NextOption()
    {
        selectedOption++;
        if(selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }
        UpdateCharater(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount-1;
        }
        UpdateCharater(selectedOption);
    }

    private void UpdateCharater(int selectedOption)
    {
        character role = characterDB.GetCharactor(selectedOption);
        Image image = GameObject.Find("ROLE1").GetComponent<Image>();
        //currimage = GameObject.Find("ROLE1").GetComponent<Sprite>();
        image.sprite = role.CharSprite;
        nameText.text = role.CharName;
        Debug.Log("Image Name: " + image.name + "type: " + role.CharSprite);

    }
}
