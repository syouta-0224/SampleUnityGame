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
        private Vector3 vector3 = Vector3.right;
        public void Awake()
        {
            var animal = animalModel.GetComponent<AnimalModel>();
            var controller = animalController.GetComponent<AnimalController>();

            controller.GetAnimal(animal.Id, animal.Name);
        }

        private void Update()
        {
            this.transform.position += (vector3 * Time.deltaTime);
        }
    }
}