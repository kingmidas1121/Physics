using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public Transform MainGun;
    public Transform gun;
    public GameObject bullet;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);

	if(Input.GetKey(KeyCode.T))
   	{
 		MainGun.RotateAround(MainGun.position, MainGun.right, -2);
	}
	else if(Input.GetKey(KeyCode.G))
	{
		MainGun.RotateAround(MainGun.position, MainGun.right, 2);
	}
	else if(Input.GetKey(KeyCode.B))
	{
		Instantiate(bullet, gun.position, gun.rotation);
	}
    }
}
