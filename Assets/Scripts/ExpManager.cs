using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    [SerializeField] private GameObject pinkButterfly;
    [SerializeField] private GameObject man;
    [SerializeField] private GameObject birdNear;
    [SerializeField] private GameObject treeNear;
    [SerializeField] private GameObject treeFar;
    [SerializeField] private GameObject birdBlue;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ButterflyDistractor()); // 10
        StartCoroutine(NearBirdDistractor()); // 20
        StartCoroutine(NearTreeDistractor()); // 30
        StartCoroutine(ManDistractor()); // 40
        StartCoroutine(FarTreeDistractor()); // 50
        StartCoroutine(BlueBirdDistractor()); // 60
    }


    IEnumerator ButterflyDistractor()
    {
        yield return new WaitForSeconds(10f);
        pinkButterfly.SetActive(true);
    }

    IEnumerator NearBirdDistractor()
    {
        yield return new WaitForSeconds(20f);
        pinkButterfly.SetActive(false);
        treeNear.SetActive(true);
    }
    
    IEnumerator NearTreeDistractor()
    {
        yield return new WaitForSeconds(30f);
        birdNear.SetActive(true);
    }
    
    IEnumerator FarTreeDistractor()
    {
        yield return new WaitForSeconds(40f);
        treeFar.SetActive(true);
    }
    
    IEnumerator ManDistractor()
    {
        yield return new WaitForSeconds(50f);
        man.SetActive(true);
    }
    
    IEnumerator BlueBirdDistractor()
    {
        yield return new WaitForSeconds(60f);
        birdBlue.SetActive(true);
    }



}
