using Unity.VisualScripting;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class Study : MonoBehaviour
{
    // 이게 주석입니다.//
    /* 이렇게도
     * 쓸 수 있지롱
     * 하하하 */

    public string say = "";
    public char text = 'a';
    public int var = 0;
    public float var02 = 0.1f;
    public double var03 = 0.5;
    public bool var04 = false;
    private bool var05 = false;



    void Start()
    {
        int a = 10;

        Debug.Log(a++);
        Debug.Log(++a);
        Random.Range(0, 100);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
