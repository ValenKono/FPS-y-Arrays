﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Agregar una variable que establezca la cantiad de veces
//Que se instanciara un alimento
//Cuando se instancien esa cantidad de elementos
//No deben instanciarse mas
public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement PosAle;
    public int maxClones;
    public int cloneCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneFood()
    {
        if(cloneCount < maxClones)
        {
            cloneCount++;
            PosAle.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
    }
}
