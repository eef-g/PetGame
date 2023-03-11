using Godot;
using System;
using Pet_Enums;

namespace Pet_Core
{
    public class PetLibrary
    {
        public PetLibrary(){}

        public PetObj CreatePet(string type)
        {
            type = type.ToLower();
            switch(type)
            {
                case "dog":
                    return new PetObj();
                case "cat":
                    return new PetObj(PetType.Cat, FoodType.Carrot, 100, "El Gato");
                case "snake":
                    return new PetObj(PetType.Snake, FoodType.Seed, 200, "Danger Noodle");
                case "plant":
                    return new PetObj(PetType.Plant, FoodType.Onion, 150, "Gloob");
                default:
                    return new PetObj();
            }
        }
    }
}
