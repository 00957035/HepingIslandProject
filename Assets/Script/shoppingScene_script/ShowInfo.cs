using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    Canvas InfoCanvas;
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
                print(hitObj.collider.gameObject.tag);
                if (hitObj.collider.gameObject.tag == "car")
                    showInfoCanvas();
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
}
