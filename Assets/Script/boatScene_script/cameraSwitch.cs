using System;
using UnityEngine;
using UnityEngine.UI;

public class cameraSwitch : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject idle;

    public Text text;
    public int m_CurrentActiveObject;

    //private int m_CurrentActiveObject;

    void Update() {
        if(Input.GetKey(KeyCode.C)){
            NextCamera();
        }
    }
    private void OnEnable()
    {
        text.text = objects[m_CurrentActiveObject].name;
    }


    public void NextCamera()
    {
        //int nextactiveobject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

        /*for (int i = 0; i < objects.Length; i++)
        {
            Debug.Log(i+ "   " + nextactiveobject);
            objects[i].SetActive(i == nextactiveobject);
            if(m_CurrentActiveObject==0) idle.SetActive(true);
            else idle.SetActive(false);
        }*/

        //m_CurrentActiveObject = nextactiveobject;
        m_CurrentActiveObject = (m_CurrentActiveObject+1)%2;
        Debug.Log("m_CurrentActiveObject = " + m_CurrentActiveObject);

        if(m_CurrentActiveObject == 0){
            objects[0].SetActive(true);
            objects[1].SetActive(false);
            idle.SetActive(false);
        }else{
            objects[1].SetActive(true);
            objects[0].SetActive(false);
            idle.SetActive(true);
        }
        
        text.text = objects[m_CurrentActiveObject].name;
    }
}
