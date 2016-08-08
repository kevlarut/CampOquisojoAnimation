using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip Song;

    void Start()
    {
        AudioSource.PlayClipAtPoint(Song, transform.position);
    }
}
