#include<stdio.h>
#include<stdlib.h>
#include<windows.h>
#include<time.h>
#include<conio.h>

void NumPattern();
void ShuffleOnce(int* firstNum, int* secondNum);


int main()
{
	NumPattern();

	return 0;
}


void ShuffleOnce(int* firstNum, int* secondNum)			// 스왑함수
{
	int temp = 0;
	temp = *firstNum;
	*firstNum = *secondNum;
	*secondNum = temp;
}


void NumPattern()
{
	int numbers[13] = { 0, };				// 배열의 선언과 초기화
	char char_num[13] = { 0, };

	for (int i = 0; i < 13; i++)								// 
	{
		numbers[i] = i + 1;

		if(numbers[i] == 1)
		{
			char_num[i] = 'A';
		}
		else if(numbers[i] == 10)
		{
			char_num[i] = 'W';
		}
		else if(numbers[i] == 11)
		{
			char_num[i] = 'J';
		}
		else if(numbers[i] == 12)
		{
			char_num[i] = 'Q';
		}
		else if(numbers[i] == 13)
		{
			char_num[i] = 'K';
		}
		else
		{
			char_num[i] = '1'+i;
			//10 , 1 2 3 4 5 6 7 8 9
			//1 2 3 4 5 5 
		}
	}
	char patterns[4] = { 'S','H','D','C' };




	const int shuffleCount = 30000;
	int randomIdx1, randomIdx2 = 0;
	srand(time(NULL));




	for (int i = 0; i < shuffleCount; i++)							// 상수 값 셔플 카운트를 만들고 for 문에서 횟수만큼 돌리는 방법
	{
		randomIdx1 = rand() % 13;									// % 값에 따라 0 ~ % 까지 숫자가 랜덤하게 나옴 -> 10으로 걸면 0 ~ 9까지 나옴
		randomIdx2 = rand() % 13;
		ShuffleOnce(&numbers[randomIdx1], &numbers[randomIdx2]);
	}





	printf("\n");								// 셔플 로직 끝

	for (int i = 0; i < 10; i++)
	{
		_getch();


		if (char_num[i] == 'W')
		{
			printf("┌─────────────────┐\n");
			printf("│ %c 10           │\n", patterns[i % 4]);               // 10은 아스키 코드로 표현할 수 없으므로 따로 직접 그려야한다
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("└─────────────────┘\n");
		}
		else
		{


			printf("┌─────────────────┐\n");
			printf("│ %c %c             │\n", patterns[i % 4], char_num[i]);               // 만약에 두개의 배열을 굴릴경우 하나를 랜덤값으로 넣어버리는 방법도 존재한다
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("│                 │\n");
			printf("└─────────────────┘\n");
		}
	}
}



