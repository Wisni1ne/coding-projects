/*
    ----------------------------------------------------------------------------------------------
    FILE NAME: FadeIn.cs
    AUTHOR: Nathan Wisniewski
    LAST REVISION DATE: April 20, 2021
    
    DESCRIPTION: Play a fade-in animation once the scene is loaded.
    ----------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{

    public Animator FadeInAni;

    /*
     *  FUNCTION NAME: Start
     *  RETURNS: IEnumerator (Wait for time)
     *  
     *  DESCRIPTION: When starting, play the fade in animation.
     */

    IEnumerator Start()
    {
        FadeInAni.SetTrigger("Start");
        yield return new WaitForSeconds(1.0f);      // Length of animation.
        FadeInAni.SetTrigger("End");
    }
}
