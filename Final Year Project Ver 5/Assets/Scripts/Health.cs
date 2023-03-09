using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static Health Instance;
    public bool enemyDead = false;
    private UnityEngine.Object enemyRef;
    public int maxHealth = 3;
    public int currentHealth;
    public Typer typer;
    public Healthbar healthBar;
    SpriteRenderer spriteRenderer;
    //public GameOverScreen gameOverScreen;

    // Start is called before the first frame update
    public void Start()
    {
        enemyRef = Resources.Load("Enemy");
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        typer = GameObject.FindGameObjectWithTag("Typer").GetComponent<Typer>();
    }
    private void Awake()
    {
        Health.Instance = this;
    }


    // Update is called once per frame
    public void Update()
    {
        if (typer.damageTaken == true)
        {
            Debug.Log("typer"); // Debug statement to check if typer is assigned properly
            TakeDamage(1);
            typer.damageTaken = false;
        }
        EnemyDespawn();
    }   

    public void TakeDamage(int amount)
    {

        currentHealth = Mathf.Clamp(currentHealth - amount, 0, maxHealth);
        healthBar.SetHealth(currentHealth);
        Debug.Log(currentHealth);

    }

    public void EnemyDespawn()
    {
        if (currentHealth == 0)
        {
            Debug.Log("test");
            enemyDead = true;
            // Call the EnemyManager's RespawnEnemy with 2 second delay
            EnemyManager.Instance.RespawnEnemy(0.5f);

            // We can now instantly destroy this because the EnemyManager handles spawning
            Destroy(gameObject);
            //gameOverScreen.Setup();
            //Debug.Log(gameOverScreen);
        }
    }

}
