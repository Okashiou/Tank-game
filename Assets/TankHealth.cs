using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{
    [SerializeField]
    private GameObject effectprefab1;
    [SerializeField]
    private GameObject effectprefab2;
    public int tankHP;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EnemyShell")
        {
            tankHP -= 1;

            Destroy(other.gameObject);

            if (tankHP > 0)
            {
                GameObject effect1 = Instantiate(effectprefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);

            }
            else
            {
                GameObject effect2 = Instantiate(effectprefab2, transform.position, Quaternion.identity);
                Destroy(effectprefab2, 1.0f);

                Destroy(gameObject);
            }
        }
    }

}
