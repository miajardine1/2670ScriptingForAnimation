using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class BadTarget : MonoBehaviour
{
    private Rigidbody rb;
    private GameManager gameManager;
    public int pointValue;

    public float timeOnScreen = 1.0f;

    private float minValueX = -3.75f;
    private float minValueY = -3.75f;
    private float spaceBetweenSquares = 2.5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        transform.position = RandomSpawnPosition();
        StartCoroutine(RemoveObjectRoutine());
    }

    IEnumerator RemoveObjectRoutine()
    {
        yield return new WaitForSeconds(timeOnScreen);
        if (gameManager.isGameActive)
        {
            transform.Translate(Vector3.forward*5,Space.World);
        }
    }


    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            gameManager.GameOver();

        }
    }
    

    Vector3 RandomSpawnPosition()
    {
        float spawnPosX = minValueX + (RandomSquareIndex() * spaceBetweenSquares);
        float spawnPosY = minValueY + (RandomSquareIndex() * spaceBetweenSquares);

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
        return spawnPosition;
    }

    int RandomSquareIndex()
    {
        return Random.Range(0, 4);
    }
}


