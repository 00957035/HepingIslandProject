using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeInfo : MonoBehaviour
{
    public string SceneName;
    public void changeGoTo(string goTo){ SceneName = goTo; }
}
