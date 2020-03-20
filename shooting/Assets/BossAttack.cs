using System.Collections;
using System;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [SerializeField]
    int density = 0;
    [SerializeField]
    GameObject bullet = null;
    [SerializeField]
    GameObject Target = null;
    [SerializeField]
    float AttackDirection = 0;
    float time = 0;
    void Start()
    {

    }

    void Update()
    {
        if (Vector3.Distance(Target.transform.position, gameObject.transform.position) <= AttackDirection)//距離が一定以下なら
        {
            time += Time.deltaTime;//秒数追加
            if (time > 3)//N秒以上なら
            {
                Attack();//ボスのアタック関数実行
                time = 0;
            }
        }
        else
        {
            time = 0;
        }
    }

    void Attack()
    {
        if (density < 1)
        {
            return;//0よりしたはエラー起こるので弾く
        }
        if (180 % density != 0)
        {
            return;//180の約数でなければreturn
        }
        for (int rad = 0; rad <= 180; rad += density)
        {
            GameObject b = Instantiate(bullet, transform.position, new Quaternion(0, 0, 0, 0));
            b.transform.Rotate(0, 0, rad);//角度の設定
        }
    }
}