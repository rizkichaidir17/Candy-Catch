using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum ButtonEnum
{
    GameOn,
    PlayAgain,
    Exit,
    Pause,
    Unpause,
}
public class Button : MonoBehaviour
{
    public ButtonEnum buttonState;
    public void ButtonClick()
    {
        switch (buttonState)
        {
            case ButtonEnum.PlayAgain:
                SceneManager.LoadScene("GamePlay");
                break;
            case ButtonEnum.Exit:
                SceneManager.LoadScene("MainMenu");
                break;
            case ButtonEnum.Pause:
                GameManager.ins.gamePause = true;
                break;
            case ButtonEnum.Unpause:
                GameManager.ins.gamePause = false;
                break;
        }
    }
}
