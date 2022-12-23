using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Candy", menuName = "SAO/Candy")]
public class CandySAO : ScriptableObject
{
    public int point;
    public Sprite candySprite;
    public float movementSpeed;
    public Vector3 size;

}

