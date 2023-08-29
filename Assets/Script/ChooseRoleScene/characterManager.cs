using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterManager : MonoBehaviour
{
    public characterDatabase characterDB;

    public Text[] nameText = new Text[3];
    //public Sprite currimage;

    private static int selectedOption = 0;
    private int RoleNumber = 1;
    void Start()
    {
        //sUpdateCharater(selectedOption);
        RoleNumber = characterDB.CharacterCount;
    }

    // Update is called once per frame
    public void NextOption()
    {
        //selectedOption++;
        selectedOption = (++selectedOption) % RoleNumber;
        //if(selectedOption >= characterDB.CharacterCount)
        //{
        //    selectedOption = 0;
        //}
        UpdateCharater(selectedOption);
    }

    public void BackOption()
    {
        //selectedOption--;

        Debug.Log(-1%9);
        selectedOption = (--selectedOption + RoleNumber) % RoleNumber;
        //if (selectedOption < 0)
        //{
        //    selectedOption = characterDB.CharacterCount-1 ;
        //}
        UpdateCharater(selectedOption);
    }

    private void UpdateCharater(int selectedOption)
    {
        for(int i = 0; i < 3; i++)
        {
            character role = characterDB.GetCharactor(selectedOption);//get role info from database
            string aim = "ROLE" + (i+1);
            Image image = GameObject.Find(aim).GetComponent<Image>();//find ROLE1 ROLE2 ROLE3 OBJ
            image.sprite = role.CharSprite;
            nameText[i].text = role.CharName;
            //Debug.Log("Image Name: " + image.name + "type: " + role.CharSprite);
            selectedOption = (++selectedOption) % RoleNumber;
        }
        //currimage = GameObject.Find("ROLE1").GetComponent<Sprite>();

    }

    public int GetCurrentOption()
    {
        return selectedOption;
    }
}
