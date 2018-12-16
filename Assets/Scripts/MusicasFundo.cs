using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicasFundo : MonoBehaviour {

    
    public AudioSource audioNoite;
    public AudioSource audioDia;
  public Light luzsol;
    public bool permite = true;
    public static bool pause = false;


    private void Start()
    {

        audioNoite.mute = true;
        audioDia.mute = false;


    }

    private void OnGUI()
    {
        const int buttonWidth = 84;
        const int buttonWHeight = 60;
       



        if (GUI.Button(new Rect(Screen.width  - (buttonWidth), (2 * Screen.height / 3) - (buttonWidth / 2), buttonWidth, buttonWHeight), "Pause"))
        {
            pause = !pause;
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;

        
        }


        if (GUI.Button(new Rect(Screen.width - (buttonWidth), (2 * Screen.height / 2) - (buttonWidth), buttonWidth, buttonWHeight), "MUTE"))
        {
            if (audioDia.mute == false )
            {
                audioDia.mute = true;
                permite = false;
            }
            else
            {
                audioDia.mute = false;
                permite = true;
            }

        }
    }


    void Update () {

        if(permite)

        {
            if (luzsol.intensity == 0)
            {
                audioDia.mute = true;
                audioNoite.mute = false;


            }
            else
            {
                audioDia.mute = false;
                audioNoite.mute = true;
            }


        }



    }
		
	}

