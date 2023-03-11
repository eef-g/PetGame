using Godot;
using System;
using Pet_Enums;

namespace Pet_Core
{
    public class PetObj
    {
        public PetType type;
        FoodType fav_food;
        int max_hunger;
        string name;

        public PetObj()
        {
            type = PetType.Dog;
            fav_food = FoodType.Bone;
            max_hunger = 100;
            name = "Fido";
        }

        public PetObj(PetType pt, FoodType fav, int hunger, string name)
        {
            this.type = pt;
            this.fav_food = fav;
            this.max_hunger = hunger;
            this.name = name;
        }

        public void PrintPet()
        {
            
        }
        
    }
}
