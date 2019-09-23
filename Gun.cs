using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject laserProjectile;
    public Transform laserSpawn;
    //Private
    private CameraShake shake;
    // Start is called before the first frame update
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset); 

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shake.CamShake();
            Instantiate(laserProjectile, laserSpawn.position, laserSpawn.rotation);
        }
    }
}
