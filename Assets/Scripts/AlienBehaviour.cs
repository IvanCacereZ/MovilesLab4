using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class AlienBehaviour : MonoBehaviour
{
    public SelectorSO templatePlayer;
    private float velocidad = 1.0f;
    private StaticAlienObjectPooling objectPool;
    void Update()
    {
        transform.position = new Vector2(transform.position.x - (velocidad * Time.deltaTime), transform.position.y);
        if (transform.position.x <= -10)
        {
            ReturnToPool();
        }
    }
    public void InitVariables()
    {
        velocidad = templatePlayer.playerSelected.GenerationAlienSpeed;
    }
    public void SetObjectPool(StaticAlienObjectPooling pool)
    {
        objectPool = pool;
    }
    private void ReturnToPool()
    {
        gameObject.SetActive(false);
        if (objectPool != null)
        {
            objectPool.SetObject(gameObject);
        }
    }
}
