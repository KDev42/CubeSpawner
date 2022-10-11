using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject cubePrefab;

    private List<GameObject> cubes = new List<GameObject>();
    //private Coroutine spawn;
    private float timeSpawn = -100;

    private void Start()
    {

    }

    private void Update()
    {
        if(Time.time - timeSpawn>= Options.SpawnInterval)
        {
            timeSpawn = Time.time;
            GameObject activatedObject;

            if (HasFreeCube(out activatedObject))
            {
                activatedObject.transform.position = transform.position;
                activatedObject.GetComponent<Cube>().Initialization(Options.Speed, Options.Distance);
                activatedObject.SetActive(true);
            }
            else
            {
                activatedObject = Instantiate(cubePrefab, transform.position, transform.rotation, transform);
                activatedObject.GetComponent<Cube>().Initialization(Options.Speed, Options.Distance);
                cubes.Add(activatedObject);
            }
        }
    }

    //private void ChangeInterval()
    //{
    //    if(spawn!=null)
    //    StopCoroutine(spawn);
    //    spawn = StartCoroutine(Spawn());
    //}

    //IEnumerator Spawn()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(Options.SpawnInterval);
    //        GameObject activatedObject;

    //        if (HasFreeCube(out activatedObject))
    //        {
    //            activatedObject.GetComponent<Cube>().Initialization(Options.Speed, Options.Distance);
    //            activatedObject.transform.position = transform.position;
    //            activatedObject.SetActive(true);
    //        }
    //        else
    //        {
    //            activatedObject = Instantiate(cubePrefab, transform.position, transform.rotation, transform);
    //            activatedObject.GetComponent<Cube>().Initialization(Options.Speed, Options.Distance);
    //            cubes.Add(activatedObject);
    //        }
    //    }
    //}

    private bool HasFreeCube(out GameObject activatedObject)
    {
        foreach(GameObject go in cubes)
        {
            if(!go.activeInHierarchy)
            {
                activatedObject = go;
                return true;
            }
        }

        activatedObject = null;
        return false;
    }
}
