using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public Canvas InfoCanvas; 
    public Canvas IntroCanvas;
    public Camera cam;
    RaycastHit hitObj;
    void Start()
    {
        InfoCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        InfoCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        Ray mouseRay = cam.ScreenPointToRay(pos);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(mouseRay, out hitObj))
            {
                if (hitObj.collider.gameObject.tag == "car")
                {
                    print(hitObj.collider.gameObject.tag);
                    showInfoCanvas();
                }
                    
            }
        }
    }

    public void showInfoCanvas()
    {
        InfoCanvas.enabled = true;
    }
    public void hideInfoCanvas()
    {
        InfoCanvas.enabled = false;
    }
    public void hideIntroCanvas()
    {
        IntroCanvas.enabled = false;
    }
    public void OpenWeb()
    {
        Application.OpenURL("https://play.niceday.tw/product/3235");
    }
}
