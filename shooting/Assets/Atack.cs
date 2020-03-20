using System;
using UnityEngine;

public class Atack : MonoBehaviour
{
    [SerializeField]
    int density = 0;
    [SerializeField]
    GameObject bullet = null;
    [SerializeField]
    GameObject Target = null;
    [SerializeField]
    float AttackDirection = 0;
    //[SerializeField]
    //GameObject a = null;
    float time = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(Target.transform.position, gameObject.transform.position) <= AttackDirection)//距離が一定以下なら
        {
            time += Time.deltaTime;//秒数追加
            if(time > 3)//N秒以上なら
            {
                int pat = UnityEngine.Random.Range(0, 3);
                BossAtack(pat);//ボスのアタック関数実行
                time = 0;
            }
        }else{
            time = 0;
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    var screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //    var direction = Input.mousePosition - screenPos;
        //    var angle = GetAim(Vector3.zero, direction);
        //    a.transform.SetLocalEulerAnglesZ(-angle + 45);
        //}
    }

    void BossAtack(int pat)
    {
        if(density < 1)
        {
            return;//0よりしたはエラー起こるので弾く
        }
        if(360 % density != 0)
        {
            return;//180の約数でなければreturn
        }

        switch (pat)
        {
            case 0:
                for (int rad = 0; rad <= 360; rad += density)
                {
                    Vector3 vec = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    vec.x -= 0.75f;
                    vec.y += 1.7f;

                    GameObject b = Instantiate(bullet, vec, new Quaternion(0, 0, 0, 0));
                    b.transform.Rotate(0, 0, rad);//角度の設定
                }
                break;
            case 1:
                for (int rad = 0; rad <= 360; rad += density)
                {
                    Vector3 vec = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    vec.x -= 0.75f;
                    vec.y += 1.7f;

                    GameObject b = Instantiate(bullet, vec, new Quaternion(0, 0, 0, 0));
                    b.transform.Rotate(0, 0, rad);//角度の設定
                }
                break;
            case 2:
                for(int i = 0; i < 3; i++)
                {
                    for (int Count = 0; Count <= 180; Count += density)
                    {
                        Vector3 vec = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                        vec.x += i * 10;
                        vec.y += Count / 5 - i * 2;
                        GameObject b = Instantiate(bullet, vec, new Quaternion(0, 0, 0, 0));
                        b.transform.Rotate(0, 0, 180);//角度の設定
                    }
                }
                break;
            default:
                Debug.LogError("パターンの値がおかしいです。");
                break;

        }
    }

    public float GetAim(Vector2 from, Vector2 to)
    {
        float dx = to.x - from.x;
        float dy = to.y - from.y;
        float rad = Mathf.Atan2(dy, dx);
        return rad * Mathf.Rad2Deg;
    }
}
