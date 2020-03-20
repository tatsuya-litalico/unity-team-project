using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    public GameObject gameovercanvas;

    private int health;


    // Start is called before the first frame update
    void Start()
    {
        gameovercanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
