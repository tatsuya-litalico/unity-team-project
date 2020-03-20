using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dir : MonoBehaviour
{
    public static float GetAngle(Vector2 from, Vector2 to)
    {
        var dx = to.x - from.x;
        var dy = to.y - from.y;
        var rad = Mathf.Atan2(dy, dx);
        return rad * Mathf.Rad2Deg;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var screenpos = Camera.main.WorldToScreenPoint(transform.position);
        var direction = Input.mousePosition - screenpos;
        var angle = player_dir.GetAngle(Vector3.zero, direction);

        var angles = transform.localEulerAngles;
        angles.z = angle - 90;
        transform.localEulerAngles = angles;
    }
}
