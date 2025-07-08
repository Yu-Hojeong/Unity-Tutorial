using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    public enum SceneType{TOWN, ADVENTURE}
    public SceneType sceneType = SceneType.TOWN;
    public FadeRoutine fade;
    public GameObject portalEffect;
    public GameObject background;
    public Image progressBar;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PortalRoutine());
        }
    }

    IEnumerator PortalRoutine()
    {
        portalEffect.SetActive(true);
        yield return StartCoroutine(fade.Fade(1f, Color.white, true));

        background.SetActive(true);
        yield return StartCoroutine(fade.Fade(1f, Color.white, false));

        while (progressBar.fillAmount < 1f)
        {
            progressBar.fillAmount += Time.deltaTime * 0.3f;
            yield return null;
        }
        if (sceneType == SceneType.TOWN)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(0);

    }
}
