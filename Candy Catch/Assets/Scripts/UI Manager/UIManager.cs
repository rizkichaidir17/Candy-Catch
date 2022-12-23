using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text _hpText;
    [SerializeField] TMP_Text _pointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _hpText.text = "Life Point : " + Player.currentHp;
        _pointText.text = "Point : " + GameManager.ins.pointGame;
    }
}
