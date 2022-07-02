using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT_Them : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Moto moto = new Moto("string", 1, "id", 1);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class BaseItem
    {
        protected string id;
        protected int unlocked;

        public BaseItem()
        {
            Debug.Log("");
        }

        public BaseItem(string id)
        {
            this.id = id;
        }

        public BaseItem(int unlocked)
        {
            this.unlocked = unlocked;
        }

        public BaseItem(string id, int unlocked)
        {
            this.id = id;
            this.unlocked = unlocked;
        }
    }

    public class Moto : BaseItem
    {
        protected string amount;
        protected int stat;

        public Moto(string amount, int stat, string id, int unlocked) : base(id, unlocked)
        {
            this.amount = amount;
            this.stat = stat;
        }

        public Moto(int stat, string id, int unlocked) : base(id, unlocked)
        {
            this.stat = stat;
        }

        public Moto(string amount, string id, int unlocked) : base(id, unlocked)
        {
            this.amount = amount;
        }
    }
}
