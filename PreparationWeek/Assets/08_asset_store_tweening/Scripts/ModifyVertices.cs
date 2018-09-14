using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyVertices : MonoBehaviour {

    Mesh mesh;
    public float intensity = 0.1f;

    void Start () {
        mesh = GetComponentInChildren<MeshFilter>().mesh;
	}

    void Update()
    {
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;
        int i = 0;

        while (i < vertices.Length)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time) * intensity;
            i++;
        }
        mesh.vertices = vertices;
    }

}
