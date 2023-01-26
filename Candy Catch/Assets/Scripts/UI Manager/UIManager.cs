using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager ins;

    [SerializeField] TMP_Text _hpText;
    [SerializeField] TMP_Text _pointText;

    public GameObject _gameOverPanel;
    public GameObject gamePausePanel;

    // Start is called before the first frame update

    private void Awake()
    {
        ins = this;
    }
    void Start()
    {
        _gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _hpText.text = "Life Point : " + Player.currentHp;
        _pointText.text = "Point : " + GameManager.ins.pointGame;
    }
}
