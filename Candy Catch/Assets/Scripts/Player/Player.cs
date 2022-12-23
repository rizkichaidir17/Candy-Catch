using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSAO PlayerSAO;

    public static bool _moveLeft = false;
    public static bool _moveRight = false;

    float _moveSpeed;
    int _hp;
    public static int currentHp;

    // Start is called before the first frame update
    void Start()
    {
        _moveSpeed = PlayerSAO.speedMovement;
        _hp = PlayerSAO.hp;
        currentHp = _hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.ins.gamePause == true) return;
        if (_moveLeft == true)
        {
            transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
        }
        else if(_moveRight == true)
        {
            transform.position += Vector3.right * _moveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Candy")
        {
            GameManager.ins.pointGame += other.gameObject.GetComponent<Candy>().point;
            other.gameObject.SetActive(false);
        }
    }
}
