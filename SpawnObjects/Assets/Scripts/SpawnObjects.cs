using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objSpawn;

    [SerializeField] private float _time = 1f;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _distance = 1f;

    public TMP_InputField textTime;
    public TMP_InputField textSpeed;
    public TMP_InputField textDistance;

    void Start()
    {
        textTime.text = _time.ToString();
        textSpeed.text = _speed.ToString();
        textDistance.text = _distance.ToString();
        StartCoroutine(Spawn());
    }
    public void SaveText()
    {
        _time = float.Parse(textTime.text);
        _speed = float.Parse(textSpeed.text);
        _distance = float.Parse(textDistance.text);
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_time);

        float pos = Random.Range(-1, 3.01f);
        GameObject newObj = Instantiate(objSpawn, new Vector3(pos, transform.position.y, transform.position.z), Quaternion.identity);
        newObj.GetComponent<Move>().speed = _speed;
        newObj.GetComponent<Move>().distance = _distance;
        StartCoroutine(Spawn());
    }
}
