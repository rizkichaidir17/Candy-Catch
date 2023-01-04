using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    [SerializeField] Candy candy1;
    [SerializeField] Candy candy2;
    [SerializeField] Candy candy3;
    [SerializeField] Candy candy4;
    [SerializeField] Candy candy5;
    Candy candy;

    [SerializeField]List<Candy> candies = new List<Candy>();

    [SerializeField] float cooldown;
    [SerializeField]float currentCD;

    [SerializeField] Vector2 randomX; 
    // Start is called before the first frame update
    void Start()
    {
        ObjectPooling.Init(candy1, 5, candies, transform);
        ObjectPooling.Init(candy2, 5, candies, transform);
        ObjectPooling.Init(candy3, 5, candies, transform);
        ObjectPooling.Init(candy4, 5, candies, transform);
        ObjectPooling.Init(candy5, 5, candies, transform);
        currentCD = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.currentHp == 0) return;
        Cooldown();
    }

    public void Cooldown()
    {
        if(currentCD >= 0)
        {
            currentCD -= Time.deltaTime;
        }
        else
        {
            currentCD = cooldown;
            Vector3 vector = new Vector3(Random.Range(randomX.x, randomX.y), 5.27f, 0);
            ObjectPooling.Activated(candy, false, candies, transform, vector);
        }
    }
}
