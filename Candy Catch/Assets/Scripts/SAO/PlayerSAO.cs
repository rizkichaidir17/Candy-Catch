using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Player", menuName ="SAO/Player")]
public class PlayerSAO : ScriptableObject
{
    public float speedMovement;
    public int hp;
    public RuntimeAnimatorController animatorController;

}
