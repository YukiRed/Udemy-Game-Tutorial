using UnityEngine;

public class RandomSound : MonoBehaviour
{
    private AudioSource source;
    public AudioClip[] sounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
        int randSound = Random.Range(0, sounds.Length);
        source.clip = sounds[randSound];
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
