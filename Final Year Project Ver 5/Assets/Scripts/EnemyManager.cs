using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance;
    public bool enemyRespawn = false;
    GameObject enemyPrefab;
    [SerializeField] Transform enemyParent;
    [SerializeField] Sprite[] enemySprites;
    [SerializeField] Vector3 enemySpawnPosition;
    [SerializeField] Vector3 enemySpawnScale;

    private void Awake()
    {
        EnemyManager.Instance = this;
        enemyPrefab = (GameObject)Resources.Load("Enemy");
    }

    public void RespawnEnemy(float delay = 2f)
    {
        Invoke(nameof(SpawnEnemy), delay);
    }

    void SpawnEnemy()
    {
        enemyRespawn = true;
        GameObject enemyClone = Instantiate(enemyPrefab, enemyParent);
        enemyClone.transform.localPosition = enemySpawnPosition;
        enemyClone.transform.localScale = enemySpawnScale;
        // Change the sprite to a random from our enemySprites list
        enemyClone.GetComponent<Image>().sprite = enemySprites[Random.Range(0, enemySprites.Length)];
    }
}
