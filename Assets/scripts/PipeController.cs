using System.Collections;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    #region Declarations
    public float SecondDelay;

    public GameObject HigherPipe;
    public GameObject LowerPipe;
    public GameObject DoublePipe;

    public Transform LowerPoint;
    public Transform HighPoint;
    public Transform MiddlePoint;
    #endregion

    public IEnumerator PipeSpawner() 
    {
        yield return new WaitForSeconds(SecondDelay);
        Spawn();
    }   
    private void Spawn() 
    {
        int random = (int)Random.Range(0,3);

        if (random == 0)
            Instantiate<GameObject>(LowerPipe, LowerPoint.position, Quaternion.identity);
        else if (random == 1) 
            Instantiate<GameObject>(DoublePipe, MiddlePoint.position, Quaternion.identity);
        else if (random == 2) 
            Instantiate<GameObject>(HigherPipe, HighPoint.position, Quaternion.identity);
    }
}
