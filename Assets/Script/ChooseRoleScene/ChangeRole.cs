using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRole : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public Avatar[] avatar;
    public GameObject[] role;
    bool flag = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //role index + 1
            role[0].SetActive(!flag);
            role[1].SetActive(flag);
            if (flag)//megan
                animator.avatar = avatar[1];
            else
                animator.avatar = avatar[0];
            flag = !flag;
        }
    }
}
