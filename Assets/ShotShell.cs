using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShell : MonoBehaviour
{
    public float shotspeed;

    [SerializeField]
    private GameObject shellprefab;

    [SerializeField]
    private AudioClip shotsound;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shell = Instantiate(shellprefab, transform.position, Quaternion.identity);

            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            shellRb.AddForce(transform.forward * shotspeed);

            Destroy(shell, 2.0f);

            AudioSource.PlayClipAtPoint(shotsound, transform.position);
        }


    }
}
