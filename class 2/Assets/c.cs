using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    string heroName = "abo7mod";
    float heroHeight = 1.70f;
    int heroAge = 19;
    string heroSuperPower = "speed boost";
    string villainName = "ayoob";
    float villaninHeight = 1.71f;
    int villainAge = 18;
    string villainSuperPower = "invisibility";


    void Start()
    {
        print("hero name is "  +  heroName +  "hero age is"  +  heroAge +  "hero Height is"  + heroHeight +  "hero Super power is "  +  heroSuperPower);

        print("villain name is "  + villainName +  "villain age is"  + villainAge +  "villain Height in "  +  villaninHeight  +  "villain super power is"  +  villainSuperPower);

        print("age Difference is " + (heroAge - villainAge));
        
    }

    void Update()
    {
        
    }
}
