#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Homework();
void Description004();
void Description003();
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
	//Description003();
	Homework();
}


void Homework();
{
	// 길을 걷는 사람 1
	char board[5] = { 0, };

	// board를 초기화하는 로직
	for(int i = 0; i<5; i++)
	{
		board[i] = '*';
		if(i==0)
		{
			board[i] = '0';
		}
	}
	// board를 초기화하는 로직

	// board를 출력하는 로직
	for (int i = 0; i < 5; i++)
	{
		printf("%c", board[i]);
	}
	printf("\n\n");
	// board를 출력하는 로직 
}


void Description004()			// 구구단 출력 프로그램 만들기
{
	const int MAX_ARRAY = 7;
	int guguDan[8] = { 0, };
	

	for (int i = 0; i<MAX_ARRAY; i++)
	{
		printf("%d", guguDan[i + 1] * guguDan[i]);
	
	
	
	
	
	}


	//int lineCount1[9] = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };



}


//void Description003()				// 배열이란 무엇인지 실습
//{	
//	const int MAX_ARRAY = 5;
//	int numbers[MAX_ARRAY];			// 5개의 변수를 선언
//	//numbers[0] = 100;				// 배열의 초기화 방법1 -> 루프 안에 넣기 좋은 방식
//	//numbers[1] = 200;
//	//numbers[2] = 300;
//	//numbers[3] = 400;
//	//numbers[4] = 500;
//
//	
//	for (int i = 0; i<MAX_ARRAY; i++)					// 조건문 안에 들어간 배열
//	{
//		numbers[i] = (i + 2);
//	}
//
//	int numbers2[5] = { 10, 20, 30, 40, 50 };	// 배열의 초기화 방법2
//	int numbers3 = { 0, };						// 모든 배열 초기화 방법
//
//	printf("배열의 값 : 앞은 인덱스, 뒤는 값 : %d, %d \n", 0, numbers[0]);
//	printf("배열의 값 : 앞은 인덱스, 뒤는 값 : %d, %d \n", 4, numbers[4]);
//
//}


//void Description002()
//{
//	// 캐스팅 테스트
//	char char_ = 'A';
//	int int_ = (int)char_;
//	float floatValue = 100.123;
//	printf("변수 안에 무슨 값이 들어있나? %d \n", int_);
//
//}


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