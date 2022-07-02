using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d_3
{
    public class Abstract1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Boss boss = new Boss();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    // cac method abstract phai dc khai bao ben trong class abstract
    // va khong co noi dung ben trong method
    public abstract class Enemy
    {
        protected float hp;
        public float damage;
        public float moveSpeed;

        public Enemy()
        {
            Debug.Log("abstract");
        }
        public abstract void Move();
        public abstract void Die();
    }


    public interface IEnemy // dat ten interface co chu I dang trc cho de phan biet
    {

        public void GetHit(int damage); // trong interface k khai bao bien, chi khai bao phuong thuc
    }

    public interface IOther : IEnemy // mot interface co the ke thua tu interface khac
    {

    }

    // khi tao mot class ke thua tu lop abstract thi cac phuong thuc phai ghi de het
    public class Boss : Enemy, IEnemy, IOther // mot class co the ke thua nhieu interface
    {
        public Boss()
        {
            Debug.Log("Boss");
        }
        public override void Move()
        {

        }

        public override void Die()
        {

        }

        // khi ke thua interface phai ghi de lai method cua interface va day du tham so
        public void GetHit(int damage)
        {

        }
    }
}
