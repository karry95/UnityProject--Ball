using UnityEngine;
using System.Collections;

public class Danger : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 dangerValue;
    public float dangerWait;
    public float dangerMostWait;
    public float dangerLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    void Start ()
    {
        StartCoroutine (waitDanger());
	}
	
	void Update ()
    {
        dangerWait = Random.Range(dangerLeastWait, dangerMostWait);
	}
    IEnumerator waitDanger()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0, 2);

            Vector3 dangerPosition = new Vector3(Random.Range(- dangerValue.x, dangerValue.x), 1, Random.Range(-dangerValue.z, dangerValue.z));

            Instantiate(enemies[randEnemy], dangerPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(dangerWait);
        }
    }

}
