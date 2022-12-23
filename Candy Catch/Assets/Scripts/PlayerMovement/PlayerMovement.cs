using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void LeftButtonDown()
    {
        Player._moveLeft = true;
    }
    public void LeftButtonUp()
    {
        Player._moveLeft = false;
    }
    public void RightButtonDown()
    {
        Player._moveRight = true;
    }
    public void RightButtonUp()
    {
        Player._moveRight = false;
    }
}
