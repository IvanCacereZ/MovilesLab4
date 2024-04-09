using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float puntos = 0;
    public SelectorSO Selector;
    PlayerSO playerSO;
    private float velocityPlayer = 0;
    public GameObject Nave;
    private void Start()
    {
        playerSO = Selector.playerSelected;
        Nave.GetComponent<SpriteRenderer>().sprite = playerSO.playerSprite;
        velocityPlayer = playerSO.playerVelocity;
    }
    private void Update()
    {
        puntos += (velocityPlayer * Time.deltaTime);
    }
    public float GetPoints()
    {
        return puntos;
    }
}
