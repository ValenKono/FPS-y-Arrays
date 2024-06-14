using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Agregar una variable que almacene el valor maximo de puntos
//Cuando se llegue al valor maximo debe dejar de sumarse puntos
//Y mostrar en txtScore el mensaje "Ganaste"
public class InterArea : MonoBehaviour
{
    public Text txtScore;
    public int score;
    public int maxScore;


    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;
        if (score < maxScore)
        {
            txtScore.text = score.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            txtScore.text = "¡Ganaste!";
        }
    }
        
    }
