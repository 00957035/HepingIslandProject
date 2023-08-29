using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRole : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject[] Roles;
    public Avatar[] avatars;
    //private bool flag = true;
    private int currentRoleNumber = 0;
    private characterManager manager;
    void Start()
    {
        currentRoleNumber = manager.GetCurrentOption();
        Debug.Log(currentRoleNumber+"!!");
        animator.avatar = avatars[currentRoleNumber];
        Roles[currentRoleNumber].SetActive(true);
        Debug.Log("set role already");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.P))//大小寫都可
        {
            Roles[currentRoleNumber].SetActive(false);

            if (flag)
            {
                animator.avatar = avatars[1];
                Roles[1].SetActive(true);
                currentRoleNumber = 1;
                flag = false;
                Debug.Log("its remy");
            }
            else
            {
                animator.avatar = avatars[0];
                Roles[0].SetActive(true);
                currentRoleNumber = 0;
                flag = true;

                Debug.Log("its megan");
            }
        }*/
            
    }

    private void SetRole()
    {
        animator.avatar = avatars[currentRoleNumber];
        Roles[currentRoleNumber].SetActive(true);
        Debug.Log("set role already");
    }
    
}
