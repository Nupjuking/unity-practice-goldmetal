using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
// class A : B = A가 B에게 상속받는다
{
    void Start()
    {
        Debug.Log("반갑습니다.");

        //1. 변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "이안";
        bool isFullLevel = false;
        bool isGraduate = true;

        //2. 그룹형 변수 (배열, List)
        string[] monsters = {"슬라임", "사막뱀", "악마"};
        int[] monsterLevel = new int[3]; // [3]은 배열의 크기
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>(); //string은 List의 타입
        items.Add("생명의 물약");
        items.Add("마력의 정수");

        items.RemoveAt(0); //아이템 삭제

        //3. 연산자
        int exp = 150;

        exp = 150 + 320;
        exp = exp - 10;
        level = exp / 30;
        strength = level * 3.1f;

        int nextExp = 30 - (exp % 30); // % = 나머지

        string title = "연성 개혁자";
        Debug.Log("당신의 이름은 ?");
        Debug.Log(title + ", " + playerName);

        string Graduate = isGraduate ? "예" : "아니오";
        Debug.Log("에르베레나 출신의 마도사입니까 ? " + Graduate);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level >= 10;

        int health = 30;
        int mana = 500;
        bool isBadCondition = health < 50 && mana <= 500;
        // && = and, || = or

        string condition = isBadCondition ? "나쁨" : "좋음";
        //  ? A : B = true면 A, false면 B 출력

        //4. 키워드
        //int float string bool new List class···

        //5. 조건문
        if (condition == "나쁨") {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요.");
        }
        else {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }
        
        if (isBadCondition && items[0] == "생명의 물약") {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명의 물약을 사용하여 30의 체력을 회복했습니다.");
        }
        else if (isBadCondition && items[0] == "마력의 정수") {
            items.RemoveAt(0);
            mana += 100;
            Debug.Log("마력의 정수를 사용하여 100의 마나를 회복했습니다.");
        }

        switch (monsters[0]) {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터 출현!");
                break;
            default:
                Debug.Log("??? 출현!");
                break;
            // default = case 외의 경우
        }

        //6. 반복문
        while (health > 0) {
            health--;
            Debug.Log("독 데미지를 입었습니다. 남은 체력: " + health);
            if (health <= 0) {
                Debug.Log("사망하였습니다.");
            }
            
            if (health == 10) {
                Debug.Log("'해독'을 사용하여 중독 상태를 해제하였습니다.");
                break;
            }
        }

        for (int count = 0 ; count < 10 ; count ++) {
            health ++;
            Debug.Log("'재생'을 사용하여 체력을 회복합니다. 남은 체력: " + health);
        }

        for (int index = 0; index < monsters.Length; index ++) {
        //.Length = 배열의 개수, .Count = 리스트의 개수
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        foreach (string monster in monsters) {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        health = Heal(health);

        for (int index = 0; index < monsters.Length; index ++) {
            Debug.Log(monsters[index] + "에게 " + Battle(level, monsterLevel[index]));
        }

        //8. 클래스
        Telix templar = new Telix();
        templar.id = 0;
        templar.name = "텔릭스";
        templar.title = "태양의 기사단장";
        templar.strength = 24.4f;
        templar.weapon = "제1성검 보름태양";
        templar.level = 59;
        Debug.Log(templar.Talk());
        Debug.Log("그는 " + templar.HasWeapon() + "을 가지고 있습니다.");

        templar.Levelup();
        Debug.Log(templar.name + "의 레벨은 " + templar.level + "입니다");
    }

    //7. 함수 (method)
    int Heal (int H) {
        H += 10;
        Debug.Log("'순간 치유'를 사용하여 체력을 10 회복합니다. 남은 체력: " + H);
        return H;
    }

    string Battle(int level, int monsterLevel) {
        string result;
        if (level >= monsterLevel)
            result = "승리하였습니다.";
        else
            result = "패배하였습니다.";
        return result;
    }

    //void Heal() { 
    ////void 함수는 매개변수가 없기 때문에 지역변수 사용 불가, 전역 변수 필요
        //health += 10;
        //Debug.Log("'순간 치유'를 사용하여 체력을 10 회복합니다. 남은 체력: " + health);
    //}
    ////Heal(); 로 사용
}
