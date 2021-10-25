using System.Collections;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

[CreateAssetMenu]
public class TargetSO : ScriptableObject
    {
        
        public TextMeshProUGUI scoreText;
        
        private Rigidbody rb;
        public int pointValue;
        public float timeOnScreen = 1.0f;
        private int score;
        
        

        IEnumerator RemoveObjectRoutine()
        {
            yield return new WaitForSeconds(timeOnScreen);
            Transform.Translate(Vector3.forward * 5, Space.World);
            }

        public void UpdateScore(int scoreToAdd)
        {
            score += scoreToAdd;
            scoreText.text = "score";
        }

        private void OnMouseDown()
        {
            Destroy(TargetSO);
            UpdateScore(pointValue);
        }
    }
