using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Scripts.Controllers;
using Scripts.Models;


namespace Scripts.Views 
{
    public class AnimalViews : MonoBehaviour
    {
        [SerializeField] 
        private GameObject animalModel = null;
        [SerializeField]
        private GameObject animalController = null;
        public void Awake()
        {
            var animal = animalModel.GetComponent<AnimalModel>();
            var controller = animalController.GetComponent<AnimalController>();

            controller.GetAnimal(animal.Id, animal.Name);
        }
    }
}