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
	int numbers[13] = { 0, };				// 배열의 선언과 초기화 (1~13 뽑는 배열)
	char char_num[13] = { 0, };				// AJQK 때문에 문자로 출력해야 하므로 문자열을 하나 만든다 (int 말고 char)

	for (int i = 0; i < 13; i++)			
	{
		numbers[i] = i + 1;

		if(numbers[i] == 1)
		{
			char_num[i] = 'A';				// 정수 배열의 값이 1일 때, 문자열은 A
		}
		else if(numbers[i] == 10)
		{
			char_num[i] = 'W';				// 정수 배열의 값이 10일 때, 문자열은 W -> 출력용 if에서 뽑아야하는 값
		}
		else if(numbers[i] == 11)
		{
			char_num[i] = 'J';				// 정수 배열의 값이 11일 때, 문자열은 J
		}
		else if(numbers[i] == 12)
		{
			char_num[i] = 'Q';				// 정수 배열의 값이 12일 때, 문자열은 Q
		}
		else if(numbers[i] == 13)
		{
			char_num[i] = 'K';				// 정수 배열의 값이 13일 때, 문자열은 K
		}
		else
		{
			char_num[i] = '1'+i;
			//10 , 1 2 3 4 5 6 7 8 9
			//1 2 3 4 5 5 
		}
	}
	char patterns[4] = { 'S','H','D','C' };							// 스페이드, 하트, 다이아, 클로버 -> 문자열




	const int shuffleCount = 30000;
	int randomIdx1, randomIdx2 = 0;
	srand(time(NULL));




	for (int i = 0; i < shuffleCount; i++)							// 상수 값 셔플 카운트를 만들고 for 문에서 횟수만큼 돌리는 방법
	{
		randomIdx1 = rand() % 13;									// % 값에 따라 0 ~ % 까지 숫자가 랜덤하게 나옴 -> 13으로 걸면 0 ~ 12까지 나옴
		randomIdx2 = rand() % 13;
		ShuffleOnce(&numbers[randomIdx1], &numbers[randomIdx2]);
	}





	printf("\n");								// 셔플 로직 끝

	while(true) 
	{
		int i = 0;
		_getch();


		if (char_num[i] == 'W')
		{
			printf("┌─────────────────┐\n");
			printf("│ %c 10           │\n", patterns[i % 4]);               // 10은 문자열로 출력할 수 없으므로 따로 하나 출력을 빼야한다
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
			printf("│ %c %c             │\n", patterns[rand() % 4], char_num[i]);               // 만약에 두개의 배열을 굴릴경우 하나를 랜덤값으로 넣어버리는 방법도 존재한다
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

		i++;
	}
}


//void ArrayCard() 
//{
//	char cards[4][13] = {'♠', '◇', '♡', '♣'}, {'A', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K'};
//
//
//}
