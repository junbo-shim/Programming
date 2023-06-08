#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<windows.h>
#include<time.h>

void Swap(int* first, int* second);
void MoveGrid();

int main()
{
	MoveGrid();

	return 0;
}



//void Des002()			// 다차원 배열
//{
//	char char_[25] = { 0, };
//	char char2_[5][5] = { 0, };
//
//	for (int i=0; i<25; i++)
//	{
//		char_[i] = '*';
//	}
//	
//
//	for (int y=0; y<5; y++)
//	{
//		for (int x = 0; x < 5; x++)
//		{
//			if (x == 2 && y == 2)
//			{
//				char2_[y][x] = '0';
//				continue;
//			}
//			char2_[2][2] = '*';
//		}
//	}
//
//
//	//for(int i=0; i < 25; i++)
//	//{
//	//	printf("%c", char_[i]);
//	//
//	//	if(i%5 == 4)
//	//	{
//	//		printf("\n");	
//	//	}
//	//}
//	//printf("\n");
//
//
//	for(int y=0; y<5; y++)
//	{
//		for (int x=0; x<5; x++)
//		{
//			printf("%c ", char2_[y][x]);
//		}
//		printf("\n");
//	}
//	printf("\n");
//
//}


void MoveGrid()
{
	char userinput = _getch();
	int userX = 2;							// 선언은 같이 가능하나 초기화는 따로 해주어야 함 (각각 값을 줘야함)
	int	userY = 2;
	

	char stargrid[5][5] = { 0, };			// 정의와 초기화
	for (int i = 0; i < 5; i++)
	{
		stargrid[i][i] = '*';
	}

	
	while (true)
	{
		if (userinput == 'W')
		{
			userY -= 1;
		}
		else if (userinput == 'A')
		{
			userX -= 1;
		}
		else if (userinput == 'D')
		{
			userX += 1;
		}
		else if (userinput == 'S')
		{
			userY += 1;
		}


		for (int y = 0; y < 5; y++)
		{
			for (int x = 0; x < 5; x++)
			{
				if (x == userX && y == userY)
				{
					stargrid[y][x] = '0';
					continue;
				}
				stargrid[y][x] = '*';
			}

		}


		system("cls");

		for (int y = 0; y < 5; y++)
		{
			for (int x = 0; x < 5; x++)
			{
				printf("%c ", stargrid[y][x]);
			}
			printf("\n");
		}
		printf("\n");
		userinput = _getch();
	}



}


void Swap(int* first, int* second)
{
	int temp = 0;
	temp = *first;
	*first = *second;
	*second = temp;
}