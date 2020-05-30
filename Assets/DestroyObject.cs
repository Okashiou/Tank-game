using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField]
    private GameObject effectprefab;

    [SerializeField]
    private GameObject effectprefab2;

    public int objectHP;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shell"))
        {
            objectHP -= 1;

            if(objectHP>0)
            {
                Destroy(other.gameObject);

                GameObject effect = Instantiate(effectprefab, other.transform.position, Quaternion.identity);

                Destroy(effect, 2.0f);

            }
            else
            {
                Destroy(other.gameObject);

                GameObject effect2 = Instantiate(effectprefab2, other.transform.position, Quaternion.identity);

                Destroy(effect2, 2.0f);

                Destroy(this.gameObject);

            }
           
        }
    }
   
}
