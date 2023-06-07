#include<stdio.h>
#include<conio.h>

void Homework();

int main()										// 메인함수
{
	Homework();
	return 0;
}

void Homework()									// <구동함수>
{

	char board[5] = { 0, };						// 배열 정의 및 초기화, 배열의 이름 board, 배열의 크기 5칸, 초기값 0 0 0 0 0
	int a = 0;									// 루프값 0으로 초기화
	int loopCount= 0;

	for (int a = 0; a < 5; a++)					// <board를 초기화하는 로직 (초기값을 넣는 로직)>
	{

		board[a] = '*';							// a의 값 : board 배열의 순서를 의미, a 값에 따라서 board[0] = *, board[1] = *, board[2] = *, board[3] = *, board[4] = *
												// 즉 board[a] -> ***** 의 의미를 담음 

	}											// <board를 초기화하는 로직 끝>

	for (int a = 0; a < 5; a++)					// <board 값 출력 로직>																													
	{													
		
		if (loopCount == 0)						// loopCount가 0일 경우에는 0*****
		{	
			_getch();
			board[loopCount] = '0';
		}
		else									// loopCount가 1일 경우 *0***
		{										// loopCount가 2일 경우 **0**
			_getch();
			board[loopCount - 1] = '*';			// loopCount가 3일 경우 ***0*
			board[loopCount] = '0';				// loopCount가 4일 경우 ****0
		}

		loopCount++;							// loopCount 증가 -> 출력로직 for-if,for-else,for-else,for-else,for-else 를 마무리하고 끝

		for (int a = 0; a < 5; a++) 
		{
			printf("%c", board[a]);				// 출력문
		}
		printf("\n\n");
	}											// <board 값 출력 로직 끝>
}												// <구동함수 끝>









//void Homework();
//{
//	// 길을 걷는 사람 1
//	char board[5] = { 0, };
//
//	// board를 초기화하는 로직
//	for (int i = 0; i < 5; i++)
//	{
//		board[i] = '*';
//		if (i == 0)
//		{
//			board[i] = '0';
//		}
//	}
//	// board를 초기화하는 로직
//
//	// board를 출력하는 로직
//	for (int i = 0; i < 5; i++)
//	{
//		printf("%c", board[i]);
//	}
//	printf("\n\n");
//	// board를 출력하는 로직 
//}