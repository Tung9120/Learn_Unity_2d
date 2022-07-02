using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT_buoi7 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            PC myPc = new PC();
            myPc.ReceiveData("Hello");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class PC
    {
        protected string _case;
        protected string mainboard;
        protected int ram;
        protected string cpu;
        protected int powerSupplyUnit;
        protected string fan;

        public static string wifiAdress;
        public static float wifiSpeed;
        public static string owner;

        public PC()
        {
            Debug.Log("A computer is created");
        }
        public PC(string _case, string mainboard, int ram, string cpu, int powerSupplyUnit, string fan)
        {
            this._case = _case;
            this.mainboard = mainboard;
            this.ram = ram;
            this.cpu = cpu;
            this.powerSupplyUnit = powerSupplyUnit;
            this.fan = fan;
        }

        public string _Case
        {
            set{_case = value;}
            get{return _case;}
        }

        public string Mainboard
        {
            get {return mainboard;}
            set {mainboard = value;}
        }

        public int Ram
        {
            get {return ram;}
            set {ram = value;}
        }

        public string Cpu
        {
            get {return cpu;}
            set {cpu = value;}
        }

        public int PowerSupplyUnit
        {
            get {return powerSupplyUnit;}
            set {powerSupplyUnit = value;}
        }

        public string Fan
        {
            get {return fan;}
            set {fan = value;}
        }

        public void Start()
        {
            Debug.Log("Pc is starting!");
        }

        public void Close()
        {
            Debug.Log("Pc is closing");
        }

        public void OverClock()
        {
            Debug.Log($"{this.cpu} is overclocking");
        }

        public void ReceiveData(string data)
        {
            Debug.Log($"Pc is receiving data: {data}");
        }

        ~PC()
        {

        }
    }
}
