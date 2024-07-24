using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public CanvasGroup canvasGroup;
    public float fadeDuration = 1.0f;
    public float timeBeforeEnd = 5.0f; 
    void Update()
    {
        if (videoPlayer.frameCount > 0) 
        {
            double timeRemaining = videoPlayer.length - videoPlayer.time;
            if (timeRemaining <= timeBeforeEnd && !fadeInStarted)
            {
                StartCoroutine(FadeInButtons());
                fadeInStarted = true; 
            }
        }
    }

    private bool fadeInStarted = false;

    IEnumerator FadeInButtons()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            yield return null;
        }
    }
}
