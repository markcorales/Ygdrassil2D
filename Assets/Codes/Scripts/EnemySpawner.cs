using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public static int EnemiesAlive = 0;
    public Wave [] waves;
    //public Transform spawnPoint;

    public float timeBetweenWaves = 5f; 
    private float countdown = 2f ;
    public TextMeshProUGUI waveCountdownText;
    private int waveIndex = 0;
    

    private void Update() 
    {
        
        if (EnemiesAlive > 0)
        {
            return;
        }
            
            
        if (waveIndex == waves.Length)
        {
            LevelManager.main.WinLevel();
           this.enabled = false;

        }

        if (countdown <= 0){
            StartCoroutine (SpawnWave());
            countdown = timeBetweenWaves;
            return;
        } 

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}" , countdown);
        
    }
    
    IEnumerator SpawnWave (){
        
        PlayerStats.rounds++;

        Wave wave = waves [waveIndex];

        //EnemiesAlive = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.prefabsToSpawn);
            yield return new WaitForSeconds(1 / wave.rate);
        }

        waveIndex ++;

        
    }

    void SpawnEnemy(GameObject prefabsToSpawn)
    {
        Instantiate (prefabsToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
        EnemiesAlive ++;
    }
    
}
