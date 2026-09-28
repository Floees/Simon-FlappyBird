using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PipeController PC;
    public float Timer;
    public TextMeshProUGUI TimerText;
    public GameObject Player;
    public Transform StartPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timer = 0;
        GameObject p = Instantiate<GameObject>(Player, StartPoint.position, Quaternion.identity); //quaternion identity samma position some den har
        StartCoroutine(PC.PipeSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        Debug.Log("time passed");
        TimerText.text = Timer.ToString("F0");
    }
}
