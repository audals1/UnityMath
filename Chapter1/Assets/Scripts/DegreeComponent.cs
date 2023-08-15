using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreeComponent : MonoBehaviour
{
    [Range(1,4)]
    public float scalar = 0.0f;
    [Range(0, 360)]
    public float degress = 0.0f;

    float dTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        degress += Time.deltaTime * 50f;
        //float delta = scalar * Mathf.Sin(dTime); //sin그래프 곡선은 늘었다 줄었다 다시 늘어나는 모양이므로 우리가 원하는 움직임 구현가능

        //방향(x,y)
        float x = scalar * Mathf.Cos(DegreesToRad(degress));
        float y = scalar * Mathf.Sin(DegreesToRad(degress));

        //x += scalar * Mathf.Cos(DegreesToRad(degress * 3)); //원래 원으로 그려져야할 것들이 x 값 추가로 더해짐으로써 다른 형태로 움직임


        //각도를 라디언으로 변경안하고 그냥 쓰면 각이 제대로 안들어가서 이상하게 움직인다
        //float x = delta * Mathf.Cos(degress);
        //float y = delta * Mathf.Sin(degress);

        Vector3 dir = new Vector3(x, y, 0);

        transform.position = dir;
    }

    float DegreesToRad(float degrees)
    {
        return degrees * Mathf.PI / 180;
    }
}
