using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public ParticleSystem MuzzleFlash;

    public Camera fpsCam;

    private void Start()
    {
       // InvokeRepeating("stopMuzzleFlash", 0.21f, 0.21f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) shoot();
    }


    public void shoot()
    {
        MuzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null) target.Die();
        }
    }

    private void stopMuzzleFlash()
    {
        MuzzleFlash.Stop();
    }
}
