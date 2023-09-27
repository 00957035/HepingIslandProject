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
	public static int sceneIdx;

     int getindex()
    {
        return sceneIdx;
    }
    public void showTransferMunu(){
        transferMenu.SetActive(true);
    }
    public void ChangeScene(int idx){
        sceneIdx = idx;
        sceneInfo.SetActive(true);
        setSceneInfo(sceneIdx);
        //Debug.Log("index" + sceneIdx);
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
    public  void transferToScene(){
        int i = getindex();
        //Debug.Log("trans"+sceneIdx+"i:"+i);
        SceneManager.LoadScene(sceneList[sceneIdx].sceneLink);
    }
    public void test()
    {
        Debug.Log("test:"+sceneIdx);
    }

}
