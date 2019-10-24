﻿using UnityEngine;

public class ScripotCS : MonoBehaviour
{
    private Animator m_Animator;

  

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))      
            m_Animator.SetTrigger("吃飯觸發器");
            m_Animator.SetBool("跑步開關", Input.GetKey(KeyCode.R));
       

    }

}
