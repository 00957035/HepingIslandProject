using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterManager : MonoBehaviour
{
    public characterDatabase characterDB;

    public int RoleNumber ;
    public Text[] nameText = new Text[3];
    //public Sprite currimage;
    public GameObject role1;
    public GameObject role2;
    public GameObject role3;

    static public int selectedOption = 0;
    void Start()
    {
        StartCharater();
        //RoleNumber = characterDB.CharacterCount;
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
        Debug.Log(selectedOption);
        UpdateCharater(selectedOption);
    }

    public void BackOption()
    {
        //selectedOption--;

        //Debug.Log(-1%9);
        selectedOption = (--selectedOption + RoleNumber) % RoleNumber;
        //if (selectedOption < 0)
        //{
        //    selectedOption = characterDB.CharacterCount-1 ;
        //}
        UpdateCharater(selectedOption);
    }

    private void UpdateCharater(int selectedOption)//0
    {
        for(int i = 0; i < 3; i++)
        {
            character role = characterDB.GetCharactor(selectedOption);//get role info from database
            string aim = "ROLE" + (i+1);
            Image image = GameObject.Find(aim).GetComponent<Image>();//find ROLE1 ROLE2 ROLE3 OBJ
            image.sprite = role.CharSprite;
            Debug.Log(image);
            Debug.Log(selectedOption);
            Debug.Log(role.CharName);
            nameText[i].text = role.CharName;      
            //Debug.Log("Image Name: " + image.name + "type: " + role.CharSprite);
            selectedOption = (++selectedOption) % RoleNumber;
        }
    }

    private void StartCharater()//0
    {
        for(int i = 0; i < 3; i++){
            if(i == 0){
                character role = characterDB.GetCharactor(i);//get role info from database
                Image image = role1.GetComponent<Image>();
                image.sprite = role.CharSprite;
                nameText[0].text = role.CharName;
            }
            else if(i == 1){
                character role = characterDB.GetCharactor(i);//get role info from database
                Image image = role2.GetComponent<Image>();
                image.sprite = role.CharSprite;
                nameText[1].text = role.CharName;
            }
            else{
                character role = characterDB.GetCharactor(i);//get role info from database
                Image image = role3.GetComponent<Image>();
                image.sprite = role.CharSprite;
                nameText[2].text = role.CharName;
            }
        }
    }
}
