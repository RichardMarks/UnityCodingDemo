using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
    public AudioClip audioClip;

    public void Play()
    {
        Level.Instance.PlaySFX(audioClip);
    }
}
