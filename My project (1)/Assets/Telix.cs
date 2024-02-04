

public class Telix {


    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;
    //public = 외부 클래스에 공개로 설정하는 접근자

    public string Talk(){
        return "윤기나는 갑옷을 입고 풍채가 훌륭한 사내가 당신에게 말을 걸어옵니다.";
    }

    public string HasWeapon() {
        return weapon;
    }

    public void Levelup() {
        level = level + 1;
    }
}
