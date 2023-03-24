using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class start : MonoBehaviour
{
   public GameObject startCanvas;
    public GameObject loginCanvas;

    public void showLoginCanvas(){
        loginCanvas.SetActive(true);
    }
    public void login(){
        Debug.Log("login");
    }

    public void returnStart(){
        loginCanvas.SetActive(false);
        startCanvas.SetActive(true);
    }
}
