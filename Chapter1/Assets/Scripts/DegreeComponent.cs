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
        //float delta = scalar * Mathf.Sin(dTime); //sin�׷��� ��� �þ��� �پ��� �ٽ� �þ�� ����̹Ƿ� �츮�� ���ϴ� ������ ��������

        //����(x,y)
        float x = scalar * Mathf.Cos(DegreesToRad(degress));
        float y = scalar * Mathf.Sin(DegreesToRad(degress));

        //x += scalar * Mathf.Cos(DegreesToRad(degress * 3)); //���� ������ �׷������� �͵��� x �� �߰��� ���������ν� �ٸ� ���·� ������


        //������ �������� ������ϰ� �׳� ���� ���� ����� �ȵ��� �̻��ϰ� �����δ�
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
