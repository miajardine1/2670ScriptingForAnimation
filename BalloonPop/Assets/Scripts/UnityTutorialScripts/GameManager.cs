using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
   private float time;
   private float spawnRate = 3f;
   public bool isGameActive;

   private float spaceBetweenSquares = 2.5f;
   private float minValueX = -3.75f;
   private float minValueY = -3.75f;

   private Button button;

    public void Begin()
       {
          button = GetComponent<Button>();
          StartGame(1);
       } 

   public void StartGame(int difficulty)
   {
      spawnRate = difficulty;
      isGameActive = true;
      StartCoroutine(SpawnTarget());
      score = 0;
      UpdateScore(0);
      titleScreen.SetActive(false);
      Debug.Log("game start");
   }
   public void GameOver()
   {
      gameOverText.gameObject.SetActive(true);
      restartButton.gameObject.SetActive(true);
      isGameActive = false;
   }
   
   public void RestartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void UpdateScore(int scoreToAdd)
   {
      score += scoreToAdd;
      scoreText.text = "Score: " + score;
   }

   IEnumerator SpawnTarget()
   {
      while (isGameActive)
      {
         
            
            int index = Random.Range(0, targetPrefabs.Count);
            spawnRate = Mathf.MoveTowards(spawnRate, .2f, .01f);
            Debug.Log(spawnRate);


            if (isGameActive)
            {
               Instantiate(targetPrefabs[index], RandomSpawnPosition(), targetPrefabs[index].transform.rotation);
               yield return new WaitForSeconds(spawnRate);
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
}
