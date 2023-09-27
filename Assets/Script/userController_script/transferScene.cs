using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class transferScene : MonoBehaviour
{
    // Start is called before the first frame update
    private int index = transferManger.sceneIdx;
    private string[] link = new string[] { "ShoppingScene", "MuseumScene", "BoatScene" };
    void Start()
    {
       // sceneList = transferManger.sceneList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void transferToScene()
    {
        index = transferManger.sceneIdx;
        Debug.Log("index" + index);
        SceneManager.LoadScene(link[index]);
    }
}
