using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isTargetShoted", false);
        if (Input.GetKeyDown("1"))
        {
            anim.SetBool("isTargetShoted", true);
        }
    }
}
