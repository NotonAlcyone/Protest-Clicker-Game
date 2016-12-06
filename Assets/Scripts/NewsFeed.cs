using UnityEngine;
using System.Collections;

public class NewsFeed : MonoBehaviour
{
   
    public string[] NormalMessage =
    {
        "오버워치 대회에서 한국팀이 우승을 차지했습니다.",
        "공무원들의 연봉이 인상됩니다.",
        "매미를 애완충으로 삼는 가구가 늘고있습니다." //ひぐらし
    };
    public string[] PeaceMessage =
   {
        "시위대가 구호를 외치며 행진하고 있습니다.",
        "사상자 없이 시위가 무사히 종료되었습니다.",
        "유래없는 평화시위에 경찰들 당황",
        "해외언론 시위보도",
        "A국 대통령 시위에 대해 민주주의 꽃이라 평가"
    };
    public string[] ViolentMessage =
   {
        "국가가 당일 18시 00분을 기준으로 계엄령을 발동했습니다.",
        "시위 사상자가 200명을 넘었습니다.",
        "광장에 국가가 울려퍼지고 있습니다.",
        "전국 도처에 시위가 확산되고 있습니다.",
        "도시 계엄 사령관은 기자회견을 통해 타협은 없다는 점을 분명시 했습니다."
    };
}
