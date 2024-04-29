using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator PlayerAnimator;
    
    void Awake()
    {
        PlayerAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
        PlayerAnimator.SetFloat("walk", Input.GetAxis("Vertical"));
        PlayerAnimator.SetFloat("back", Input.GetAxis("Horizontal"));
        


    }

}
