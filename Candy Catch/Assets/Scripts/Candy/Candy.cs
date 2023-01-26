using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public CandySAO candySAO;

    [HideInInspector]
    public int point;
    float movementSpeed;
    SpriteRenderer candySprite;

    // Start is called before the first frame update
    void Start()
    {
        point = candySAO.point;
        candySprite = gameObject.GetComponent<SpriteRenderer>();
        movementSpeed = candySAO.movementSpeed;
        candySprite.sprite = candySAO.candySprite;
        transform.localScale = candySAO.size;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.ins.gamePause == true) return;
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;
    }
}
