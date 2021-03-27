using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Managers;
using Scripts.Models;

namespace Scripts.Controllers 
{
    public class AnimalController : MonoBehaviour
    {
        [SerializeField]
        private GameObject animalAdmin = null;

        public AnimalModel GetAnimal(int animalId, string animalName)
        {
            if (animalId == null)
            {
                Debug.LogError("AnimalIdÇ™ê›íËÇ≥ÇÍÇƒÇ¢Ç‹ÇπÇÒ");
                return null;
            }
            var animalManager = animalAdmin.GetComponent<AnimalManager>();
            var animal = animalManager.CreateMAnimal(animalId, animalName);

            return animal;
        }
    }
}
