using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject Spawn01;
    public GameObject Spawn02;
    public GameObject Spawn03;
    public GameObject Spawn04;
    public GameObject Spawn05;
    public GameObject Spawn06;
    public GameObject Spawn07;
    public GameObject Spawn08;
    public GameObject Spawn09;
    public GameObject Spawn10;
    public GameObject Spawn11;
    public GameObject Spawn12;
    public GameObject Spawn13;
    public GameObject Spawn14;

    public int eCount;
    public int rSpawn;

    void Start()
    {
        eCount = 0;
        //StartCoroutine(EnemySpawn());
    }

    void Update()
    {
        
    }

    public IEnumerator EnemySpawn(int wave)
    {
        yield return new WaitForSeconds(5.5f);

        while (eCount < (wave * 8))
        {
            rSpawn = Random.Range(1, 14);

            if (rSpawn == 1 && Spawn01.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn01.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 2 && Spawn02.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn02.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 3 && Spawn03.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn03.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 4 && Spawn04.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn04.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 5 && Spawn05.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn05.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 6 && Spawn06.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn06.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 7 && Spawn07.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn07.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 8 && Spawn08.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn08.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 9 && Spawn09.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn09.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 10 && Spawn10.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn10.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 11 && Spawn11.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn11.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 12 && Spawn12.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn12.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 13 && Spawn13.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn13.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }
            else if (rSpawn == 14 && Spawn14.activeInHierarchy == true)
            {
                Instantiate(Enemy, Spawn14.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                eCount += 1;
            }



        }
    }

}
