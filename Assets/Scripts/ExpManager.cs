using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    [SerializeField] private GameObject pinkButterfly;
    [SerializeField] private Man manScript;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ButterflyDistractor());
        StartCoroutine(ManDistractor());
    }


    IEnumerator ButterflyDistractor()
    {
        yield return new WaitForSeconds(10f);
        pinkButterfly.SetActive(true);
    }

    IEnumerator ManDistractor()
    {
        yield return new WaitForSeconds(10f);
    }

}
