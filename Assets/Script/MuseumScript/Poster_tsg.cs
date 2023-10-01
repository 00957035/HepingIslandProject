using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster_tsg : MonoBehaviour
{
    Canvas InfoCanvas;
    public Camera cam;
    RaycastHit hitObj;
    void Start()
    {
        InfoCanvas = GameObject.Find("PosterCanvas").GetComponent<Canvas>();
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
                if (hitObj.collider.gameObject.tag == "0")
                    showInfoCanvas(hitObj.collider.gameObject.tag);
            }
        }
    }

    public void showInfoCanvas(string tag)
    {
        int number = int.Parse(tag);
        image.sprite = poster[index];
        InfoCanvas.enabled = true;
    }
    public void hideInfoCanvas()
    {
        InfoCanvas.enabled = false;
    }
}