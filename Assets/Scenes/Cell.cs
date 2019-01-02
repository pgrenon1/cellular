using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public DNA Dna;
    public float Speed = 0.1f;

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.mass = Dna.Mass;
    }

    // Update is called once per frame
    void Update()
    {

        //Move();
    }

    private void Move()
    {
        var x = Random.Range(-Speed, Speed);
        var y = Random.Range(-Speed, Speed);
        var z = Random.Range(-Speed, Speed);

        _rb.AddForce(x, y, z, ForceMode.Impulse);
    }
}
