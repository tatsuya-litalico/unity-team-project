using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public float bullet_speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;

        GameObject bullets;

        if (Input.GetMouseButtonDown(0))
        {
            bullets = Instantiate(bullet);
            bullets.transform.position = player.transform.position;
            if (mousePos.x > player.transform.position.x)
            {
                while(true)
                {
                    bullets.transform.position += transform.right * bullet_speed * Time.deltaTime;
                }
            }
            else
            {
                while (true)
                {
                    bullets.transform.position -= transform.right * bullet_speed * Time.deltaTime;
                }
            }
        }
        
        
    }
}
