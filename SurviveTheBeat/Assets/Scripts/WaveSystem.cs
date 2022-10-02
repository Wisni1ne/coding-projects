using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{

    public bool newWave;

    public int wave;
    public int enemyCount;

    public TextMeshProUGUI waveText;

    public GameObject spawner;
    public GameObject player;

    public void Start()
    {
        wave = (int)PlayerPrefs.GetFloat("wavenum");

        newWave = true;
    }

    public void Update()
    {

        waveText.text = wave.ToString();
        enemyCount = spawner.GetComponent<Spawn>().eCount;

        if (enemyCount == 0 && newWave)
        {
            wave++;
            newWave = false;
            player.GetComponent<PlayerHealth>().currentHealth = player.GetComponent<PlayerHealth>().maxHealth;
            player.GetComponent<PlayerHealth>().SetHealthText();
            StartCoroutine(spawner.GetComponent<Spawn>().EnemySpawn(wave));
            GetComponent<RhythmSpawn>().tempoSet = Random.Range(1, 4);
            StartCoroutine(GetComponent<RhythmSpawn>().RhythmSystem(GetComponent<RhythmSpawn>().tempoSet));
        } 
    }
}
