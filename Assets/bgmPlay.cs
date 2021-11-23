using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmPlay : MonoBehaviour
{

    static bgmPlay instance = null;
    public static bgmPlay Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);//使对象目标在加载新场景时不被自动销毁
    }

}
