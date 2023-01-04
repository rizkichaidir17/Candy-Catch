using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Candy")
        {
            Player.currentHp -= 1;
            other.gameObject.SetActive(false);
        }
    }
}
