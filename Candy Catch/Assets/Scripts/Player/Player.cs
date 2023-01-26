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
    Animator animator;
    


    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        
        _moveSpeed = PlayerSAO.speedMovement;
        _hp = PlayerSAO.hp;
        currentHp = _hp;
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = PlayerSAO.animatorController;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.ins.gamePause == true) return;
        Movement();
    }

    private void Movement()
    {
        if (_moveLeft == true)
        {
            transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(new Vector3(0, -180, 0));
            animator.SetBool("Run", true);

        }
        else if (_moveRight == true)
        {
            transform.position += Vector3.right * _moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
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
