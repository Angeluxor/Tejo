using UnityEngine;

public class Explosion : MonoBehaviour

{
    public GameObject explosion;  
    public void Explode()
    {
        explosion.GetComponent<ParticleSystem>().Play();
    }

   

}
