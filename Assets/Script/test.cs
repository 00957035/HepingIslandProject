using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision){ //collision為被碰之物件
    
        // if(collision.gameObject.name.Contains("Cube1")){
            
        //     //SceneManager.LoadScene(collision.gameObject.GetComponent<sceneInfo>().SceneName);
        //     //goTo = collision.gameObject.GetComponent<sceneInfo>().SceneName;
        //     ChangeCanva.GetComponent<changeInfo>().changeGoTo(collision.gameObject.GetComponent<sceneInfo>().SceneName);
        //     title.text = "是否兌換"+collision.gameObject.GetComponent<sceneInfo>().ProjectName + "?";
        //     ChangeCanva.SetActive(true);
        // }
        Debug.Log(collision.gameObject.name);
    }
}
