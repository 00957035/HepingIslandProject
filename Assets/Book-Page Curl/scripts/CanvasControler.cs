using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControler : MonoBehaviour
{
    // Start is called before the first frame update

    Canvas book_canvas;
    public Camera cam;
    RaycastHit hitObj;
    void Start()
    {
        book_canvas = GameObject.Find("BookCanvas").GetComponent<Canvas>();
        book_canvas.enabled = false;
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

                if (hitObj.collider.gameObject.tag == "Picture")
                {
                    ShowExitCanvas();
                }
            }
        }
    }
    public void ShowExitCanvas()
    {
        book_canvas.enabled = true;
    }
    public void HideExitCanvas()
    {
        book_canvas.enabled = false;
    }
}
