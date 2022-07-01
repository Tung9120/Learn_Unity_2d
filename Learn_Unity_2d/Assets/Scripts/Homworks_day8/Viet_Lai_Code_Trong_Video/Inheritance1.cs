using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d_1
{
    public class Inheritance1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Enemy boss = new Boss();
            // Boss boss = new Boss();
            boss.Move();

            // object tao boi class ke thua co tat cac thanh phan cua class cha
            // boss.hp = 1f;
            // boss.damage = 1f;
            // boss.moveSpeed = 1f;
            // phuong thuc khoi tao cua lop cha goi trc, lop con goi sau
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
        public Enemy(float damage)
        {
            Debug.Log("Cha 1 tham so");
        }

        // lop cha co constructor k tham so thi lop con cung phai co
        // constructor k tham so
        public Enemy()
        {
            Debug.Log("cha k tham so");
        }

        public Enemy(float hp, float damage)
        {
            Debug.Log("Cha 2 tham so");
        }

        // neu co lop con co thanh phan trung ten voi cac thanh phan cua lop
        // cha thi nen them tu khoa new o dang truoc, khi tao mot doi tuong 
        // tu lop con thi thuoc tinh, phuong thuc cua lop con dc uu tien goi
        public void Move()
        {
            Debug.Log("Move cua cha");
        }
    }

    // class Boss ke thua class Enemy
    public class Boss : Enemy // muon ke thua class thi dung dau :
    {
        // lop con co constructor co tham so thi chac chan lop cha phai co
        // constructor co tham so
        // lop cha constructor co tham so thi lop con khong nhat thiet phai
        // co constructor co tham so

        public new float damage;
        public Boss(float damage)
        {
            Debug.Log("con 1 tham so");
        }

        public Boss()
        {
            Debug.Log("con k tham so");
        }

        // muon goi constructor nao cua cha thi phai :base(tham so truyen vao)
        // neu khong thi chi goi dc constructor k tham so cua cha
        public Boss(float hpCopy, float damageCopy) : base(hpCopy)
        {
            // trong :base() chi truyen dc vao tham so cua lop con
            Debug.Log("con 2 tham so");
        }

        public new void Move()
        {
            // co the truy cap cac thanh phan cua cha co pham vi public
            // va private bang tu khoa base
            // base.damage;
            // base.Move();
            
            Debug.Log("Move cua con");
        }
    }
}
