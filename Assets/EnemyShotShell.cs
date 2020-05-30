using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour
{
    public float shotspeed;

    [SerializeField]
    private GameObject enemyshellprefab;

    [SerializeField]
    private AudioClip shotSound;
    private int interval;


    // Update is called once per frame
    void Update()
    {
        interval += 1;

        if (interval % 60 == 0)
        {
            GameObject enemyshell = Instantiate(enemyshellprefab, transform.position, Quaternion.identity);

            Rigidbody enemyshellRb = enemyshell.GetComponent<Rigidbody>();

            enemyshellRb.AddForce(transform.forward * shotspeed);

            AudioSource.PlayClipAtPoint(shotSound, transform.position);

            Destroy(enemyshell, 2.0f);


        }
        
    }
}
