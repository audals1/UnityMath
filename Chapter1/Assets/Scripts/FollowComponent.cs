using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowComponent : MonoBehaviour
{
    public Transform _targetObj;
    public Vector3 _dir;
    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_targetObj != null)
        {
            float x = _targetObj.position.x - transform.position.x; //x������
            float y = _targetObj.position.y - transform.position.y;// y������

            double total = System.Math.Pow(x, 2) + System.Math.Pow(y, 2); // a + b ����
            double range = System.Math.Sqrt(total); // c����

            if (range > 0.1f && range < 3.0f)
            {
                _dir = new Vector3(x, y, 0);

                transform.position += _dir * _speed * Time.deltaTime;
            }
        }
        
    }
}
