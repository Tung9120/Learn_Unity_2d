using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT3_buoi8 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Animal1
    {
        protected string typeName;
        protected string gender;
        protected string habitat;
        protected string food;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public string Food
        {
            get { return food; }
            set { food = value; }
        }

        public Animal1(string typeName, string gender, string habitat, string food)
        {
            this.typeName = typeName;
            this.gender = gender;
            this.habitat = habitat;
            this.food = food;
        }
    }

    interface IAnimal
    {
        public float[] Move(float x, float y);

        public string Eat(string food = "something");

        public void Eat();

        public void Talk(string content = "something");
    }

    public class Cat2 : Animal1, IAnimal
    {
        protected static int legs = 4;
        protected static bool eatMeat = true;
        protected static string sound = "meo meo";

        public Cat2(string typeName, string gender, string habitat, string food) : base(typeName, gender, habitat, food)
        {
            // this.typeName = typeName;
            // this.gender = gender;
            // this.habitat = habitat;
            // this.food = food;
        }

        public float[] Move(float x = 0, float y = 0)
        {
            // base.Move();
            float[] location = new float[2] { 0, 0 };
            location[0] = x;
            location[1] = y;
            Debug.Log($"{this.typeName} is moving by {Cat2.legs} legs. \n Location of {this.typeName} is ({x}, {y})");
            return location;
        }

        public string Eat(string food = "something")
        {
            food = (Cat2.eatMeat) ? "Meat" : "something";
            Debug.Log($"{this.typeName} is eating {food}");
            return food;
        }

        public void Eat()
        {
            Debug.Log($"{this.typeName} is eating");
        }

        public void Talk(string content = "something")
        {
            Debug.Log($"{this.typeName} is talking {content}");
            Debug.Log($"{this.typeName} is saying {Cat2.sound}");
        }
    }

    public class Bird2 : Animal1, IAnimal
    {
        public static int wings = 2;
        protected new string food = "bugs";
        public static int legs = 2;

        public Bird2(string typeName, string gender, string habitat, string food) : base(typeName, gender, habitat, food)
        {

        }

        public float[] Move(float x = 0, float y = 0)
        {
            float[] location = new float[2] { 0, 0 };
            location[0] = x;
            location[1] = y;
            Debug.Log($"{this.typeName} is flying by {Bird2.wings} wings. \n Location of {this.typeName} is ({x}, {y})");
            return location;
        }

        public string Eat(string food = "something")
        {
            Debug.Log($"{this.typeName} is eating {food}");
            return food;
        }

        public void Eat()
        {
            Debug.Log($"{this.typeName} is eating");
        }

        public void Talk(string content = "something")
        {
            Debug.Log($"{this.typeName} is singing {content}");
        }
    }

    public class Fish2 : Animal1, IAnimal
    {
        public static string[] fishFoodList = { "seaweed", "little creature" };
        public Fish2(string typeName, string gender, string habitat, string food) : base(typeName, gender, habitat, food)
        {

        }

        public float[] Move(float x, float y)
        {
            float[] location = new float[2] { 0, 0 };
            location[0] = x;
            location[1] = y;
            Debug.Log($"{this.typeName} is moving. \n Location of {this.typeName} is ({x}, {y})");
            return location;
        }

        public string Eat(string food = "something")
        {
            foreach (var item in Fish2.fishFoodList)
            {
                Debug.Log($"{this.TypeName} is eating {item}");
            }

            return food;
        }

        public void Eat()
        {
            Debug.Log($"{this.typeName} is eating");
        }

        public void Talk(string content = "something")
        {
            Debug.Log($"{this.typeName} is talking {content}");
        }

        public void SplashWater()
        {
            Debug.Log($"{this.typeName} is splashing water");
        }
    }
}
