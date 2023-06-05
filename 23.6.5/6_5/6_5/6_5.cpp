#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>


void Description002();
//void Description001(int number);
//int AddOne(int* localNumber1, int* localNumber2);



int main()
{
	// 이 위치에서 프로그램은 시작
	//void Description001(10);
	//printf("Description001 함수가 끝나면 되돌아와서 이걸 출력해야함.\n");

	// 오늘 할 것 포인터
	//int mainNumber1 = 0;
	//int mainNumber2 = 0;
	//AddOne(&mainNumber1, &mainNumber2);
	//printf("number의 상태 1 : %d, 2 : %d\n\n", mainNumber1, mainNumber2);
	//printf("number의 상태 1. 주소 : %#x, 2. 가지고 있는 값: %d\n\n", &mainNumber1, mainNumber1);
	//Description002();

}


void Description002()
{
	// 캐스팅 테스트
	char char_ = 'A';
	int int_ = char_;
	printf("변수 안에 무슨 값이 들어있나? %d \n", int_);

}


//int AddOne(int* localNumber1, int* localNumber2)
//{
//	*localNumber1 += 1;
//	*localNumber2 += 2;
//	
//	return localNumber1, localNumber2;
//}


//void Description001()
//{
//	printf("Number 는 %d \n", number);
//}


