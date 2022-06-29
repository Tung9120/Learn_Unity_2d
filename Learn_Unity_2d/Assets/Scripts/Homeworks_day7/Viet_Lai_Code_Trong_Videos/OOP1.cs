using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class OOP1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Tao mot doi tuong moi tu class
            // Enemy enemy = new Enemy();

            // truy xuat den cac thuoc tinh va phuong thuc cua doi tuong
            // enemy.moveSpeed = 1f;
            // enemy.Move();

            // Enemy enemy = new Enemy(1f, 2f, 3f);
            // Enemy enemy = new(1f);
            Enemy enemy1 = new(1);
            // enemy1.Bonus = 5; // su dung set de gan gia tri cho thuoc tinh private
            // Debug.Log(enemy1.Bonus); // su dung get de truy cap vao thuoc tinh private
            // Enemy.lifeTime = 5.4f; // gan gia tri cho thuoc tinh static thong qua class
            // Debug.Log(Enemy.lifeTime);
            // Enemy.CaculateLifeTime(); // goi phuong thuc tinh thong qua class

            // Helper.distance = 1f;
            // Debug.Log(Helper.distance);
            // Helper.GetDistance();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    // tao mot class moi
    public class Enemy
    {
        // cac thuoc tinh cua class
        // cac thanh phan co tu khoa public co the truy cap tu cac doi
        // dc tao ra tu class
        // cac thanh phan co tu khoa private chi co the truy cap dc ben
        // trong class do
        // cac thanh phan co tu khoa protected co the truy cap ben trong
        // class do va cac class dc ke thua tu class do
        public float moveSpeed;
        public float detectDist;
        public float damage;
        public string name;
        private int bonus;
        protected float skillRate;
        public static float lifeTime; // bien tinh duoc goi va gan gia tri thong qua class

        // de truy cap vao cac thuoc tinh private hoac protected 
        // phai tao mot bien ao co 2 phuong thuc set va get
        public int Bonus
        {
            get { return bonus; } // tra ve gia tri cua thuc tinh 
            set // gan gia tri cho thuoc tinh
            {
                if (value > 5)
                    bonus = value;
            }

            // cach viet ngan gon cua set va get
            // get => bonus;
            // set => bonus = value;
        }

        // phuong thuc tinh
        public static void CaculateLifeTime()
        {

        }

        protected void SkillCountdown()
        {

        }

        private void Die()
        {

        }

        // cac phuong thuc cua class
        public void Move()
        {

        }

        // phuong thuc khoi tao cua class khong co tham so
        public Enemy()
        {
            Debug.Log("day la phuong thuc khoi tao k co tham so");
        }

        // phuong thuc khoi tao co 1 tham so 
        public Enemy(float moveSpeed)
        {
            this.moveSpeed = moveSpeed;
            Debug.Log("phuong thuc khoi tao moveSpeed");
        }

        // phuong thuc khoi tao co 1 tham so nhung khac kieu du lieu
        public Enemy(string name)
        {
            this.name = name;
            Debug.Log("phuong thuc khoi tao name");
        }

        // phuong thuc khoi tao cua class co tham so
        public Enemy(float moveSpeed, float detectDist, float damage)
        {
            this.moveSpeed = moveSpeed;
            this.detectDist = detectDist;
            this.damage = damage;
            Debug.Log("day la phuong thuc khoi tao co tham so");
        }

        // phuong thuc khoi tao tinh khong dc co tham so
        static Enemy()
        {   
            // lifeTime = 5;
            // phuong thuc tinh chi goi dc thuoc tinh va phuong thuc tinh
            // con cac phuong thuc binh thuong co the goi den cac thanh phan tinh
        }

        // trong class co nhieu phuong thuc khoi tao nhung chi 
        // mot phuong thuc khoi tao dc goi. Cac phuong thuc
        // khoi tao phan biet voi nhau qua cac tham so truyen
        // vao hoac qua kieu du lieu cac tham so

        // phuc thuc huy doi tuong
        ~Enemy()
        {
            Debug.Log("phuong thuc huy doi tuong");
        }
    }

    // lop tinh cac thanh phan ben trong phai la static
    public class Boss : Enemy
    {
        public void Testing()
        {
            // skillRate = 6;
            // SkillCountdown();
        }
    }

    public static class Helper
    {
        public static float distance;
        public static float GetDistance()
        {
            return distance;
        }
    }
}
