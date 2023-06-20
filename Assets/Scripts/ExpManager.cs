using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    [SerializeField] private GameObject butterfly;
    [SerializeField] private GameObject manCloseS;
    [SerializeField] private GameObject manClose;
    [SerializeField] private GameObject manFarS;
    [SerializeField] private GameObject manFar;
    [SerializeField] private GameObject birdCloseS;
    [SerializeField] private GameObject birdClose;
    [SerializeField] private GameObject birdFarS;
    [SerializeField] private GameObject birdFar;
    [SerializeField] private GameObject treeCloseS;
    [SerializeField] private GameObject treeClose;
    [SerializeField] private GameObject treeFarS;
    [SerializeField] private GameObject treeFar;
    List<GameObject> DistList;

    void Start()
{
    DistList = new List<GameObject>();
    DistList.Add(manCloseS);
    DistList.Add(treeCloseS);
    DistList.Add(birdCloseS);
    DistList.Add(manClose);
    DistList.Add(treeFarS);
    DistList.Add(birdClose);
    DistList.Add(manFar);
    DistList.Add(treeClose);
    DistList.Add(birdFarS);
    DistList.Add(manFarS);
    DistList.Add(birdFar);
    DistList.Add(treeFar);

	StartCoroutine(ActivateExp());
	StartCoroutine(ActivateDistractor());
	
	
}
    // Start is called before the first frame update
    void Update()
    {


    }


IEnumerator ActivateExp()
{
	yield return new WaitForSeconds(15f);
	butterfly.SetActive(true);
}

    IEnumerator ActivateDistractor()
    {
	foreach (GameObject obj in DistList)
	{
        yield return new WaitForSeconds(15f);
        obj.SetActive(true);
}
    }





}
