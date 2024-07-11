using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boil_It : MonoBehaviour
{
    public int elixir = 0;


    public AudioClip upscaleSound;
    public AudioClip colorizedSound;
    public AudioClip downscaleSound;
    public AudioClip elixirMixSound;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // AudioSource'ın doğru bir şekilde atanıp atanmadığını kontrol edin
        if (audioSource == null)
        {
            Debug.LogError("Bu GameObject'te AudioSource bileşeni eksik.");
        }

        // Tüm AudioClip'lerin atanıp atanmadığını kontrol edin
        if (upscaleSound == null || colorizedSound == null || downscaleSound == null || elixirMixSound == null)
        {
            Debug.LogError("Bir veya daha fazla AudioClip, Inspector'da atanmadı.");
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "UPSCALE")
        {
            Destroy(other.gameObject);
            Debug.Log("AAAAA");
            elixir += 1;
            MixIt();
        }
        else if (other.gameObject.tag == "COLORIZED")
        {
            Destroy(other.gameObject);
            Debug.Log("AAAAA");
            elixir += 2;
            MixIt();
        }
        else if (other.gameObject.tag == "DOWNSCALE")
        {
            Destroy(other.gameObject);
            Debug.Log("AAAAA");
            elixir += 4;
            MixIt();
        }
    }

    public void MixIt()
    {
        PlaySound(elixirMixSound);
        Debug.Log("Elixir: " + elixir);
        if (elixir == 1)
        {
            Debug.Log("Büyüme İksiri");
        }
        else if (elixir == 2)
        {
            Debug.Log("Renk Değiştirme İksiri");
        }
        else if (elixir == 3)
        {
            Debug.Log("Hem büyüme hem renk değiştirme iksiri");
        }
        else if (elixir == 4)
        {
            Debug.Log("Küçülme iksiri");
        }
        else if (elixir == 5)
        {
            Debug.Log("Boy uzatma iksiri");
        }
        else if (elixir == 6)
        {
            Debug.Log("Hem küçülme hem renk değiştirme iksiri");
        }
        else if (elixir == 7)
        {
            Debug.Log("Ölüm iksiri");
        }
    }
    private void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            Debug.Log("Ses çalınıyor: " + clip.name);
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.Log("Ses dosyası boş");
        }
    }
}
