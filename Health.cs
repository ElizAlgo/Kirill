using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{ //Текущее здоровье игрока

    public int health = 10;
    public int maxHealth = 10;

    //Компонент, отвечающий за проигрывание звуков
    public AudioSource audioSource;
    //Звуковой файл, содержащий звуковой эффект нанесения урона
    public AudioClip damageSound;
    
    public void TakeDamage(int damage)
    {
        health -= damage;

        //Если здоровье ещё есть, то проигрывается звук нанесения урона
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
 void Update()
    {
        
    }
}
