using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPrototype : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bullets;
        bullets = GameObject.Instantiate(bullet);
        bullets.transform.position = enemy.transform.position;
        bullets.transform.position -= transform.right * 2;
    }
}
