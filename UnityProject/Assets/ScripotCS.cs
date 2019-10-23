using UnityEngine;

public class ScripotCS : MonoBehaviour
{
    private Animator m_Animator;

    private bool m_mogo;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        m_mogo = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            m_Animator.SetTrigger("吃飯觸發器");
        }

        if ((Input.GetKey(KeyCode.R)))

        {
            m_Animator.SetBool("跑步開關", true);
        }
        else
        {
            m_Animator.SetBool("跑步開關", false);
        }

    }

}
