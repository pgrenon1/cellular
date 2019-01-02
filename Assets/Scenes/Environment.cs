using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public float xSize;
    public float ySize;
    public float zSize;

    private GameObject[] _bounds = new GameObject[6];

    // Start is called before the first frame update
    void Start()
    {
        CreateBounds();
        for (int i = 0; i < _bounds.Length; i++)
        {
            _bounds[i].transform.SetParent(transform);
            _bounds[i].name = "Bound " + i; 
        }
    }

    private void CreateBounds()
    {
        GameObject z1 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        z1.transform.position += new Vector3(0, 0, zSize / 2);
        z1.transform.localScale = new Vector3(xSize, ySize, 1);
        _bounds[0] = z1;
        GameObject z2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        z2.transform.Rotate(0, 180, 0);
        z2.transform.position += new Vector3(0, 0, -zSize / 2);
        z2.transform.localScale = new Vector3(xSize, ySize, 1);
        _bounds[1] = z2;
        GameObject x1 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        x1.transform.Rotate(0, 90, 0);
        x1.transform.position += new Vector3(xSize / 2, 0, 0);
        x1.transform.localScale = new Vector3(zSize, ySize, 1);
        _bounds[2] = x1;
        GameObject x2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        x2.transform.Rotate(0, -90, 0);
        x2.transform.position += new Vector3(-xSize / 2, 0, 0);
        x2.transform.localScale = new Vector3(zSize, ySize, 1);
        _bounds[3] = x2;
        GameObject y1 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        y1.transform.Rotate(-90, 0, 0);
        y1.transform.position += new Vector3(0, ySize / 2, 0);
        y1.transform.localScale = new Vector3(xSize, zSize, 1);
        _bounds[4] = y1;
        GameObject y2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        y2.transform.Rotate(90, 0, 0);
        y2.transform.position += new Vector3(0, -ySize / 2, 0);
        y2.transform.localScale = new Vector3(xSize, zSize, 1);
        _bounds[5] = y2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
