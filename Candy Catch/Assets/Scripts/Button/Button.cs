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

public enum Karater
{
    Boy,
    girl,
}
public class Button : MonoBehaviour
{
    public ButtonEnum buttonState;
    public Karater _char;
    public void ButtonClick()
    {
        switch (buttonState)
        {
            case ButtonEnum.PlayAgain:
                LoadScene("GamePlay");
                break;
            case ButtonEnum.Exit:
                LoadScene("MainMenu");
                break;
            case ButtonEnum.Pause:
                gamePause(true);
                break;
            case ButtonEnum.Unpause:
                gamePause(false);
                break;
        }
    }

    private static void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    private static void gamePause(bool setActive)
    {
        GameManager.ins.gamePause = setActive;
        UIManager.ins.gamePausePanel.SetActive(setActive);
    }
}
