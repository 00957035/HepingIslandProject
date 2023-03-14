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
	public int sceneIdx = 1;
    public sceneInformation[] sceneList = new sceneInformation[3];

    public void showTransferMunu(){
        transferMenu.SetActive(true);
    }
    public void changeScene(int idx){
        sceneIdx = idx;
        sceneInfo.SetActive(true);
        setSceneInfo(sceneIdx);
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
        SceneManager.LoadScene(sceneList[sceneIdx].sceneLink);
    }
}
