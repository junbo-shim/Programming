#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<windows.h>
#include<time.h>

void Des001();
void DrawSqaure();

int main()
{
	DrawSquare();
	return 0;
}

void Des001()		// New 동적할당
{
	int userInput = -1;
	printf("원하는 크기만큼 배열을 만들겠음. 크기를 입력하시오 : ");
	scanf_s("%d", &userInput);

	//int numbers[10] = { 0, };        -> 스택에 저장됨
	int* numbers2 = new int[userInput];	 // -> 힙에 저장되서 큰 크기를 버틸 수 있음 (힙에 배열을 할당)
											// 힙에 저장된 데이터는 컴퓨터가 꺼질때까지 남음
	for(int i=0; i<userInput; i++)
	{
		numbers2[i] = i + 1;
	}
	for(int i=0; i<userInput; i++)
	{
		printf("i값 : %d \n", numbers2[i]);
	}
	printf("\n\n");

	delete[] numbers2;					// 프로그램 종료시에 힙에서 내려감
}

void Des002()
{
	





}