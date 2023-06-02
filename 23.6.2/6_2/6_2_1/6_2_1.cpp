#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>


//void Description()
//{
//
//	int randomNumber = 0;
//	const int MAX_DICE_VALUE = 6;
//	srand(time(NULL));
//
//	printf("주사위 프로그램 \n\n");
//	_getch();
//	printf("컴퓨터가 뽑은 3개의 주사위 값 -> ");
//	for (int i = 0; i < 3; i++)
//	{
//		Sleep(1000);
//		randomNumber = (rand() % MAX_DICE_VALUE) + 1;
//		printf("%d", randomNumber);
//
//	}
//	Sleep(1000);
//	printf("\n\n");
//	printf("프로그램 종료 \n\n");
//
//}

//
//	int playerinput;
//	int critc;
//	int critchance();
//	float critjudge(int critc);
//	int scan(int playerinput);
//	int result(int scan1);
//
//
//
//int main()
//{
//
//
//	printf("행동커맨드를 입력하시오. \n1. 공격 2. 도망\n");
//	scanf_s("%d", &playerinput);
//
//	scan();
//	critjudge(critc);
//	result(scan(playerinput));
//
//
//
//	return 0;
//}
//
//
//int scan()				// 스캔 
//{
//	if (playerinput = 1)
//	{
//		return 1;						// 입력이 1이면 결과값 1
//	}
//	else if (playerinput = 2)
//	{
//		return 2;						// 입력이 2이면 결과값 2
//	}
//	else
//	{
//		return 3;						// 입력이 3이면 결과값 3
//	}
//}
//
//
//int result(int scan1)							// 행동 결과
//{
//	 if(scan(playerinput) == 1)
//	 {
//		printf("!!!당신은 적을 공격했다!!! %f 확률로 크리티컬 히트!!! %f 데미지!!!",critc*10 ,critjudge(critc));
//	 }
//	 else if (scan(playerinput) == 2)
//	 {
//		printf("!!!당신은 전략적 후퇴를 했다!!!");
//	 }
//	 else
//	 {
//		printf("!!!옳바르지 못한 커맨드입니다!!!");
//	 }
//	 return 0;
//}
//
//
//int critchance()						// 크리티컬 확률 계산 10면체 주사위
//{
//	srand(time(NULL));
//
//	critc = (rand() % 10) + 1;
//
//	return critc;
//}
//
//
//float critjudge(int critc)				// 크리티컬 확률 굴림
//{
//	if(critc >= 6)
//	{
//		return 150;						// 크리티컬 데미지
//	}
//	else
//	{
//		return 100;						// 노멀 데미지
//	}
//}
//
//
//
//
//
//
//



int input; // 플레이어 인풋
int critchance;



int main()
{
	while (1)
	{
		printf("당신은 몬스터와 조우했다. \n행동을 고르시오. 1. 공격 2. 도망 \n");
		scanf_s("%d", &input);



		srand(time(NULL));
		critchance = (rand() % 101) + 1;													// 크리티컬 확률 1~100

			

		if(input == 1 && critchance >= 60)
		{
			printf("!!!당신은 공격을 가했다. 15 데미지!!! 크리티컬 성공 확률 : (%d) \n", critchance);
			continue;
		}
		else if(input == 1 && critchance < 60)
		{
			printf("!!!당신은 공격을 가했다. 10 데미지!!! 크리티컬 실패 확률 : (%d) \n", critchance);
			continue;
		}
		else if(input == 2)
		{
			printf("...당신은 도망쳤다...");
			break;
		}
		else
		{
			printf("옳바르지 못한 입력값 입니다. \n");
			continue;
		}
	}
}
