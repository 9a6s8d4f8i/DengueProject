using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {



    public AudioSource Audio;

    private void OnGUI()
    {
        const int buttonWidth = 84;
        const int buttonWHeight = 60;
        



        if (GUI.Button(new Rect(Screen.width/2-(buttonWidth/2), (2*Screen.height/3) - (buttonWidth/2), buttonWidth, buttonWHeight), "Start!"))
        {
            SceneManager.LoadScene("ScenaJogo");
       
        }


        if (GUI.Button(new Rect(Screen.width  - (buttonWidth ), (2 * Screen.height / 2) - (buttonWidth ), buttonWidth, buttonWHeight), "MUTE"))
        {
         if(Audio.mute == false)
            {
                Audio.mute = true;
            }
         else
            {
                Audio.mute = false;
            }
                
        }
    }
}
