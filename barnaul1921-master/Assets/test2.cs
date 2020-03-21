using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    
        public GameObject it;


        void OnTriggerEnter(Collider other)
        {
            other.gameObject.transform.position = it.transform.position;
        }

        void OnCollisionEnter(Collision c)
        {
            if (c.gameObject.name == "Capsule")
            {

            }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    
}
