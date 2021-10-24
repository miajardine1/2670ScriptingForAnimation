using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
   public TextMeshProUGUI scoreText;
   public TextMeshProUGUI gameOverText;
   public GameObject titleScreen;
   public Button restartButton;

   public List<GameObject> targetPrefabs;

   private int score;
   private float spawnRate = 1.5f;
   public bool isGameActive;

   private float spaceBetweenSquares = 2.5f;
   private float minValueX = -3.75f;
   private float minValueY = -3.75f;

   public void StartGame()
   {
      spawnRate /= 5;
      isGameActive = true;
      StartCoroutine(SpawnTarget());
      score = 0;
      UpdateScore(0);
      titleScreen.SetActive(false);
   }

   public void UpdateScore(int scoreToAdd)
   {
      score += scoreToAdd;
      scoreText.text = "score";
   }

   IEnumerator SpawnTarget()
   {
      while (isGameActive)
      {
         yield return new WaitForSeconds(spawnRate);
         int index = Random.Range(0, targetPrefabs.Count);

         if (isGameActive)
         {
            Instantiate(targetPrefabs[index], RandomSpawnPosition(), targetPrefabs[index].transform.rotation);
         }
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

   public void GameOver()
   {
      gameOverText.gameObject.SetActive(true);
      restartButton.gameObject.SetActive(false);
      isGameActive = false;
   }

   public void RestartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
