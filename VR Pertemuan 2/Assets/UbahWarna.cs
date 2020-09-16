using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna : MonoBehaviour
{
    public void Hijau(){
        GetComponent<Renderer>().material.color = Color.green;
    }
    public void Biru(){
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Putih(){
        GetComponent<Renderer>().material.color = Color.white;
    }
}
