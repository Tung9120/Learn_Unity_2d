using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT1_buoi8 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Cat cat = new Cat("Tom", "1", "ground", "meat");
            Debug.Log(cat.Move());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Animal
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

        public Animal(string typeName, string gender, string habitat, string food)
        {
            this.typeName = typeName;
            this.gender = gender;
            this.habitat = habitat;
            this.food = food;
        }

        public virtual float[] Move(float x = 0, float y = 0)
        {
            float[] location = new float[2] { 0, 0 };
            location[0] = x;
            location[1] = y;
            Debug.Log($"{this.typeName} is moving. \n Location of {this.typeName} is ({x}, {y})");
            return location;
        }

        public virtual string Eat(string food = "something")
        {
            Debug.Log($"{this.typeName} is eating {food}");
            return food;
        }

        public virtual string Eat()
        {
            Debug.Log($"{this.typeName} is eating{this.food}");
            return this.food;
        }

        public virtual void Talk(string content = "something")
        {
            Debug.Log($"{this.typeName} is talking {content}");
        }
    }

    public class Cat : Animal
    {
        protected static int legs = 4;
        protected static bool eatMeat = true;
        protected static string sound = "meo meo";

        public Cat(string typeName, string gender, string habitat, string food) : base(typeName, gender, habitat, food)
        {
            // this.typeName = typeName;
            // this.gender = gender;
            // this.habitat = habitat;
            // this.food = food;
        }

        public override float[] Move(float x = 0, float y = 0)
        {
            // base.Move();
            float[] location = new float[2] { 0, 0 };
            location[0] = x;
            location[1] = y;
            Debug.Log($"{this.typeName} is moving by {Cat.legs} legs. \n Location of {this.typeName} is ({x}, {y})");
            return location;
        }

        public override string Eat(string food = "something")
        {
            food = (Cat.eatMeat) ? "Meat" : "something";
            Debug.Log($"{this.typeName} is eating {food}");
            return food;
        }

        public override string Eat()
        {
            Debug.Log($"{this.typeName} is eating{this.food}");
            return this.food;
        }

        public override void Talk(string content = "something")
        {
            Debug.Log($"{this.typeName} is talking {content}");
            Debug.Log($"{this.typeName} is saying {Cat.sound}");
        }
    }

    public class Bird : Animal
    {
        public static int wings = 2;
        protected new string food = "bugs";
        public static int legs = 2;

        public Bird(string typeName, string gender, string habitat, string food) : base(typeName, gender, habitat, food)
        {

        }

        public float[] Move(float x = 0, float y = 0, float z = 0)
        {
            float[] location = new float[3] { 0, 0, 0 };
            location[0] = x;
            location[1] = y;
            Debug.Log($"{this.typeName} is flying by {Bird.wings} wings. \n Location of {this.typeName} is ({x}, {y}, {z})");
            return location;
        }

        public override string Eat()
        {
            Debug.Log($"{this.typeName} is eating{this.food}");
            return this.food;
        }

        public override string Eat(string food = "something")
        {
            Debug.Log($"{this.typeName} is eating {food}");
            return food;
        }

        public override void Talk(string content = "something")
        {
            Debug.Log($"{this.typeName} is singing {content}");
        }
    }

    public class Fish : Animal
    {
        public static string[] fishFoodList = { "seaweed", "little creature" };
        public Fish(string typeName, string gender, string habitat, string food) : base(typeName, gender, habitat, food)
        {

        }

        public new void Eat()
        {
            foreach (var food in Fish.fishFoodList)
            {
                Debug.Log($"{this.TypeName} is eating {food}");
            }
        }

        public new string[] Eat(string food = "something")
        {
            foreach (var item in Fish.fishFoodList)
            {
                Debug.Log($"{this.TypeName} is eating {food}");
            }

            return Fish.fishFoodList;
        }

        public void SplashWater()
        {
            Debug.Log($"{this.typeName} is splashing water");
        }
    }
}
