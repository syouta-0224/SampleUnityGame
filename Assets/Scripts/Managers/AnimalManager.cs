using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Models;

namespace Scripts.Managers
{
    public class AnimalManager : MonoBehaviour
    {
        public AnimalModel CreateMAnimal(int animalId, string animalName)
        {
            var animal = new AnimalModel()
            {
                Id = animalId,
                Name = animalName
            };

            Debug.Log($"{animal.Id}:{animal.Name}");

            return animal;
        }
    }
}

