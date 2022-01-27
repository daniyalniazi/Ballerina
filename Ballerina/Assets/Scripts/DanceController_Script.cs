using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceController_Script : MonoBehaviour
{
    public Animator DanceController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Animation_1_Player()
    {
        DanceController.Play("Anim_1");
    }
    public void Animation_2_Player()
    {
        DanceController.Play("Anim_2");
    }
}
