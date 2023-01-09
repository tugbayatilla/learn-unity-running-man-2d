using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    private Vector3 position = new Vector3(25, 0, 0);

    public float delayTime = 2;
    public float repeatRate = 2;
    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating(nameof(SpawnObstacle), delayTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        // if (playerControllerScript.gameOver == true)
        // {
        //     CancelInvoke(nameof(SpawnObstacle));
        // }
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs, position, obstaclePrefabs.transform.rotation);
        }
    }
}
