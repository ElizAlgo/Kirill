using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireballAttack : MonoBehaviour
{
    //Префаб огненного шара и параметр Transform точки атаки
    public GameObject fireballPrefab;
    public Transform attackPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Если игрок кликает левой кнопкой мыши, то создаётся огненный шар
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
