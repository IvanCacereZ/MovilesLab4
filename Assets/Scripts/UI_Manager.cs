using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameManager gameManager;
    public Text PuntosText;
    private float _Puntos;
    private void Update()
    {
        _Puntos = gameManager.GetPoints();
        PuntosText.text = "Distancia Recorrida: " + _Puntos;
    }
}
