using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float forceMult = 10.0f;
    public float health = 10f;
    //public Material hurtMat;

    void start()
    {
        //hurtMat = getComponent<Material>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(h, 0.0f, v) * forceMult;
        GetComponent<Rigidbody>().AddForce(force);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakenDamage();
            //Destroy(gameObject);
        }
    }
    void TakenDamage()
    {
        health - 5f;
        
    }
}
