using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField]
    private Transform Target = null;
    [SerializeField]
    private Vector3 Offset = Vector3.zero;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Target.transform.position + Offset;
    }
}
