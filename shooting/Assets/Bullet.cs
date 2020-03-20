using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float DestroyTime = 0;
    float speed = 1f;
    Rigidbody2D rd = default;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        Destroy(gameObject, DestroyTime);
    }

    void Update()
    {
        Vector3 directiion = transform.right * (transform.rotation.z <= 90 ? speed : -speed);
        Debug.Log(directiion);
        rd.AddForce(directiion, ForceMode2D.Impulse);
    }
}
