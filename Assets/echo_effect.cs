using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echo_effect : MonoBehaviour
{

    public float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public GameObject echo;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.moveInput != 0) {
            if(timeBtwSpawns <= 0) {
                //spawns echo game object
                GameObject instance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(instance, 8f);
                timeBtwSpawns = startTimeBtwSpawns;
            } else {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
