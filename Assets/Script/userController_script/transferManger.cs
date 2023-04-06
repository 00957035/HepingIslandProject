using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class transferManger : MonoBehaviour
{
    public GameObject transferMenu;
    public GameObject sceneInfo;
    public Text sceneTitle;
    public Text sceneIntroducion;
    public sceneInformation[] sceneList = new sceneInformation[3];
	private int sceneIdx = 1;

    public void showTransferMunu(){
        transferMenu.SetActive(true);
    }
    public void changeScene(int idx){
        sceneIdx = idx;
        sceneInfo.SetActive(true);
        setSceneInfo(sceneIdx);
        Debug.Log(sceneIdx);
    }    
    public void exitSceneInfo(){
        sceneInfo.SetActive(false);
    }
    public void exitTransferMenu(){
        transferMenu.SetActive(false);
    }
    public void setSceneInfo(int idx){
		sceneTitle.text = sceneList[idx].sceneName;
        sceneIntroducion.text = sceneList[idx].sceneIntroduce;
	}
    public void transferToScene(){
        Debug.Log(sceneIdx);
        SceneManager.LoadScene(sceneList[sceneIdx].sceneLink);
    }

}
