using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb_collect : MonoBehaviour
{
    public Player player;
    public AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FirstPersonController").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonController")
        {
            player.orbs += 1;
            player.playerSounds.PlayOneShot(collectSound);
            Destroy(gameObject);
        }
    }
}
