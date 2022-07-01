using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d_2
{
    public class Vitural_Override : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Enemy boss = new Boss(); // kieu du lieu cua Enemy nhung gia tri that su la thuoc ve Boss, khi goi cac thanh phan thi van goi den enemy
            // de goi den thanh phan cua boss thi su dung ghi de (override)
            boss.Move();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Enemy
    {
        public float hp;
        public float damage;
        public float moveSpeed;

        public Enemy()
        {
            Debug.Log("Constructor cua Enemy");
        }

        public virtual void Move()
        {
            // Debug.Log("Move cua Enemy");
        }
    }

    public class Boss : Enemy
    {
        public Boss()
        {
            // Debug.Log("Constructor cua Boss");
        }

        public override void Move()
        {
            // base.Move();
            Debug.Log("Move cua Boss");
        }
    }
}
