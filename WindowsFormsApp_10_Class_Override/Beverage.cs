using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_10_Class_Override
{
    //1. 기본 음료 클래스(부모 클래스)
    public class Beverage
    {
        //1. 오버로드
        //ㄴ 같은 이름의 메서드를 매개변수만 다르게 해서 여러 개 정의 하는것

        public void Order()
        {
            Console.WriteLine("기본 음료를 주문하셨습니다.");
        }
        public void Order(string name)
        {
            Console.WriteLine($"{name} 음료를 주문하셨습니다.");
        }
        public void Order(string name, string size)
        {
            Console.WriteLine($"{size} 사이즈의 {name} 음료를 주문하셨습니다.");
        }

        //2. 오버라이드
        //ㄴ 부모 클래스의 메서드를 자식 클래스에서 재정의 하는것
        //ㄴ 부모 클래스가 기본 기능을 제공하며
        //ㄴ 자식 클래스에서는 그 기능을 자신만의 방식으로 바꿔야 할 때가 많을 때 사용
        //조건)
        //1) 부모 메서드가 virtual 키워드로 선언되어 있어야 함
        //2) 자식 메서드에서 override 키워드로 재정의 해야함

        //virtual: 오버라이드 허용
        public virtual void Prepare()
        {
            Console.WriteLine("음료를 준비 중입니다.");
        }
    }

    //2. 아메리카노 클래스
    public class Americano : Beverage
    {
        //override: 부모 메서드 덮어쓰기
        public override void Prepare()
        {
            Console.WriteLine("아메리카노를 준비하고 있습니다.");
        }
    }

    //3. 라떼 클래스
    public class Latte : Beverage
    {
        //sealed: override를 더 이상 못하게 막음
        //ㄴ 여기까지만 재정의(override) 가능
        //ㄴ 하위 자식들은 이 메서드를 바꾸지 못하게 막음

        public sealed override void Prepare()
        {
            Console.WriteLine("라떼를 준비하고 있습니다.");
        }
    }

    //4. 콜드브루 클래스
    //ㄴ sealed를 상속받는 자식 클래스
    //ㄴ override 불가
    public class ColdBrew : Latte
    {
        //sealed 때문에 override가 불가
        //public override void Prepare()
        //{
        //    Console.WriteLine("콜드브루를 준비하고 있습니다.");
        //}
    }

    //5. 모든 메뉴가 Beverage만 상속하는 구조라면
    public class ColdBrew2 : Beverage
    {
        //Latte 클래스를 상속받은것이 아닌 Beverage 클래스를 상속받아 sealed의 영향을 받지 않아 override 가능
        public override void Prepare()
        {
            Console.WriteLine("콜드브루를 준비하고 있습니다.");
        }
    }
}
