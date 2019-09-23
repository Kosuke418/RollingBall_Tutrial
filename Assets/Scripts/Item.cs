using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    public GameObject coin;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(2, 6);
        GameObject[] g = new GameObject[num];

        for (int i = 0; i < num; i++) {
            g[i] = (GameObject)Instantiate(coin, new Vector3(Random.Range(-4f, 4f), 0.6f, Random.Range(-4f, 4f)), Quaternion.identity);
            g[i].transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0)
        {
            text.enabled = true;
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
            Time.timeScale = 1;
        }
    }
}
