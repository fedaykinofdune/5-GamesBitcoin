using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public GUISkin MainMenu;
    public GUISkin Green;
    public GUIStyle Group;

    void OnGUI()
    {

        var buttonSystemWidth = 40;
        var buttonSystemHeight = 40;
        var buttonSystemLeftPosition = 40f;
        var buttonSystemTopPosition = 0f;

        var buttonNormalWidth = Screen.width;
        var buttonNormalHeight = 60f;
        var buttonNormalLeftPosition = 0f;

        var buttonPlayWidth = Screen.width;
        var buttonPlayHeight = 40f;
        var buttonPlayLeftPosition = 0f;

        GUI.skin = MainMenu;

      //  Rect Rect;
        Vector2 scrollPosition = Vector2.zero;
        //GUI.Label(new Rect(0, 0, Screen.width, Screen.height / 10), "");


        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Rock Paper Scissors");

        #region topMenu
            
        if (GUI.Button(new Rect(Screen.width - (buttonSystemLeftPosition *2), buttonSystemTopPosition, buttonSystemWidth, buttonSystemHeight), "Settings"))
        {
            Application.LoadLevel(1);
        }


        if (GUI.Button(new Rect(Screen.width - (buttonSystemLeftPosition*3+10), buttonSystemTopPosition, buttonSystemWidth, buttonSystemHeight), "Statistics"))
        {
            Application.LoadLevel(3);
        }

        #endregion

        #region content
        scrollPosition = GUI.BeginScrollView(new Rect(0, 40, Screen.width,Screen.height-80), scrollPosition, new Rect(0, 0, Screen.width,Screen.height));


        float buttonPos = 0f;
        GUI.Label(new Rect(0, buttonPos, Screen.width, 20), "You turn");
        buttonPos += 20f;
      

        for (int i = 0; i < 5; i++)
        {
            if (GUI.Button(new Rect(0, buttonPos, buttonNormalWidth, buttonNormalHeight), "Playing with Frank de Boer \nGame started at 23.03"))
            {
                Application.LoadLevel(2);
            }

            buttonPos += buttonNormalHeight;
        }


        GUI.Label(new Rect(0, buttonPos, Screen.width, 20), "Opponent's turn");

        buttonPos += 20f;

        for (int i = 0; i < 5; i++)
        {
            if (GUI.Button(new Rect(0, buttonPos, buttonNormalWidth, buttonNormalHeight), "Playing with Frank de Boer \nGame started at 23.03\nYou played 'Rock'"))
            {
                Application.LoadLevel(2);
            }

            buttonPos += buttonNormalHeight;
        }


        GUI.Label(new Rect(0, buttonPos, Screen.width, 20), "Ended games");

        buttonPos += 20f;

        for (int i = 0; i < 5; i++)
        {
            if (GUI.Button(new Rect(0, buttonPos, buttonNormalWidth, buttonNormalHeight), "Playing with Frank de Boer \nGame started at 23.03\nYou played 'Rock'"))
            {
                Application.LoadLevel(2);
            }

            buttonPos += buttonNormalHeight;
        }

        GUI.EndScrollView();
        #endregion

        GUI.skin = Green;

        if (GUI.Button(new Rect(buttonPlayLeftPosition, Screen.height - buttonPlayHeight, buttonPlayWidth, buttonPlayHeight), "Play new game!"))
        {
            Application.LoadLevel(4);
        }
    }
}