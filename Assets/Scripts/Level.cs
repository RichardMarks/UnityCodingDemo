using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public static Level Instance { get; private set; }

    public AudioSource soundAudioSource;
    public AudioSource musicAudioSource;

    private void Awake()
    {
        Instance = this;
    }

    public void PlaySFX(AudioClip audioClip)
    {
        soundAudioSource.pitch = Random.Range(0.9f, 1.1f);
        soundAudioSource.PlayOneShot(audioClip);
    }

    public void Restart()
    {
        StartCoroutine(RestartScene());
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
