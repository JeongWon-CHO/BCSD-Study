using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField]
    private int hp; // 바위의 체력

    [SerializeField]
    private float destoryTime; // 파편 제거 시간

    [SerializeField]
    private SphereCollider col; // 구체 콜라이더

    // 필요한 게임 오브젝트
    [SerializeField]
    private GameObject go_rock; // 일반 바위


    [SerializeField]
    private GameObject go_debris; // 깨진 바위

    [SerializeField]
    private GameObject go_effect_prefabs; // 채굴 이펙트

    [SerializeField]
    private GameObject go_rock_item_prefab; // 돌맹이 아이템

    [SerializeField]
    private string strike_Sound;

    [SerializeField]
    private string destroy_Sound;


    public void Mining()
    {
        //SoundManager.instance.PlaySE(strike_Sound);
        var clone = Instantiate(go_effect_prefabs, col.bounds.center, Quaternion.identity);
        Destroy(clone, destoryTime);

        hp--;

        if (hp <= 0) Destruction();
    }

    private void Destruction()
    {
        //SoundManager.instance.PlayerSE(destroy_Sound);

        col.enabled = false;

        Instantiate(go_rock_item_prefab, go_rock.transform.position, Quaternion.identity);
        Instantiate(go_rock_item_prefab, go_rock.transform.position, Quaternion.identity);
        Instantiate(go_rock_item_prefab, go_rock.transform.position, Quaternion.identity);
        Instantiate(go_rock_item_prefab, go_rock.transform.position, Quaternion.identity);
        Instantiate(go_rock_item_prefab, go_rock.transform.position, Quaternion.identity);

        Destroy(go_rock);



        go_debris.SetActive(true);
        Destroy(go_debris, destoryTime);
    }

}
