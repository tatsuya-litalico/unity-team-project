using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public GameObject player;
    public Slider HPBar = null;
    public Vector2 velocity;
    public float HP;
    public float MaxHP;
    public float jump_power = 1000f;
    private Rigidbody2D rb;
    private bool isGrounded = true;
    private float X_Size = 0;
    private float Y_Size = 0;

    [SerializeField]
    private GameObject Limit = null;

    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        HP = MaxHP;
        X_Size = transform.localScale.x;
        Y_Size = transform.localScale.y;
        Limit.SetActive(false);
    }

    private void OnCollisonEnter(Collision collision)
    {
        Destroy(player);
        //isGrounded = true;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.tag == "Wall")
        {
            Limit.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Wall")
        {
            Limit.SetActive(false);
        }
    }

    void Update()
    {
        // 走り
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += transform.right * velocity.y * Time.deltaTime;
            if(transform.localScale.x != X_Size)
            {
                transform.localScale = new Vector3(X_Size, Y_Size, 1);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= transform.right * velocity.y * Time.deltaTime;
            if (transform.localScale.x != -X_Size)
            {
                transform.localScale = new Vector3(-X_Size, Y_Size, 1);
            }
        }

        //ジャンプ
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * jump_power);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector3 MyPos = transform.position;
            Vector3 ClickPos = Input.mousePosition;
            Debug.Log(ClickPos);
        }
        HPBar.value = HP / MaxHP;
    }

    public void Die()
    {
        Debug.Log("GameOver");
    }
}