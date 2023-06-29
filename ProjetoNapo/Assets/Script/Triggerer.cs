using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerer : MonoBehaviour
{
    private Coroutine scalerCoroutine;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ativar evento sonoro");
            if(scalerCoroutine != null) StopCoroutine(Scaler());
            scalerCoroutine = StartCoroutine(Scaler());
        }
    }

    private IEnumerator Scaler()
    {
        gameObject.transform.localScale = new Vector2(8,8);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.localScale = new Vector2(5,5);
    }
}
