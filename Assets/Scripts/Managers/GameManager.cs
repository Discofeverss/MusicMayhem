using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //tasta singleton

    public GameObject[] miniBosses;

    // Awakeen haku 

    private void Start()
    {
        miniBosses = GameObject.FindGameObjectsWithTag("MiniBoss");
    }

}
