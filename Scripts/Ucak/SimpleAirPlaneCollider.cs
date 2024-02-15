using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeneGames.Airplane
{
    public class SimpleAirPlaneCollider : MonoBehaviour
    {
        
        public bool collideSometing;

        [HideInInspector]
        public SimpleAirPlaneController controller;

        private void OnTriggerEnter(Collider other)
        {
            
            // Çarpışan nesnenin tag'ını kontrol ediyoruz
            if (other.CompareTag("Target"))
            {
                // "Target" tag'ine sahip bir nesneyle çarpışıldığında, collideSometing değerini değiştirmiyoruz
                // böylece diğer kodlarda bu durumu işlemek için kullanabilirsiniz
                return;
            }
            if (other.CompareTag("final"))
            {
                return;
            }
            //Collide something bad
            if (other.gameObject.GetComponent<SimpleAirPlaneCollider>() == null && other.gameObject.GetComponent<LandingArea>() == null)
            {
                
                collideSometing = true;
            }
        }
    }
}
