using UnityEngine;

public class ScripotCS : MonoBehaviour
{
    Animator m_Animator;
    public Animator chicken;
    bool 跑步開關;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            chicken.SetTrigger("吃飯觸發器");
        }

        chicken.SetBool("跑步開關", Input.GetKey(KeyCode.R));
    }
}
