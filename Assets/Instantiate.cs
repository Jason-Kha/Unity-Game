using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject spawnObject;
    public GameObject player;
    float spawnDelay = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay += Time.deltaTime;

        //Press 'p' to spawn a whatever is hooked to spawnObject
        if (Input.GetKey("p") && spawnDelay > 3f)
        {
            Instantiate(spawnObject, spawnPoint);

            spawnDelay = 0f;
        }

        //Press 'o' to reset 'player' to the spawn location and set their velocity to 0
        if (Input.GetKey("o"))
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

            player.transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
        }
    }
}
