using UnityEngine;
using HPAdmin;
public class BossBullet : MonoBehaviour
{
    [SerializeField]
    float DestroyTime = 0;
    float speed = 0.5f;
    Rigidbody2D rd = default;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        Destroy(gameObject, DestroyTime);
    }

    void Update()
    {
        Vector3 directiion = transform.right * (transform.rotation.z <= 90 ? speed : -speed);
        rd.AddForce(directiion, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HPManager.ChangHP(collision.gameObject.GetComponent<move>(), 1);
            Destroy(gameObject);
        }
    }
}