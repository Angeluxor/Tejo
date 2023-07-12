using System;
using TMPro;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    public float force;
    public GameObject spawn;
    public float maxVel;
    


    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().AddForce(transform.right * force, ForceMode.Impulse);
            GetComponent<Aiming>().enabled = false;
            

        }
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Aiming>().enabled = true;
            transform.localPosition = spawn.transform.position;
            transform.localEulerAngles = spawn.transform.eulerAngles;      

        }

     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Tablero"))
        {
          GetComponent<Rigidbody>().isKinematic = true;
        }
        


    }

    private void OnCollisionExit(Collision collision)
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mecha"))
        {
            other.GetComponentInParent<AudioSource>().Play();
            other.enabled = false;
            other.GetComponentInParent<MeshRenderer>().enabled = false;
            other.GetComponentInParent<Explosion>().Explode();
            ScoreSingleton.Instance.scoreModify(3);           
        }                 

        if (other.CompareTag("Bocin"))
        {
            ScoreSingleton.Instance.scoreModify(6);
        }       

    }

}
