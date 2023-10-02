using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poster : MonoBehaviour
{
    Canvas InfoCanvas;
    public Camera cam;
    public Sprite[] poster;
    public Image image;
    RaycastHit hitObj;
    void Start()
    {
        InfoCanvas = GameObject.Find("PosterCanvas").GetComponent<Canvas>();
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
                if (hitObj.collider.gameObject.tag == "0")
                    showInfoCanvas(hitObj.collider.gameObject.tag);
            }
        }
    }

    public void showInfoCanvas(string tag)
    {
        Debug.Log("!");
        int index = int.Parse(tag);
        image.sprite = poster[index];
        InfoCanvas.enabled = true;
    }
    public void hideInfoCanvas()
    {
        InfoCanvas.enabled = false;
    }
}