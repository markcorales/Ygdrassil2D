//ENEMY SPAWNER
//using System;
//using Random = UnityEngine.Random;
//using System.Collections;
//using System.Collections.Generic;
//using Unity.Mathematics;
//using UnityEngine;
//using UnityEngine.Events;
//using TMPro;

//public class EnemySpawner : MonoBehaviour
//{
    //[Header("References")]
    //[SerializeField] public GameObject[] enemyPrefabs;

    //[Header("Attributes")]
    ///[SerializeField] public int baseEnemies = 8;
//     [SerializeField] public float enemiesPerSecond = 0.5f;
//     [SerializeField] public float timeBetweenWaves = 5f;
//     [SerializeField] public float difficultyScalingFactor = 0.75f;

//     //[Header("Events")]
//     //public static UnityEvent onEnemyDestroy = new UnityEvent();

//     public int currentWave = 0;
//     public float timeSinceLastSpawn;
//     public int enemiesAlive;
//     public int enemiesLeftToSpawn;
//     public bool isSpawning = false;
//     public TextMeshProUGUI roundUI;
//     public LevelManager levelManager;

//    // private void Awake(){
//         //onEnemyDestroy.AddListener(EnemyDestroyed);
//     //}

//     //private void Start(){
        
//         //StartCoroutine(StartWave());
//     }
//     private void Update()
//     {
//         if (LevelManager.main.lives <= 0) return;
        
//         if (!isSpawning) return;

//         timeSinceLastSpawn += Time.deltaTime;

//         if (timeSinceLastSpawn >= (1f/ enemiesPerSecond) && enemiesLeftToSpawn > 0 )
//         {
//             SpawnEnemy();
//             enemiesLeftToSpawn --;
//             enemiesAlive ++;
//             timeSinceLastSpawn = 0f;
//         }

//         roundUI.text =  "Wave:" + currentWave;

//         //if (enemiesAlive == 0 && enemiesLeftToSpawn == 0)
//         //{
//             //LevelManager.main.EndGame();
//             //return;
//         //}

//         //if (currentWave == enemyPrefabs.Length)
//         //{
//             //LevelManager.main.WinLevel();
//             //return;
//         //}
//     }

//     private void EnemyDestroyed() {
//         enemiesAlive --;
//     }
//     private IEnumerator StartWave()
//     {
//         yield return new WaitForSeconds(timeBetweenWaves);

//         isSpawning = true;
//         enemiesLeftToSpawn = EnemiesPerWave();
//     }

//     private void EndWave() {
//         isSpawning = false;
//         timeSinceLastSpawn = 0f;
//         currentWave ++;
//         StartCoroutine(StartWave());
//     }
//     private void SpawnEnemy(){

//         int index = Random.Range(0, enemyPrefabs.Length);
//         GameObject prefabsToSpawn = enemyPrefabs[index];
//         Instantiate (prefabsToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
//     }
//     private int EnemiesPerWave() {
//         return Mathf.RoundToInt(baseEnemies * Mathf.Pow(currentWave, difficultyScalingFactor));
//     //}
    
// //}


/// BUILD MANAGER OLD
/// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BuildManager : MonoBehaviour {
//     public static BuildManager main;

//     [Header("References")]
//     [SerializeField] private Tower[] towers;


//     private int selectedTower = 0;
   
    
//     private void Awake() {
//         main = this;
//     }
    
//     public Tower GetSelectedTower() {
//         return towers[selectedTower];
//     }

//     public void SetSelectedTower (int _selectedTower)
//     {
//         selectedTower = _selectedTower;
//     }
// }

//plot old
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Plot : MonoBehaviour {

//     [Header("References")]
//     [SerializeField] private SpriteRenderer sr;
//     [SerializeField] Color hoverColor;
//     private GameObject tower;
//     private Color startColor;

//     private void Start() {
//         startColor = sr.color;
//     }

//     private void OnMouseEnter() {
//         sr.color = hoverColor;
//     }

//     private void OnMouseExit() {
//         sr.color = startColor;
//     }

//    private void OnMouseDown() {
//         if (tower != null) return;

//         Tower towerToBuild = BuildManager.main.GetSelectedTower();

//         if (towerToBuild.cost > PlayerStats.Money)
//         {
//             Debug.Log("Insufficient Funds");
//             return;
//         }

//         LevelManager.main.SpendCurrency(towerToBuild.cost);

//         tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        
//     }

// }

//enemymovement
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//[RequireComponent(typeof(Enemy))]
// public class EnemyMovement : MonoBehaviour
// {
//     [Header("References")]
//     [SerializeField] private Rigidbody2D rb;

//     [Header("Attributes")]
//     [SerializeField] private float moveSpeed = 2f;

//     private Transform target;
//     private int pathIndex = 0;
//     LevelManager levelManager;

    

//     private void Start()
//     {
//         //enemy = GetComponent<Enemy>();
//         target = LevelManager.main.path[0];
//     }

    
//     private void Update()
//     {
//         if (Vector2.Distance(target.position, transform.position) <= 0.1f){
//             pathIndex++;

//             if (pathIndex >= LevelManager.main.path.Length) {
//                 EndPath();
//                 return;
//             } else
//             {
//                 target = LevelManager.main.path[pathIndex];
//             }
            
//         }
        
//     }
//     private void FixedUpdate() {
//         Vector2 direction = (target.position - transform.position).normalized;

//         rb.velocity = direction * moveSpeed;
//     }

//     public void EndPath()
//     {
//         PlayerStats.Lives--;
//         Destroy(gameObject);
//     }
// }






