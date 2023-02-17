using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public GameObject ChangeCanva;
    public void change(){ //進入兌換場警
        SceneManager.LoadScene(ChangeCanva.GetComponent<changeInfo>().SceneName);
        //SceneManager.LoadScene(collision.gameObject.GetComponent<sceneInfo>().SceneName);
    }
    public void cancel(){ //關閉canvas
       ChangeCanva.SetActive(false);
    }
}
