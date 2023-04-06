using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public GameObject ChangeCanva;
    public GameObject ChooseBoatSceneCanvas;
    public void change(){ //進入兌換場警
        if(ChangeCanva.GetComponent<changeInfo>().SceneName == "BoatScene"){
            ChooseBoatSceneCanvas.SetActive(true);
        }else{
            SceneManager.LoadScene(ChangeCanva.GetComponent<changeInfo>().SceneName);
        }
        //SceneManager.LoadScene(collision.gameObject.GetComponent<sceneInfo>().SceneName);
    }
    public void goToBoatGame(){
        SceneManager.LoadScene("BoatScene");
    }
    public void goToBoatView(){
        SceneManager.LoadScene("BoatGameScene");
    }
    public void cancel(){ //關閉canvas
       ChangeCanva.SetActive(false);
    }
}
