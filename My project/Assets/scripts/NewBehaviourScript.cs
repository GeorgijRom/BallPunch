using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float impulseForce = 5f; 
    public KeyCode impulseKey = KeyCode.Space; 

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            PhysicMaterial material = new PhysicMaterial();

            material.frictionCombine = PhysicMaterialCombine.Minimum;
            material.bounceCombine = PhysicMaterialCombine.Maximum;

            GetComponent<Collider>().material = material;
        }
    }
       
    void Update()
    {
        if (Input.GetKeyDown(impulseKey))
        {

            ApplyImpulse();
        }
    }

    void ApplyImpulse()
    {

        Vector3 direction = new Vector3(0, 1, 1).normalized;

        rb.AddForce(direction * impulseForce, ForceMode.Impulse);

    }
}

