using UnityEngine;

namespace HPAdmin
{
    public class HPManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// Targetは変化の対象
        /// Amountは変化させる割合
        /// </summary>
        /// <param name="Target"></param>
        /// <param name="Amount"></param>
        public static void ChangHP(move Target, float Amount)
        {
            Target.HP -= Amount;
            if (Target.HP <= 0)
            {
                Target.Die();
            }
        }
    }
}