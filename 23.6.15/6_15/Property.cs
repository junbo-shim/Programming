using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_15
{
    public class Property
    {
        private string itemName;

        private int itemPrice { get; set; }      // -> 겟함수와 셋함수를 이렇게 한번에 지정해줄 수 있음, 변수 열어주기
        public int itemCount { get; private set; }      // -> 초기화 때에만 값 변경가능, 읽기전용화


        // property의 원형
        public int ItemCount 
        {
            get 
            {
                return _itemCount;
            }
            
            private set 
            {
                _itemCount = value;
            } 
        }







        public void InitItem(string name) 
        {
            itemName = name;
        }

        public string Get_ItemName() // getter 함수 : 아이템 name을 return함
        {
            return itemName;
        }

        public void Set_ItemName(string changedName) // setter 함수 : 아이템 name을 외부에서 변경할 수 있게 함
        {
            itemName = changedName;
        }


    }
}
