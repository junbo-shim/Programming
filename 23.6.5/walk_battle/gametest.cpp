#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>


int loopcount = 1;           // 루프횟수
int userinput = 0;			 // 유저 입력값
int proceedchance = 0;		 // 진행 랜덤 값
int battlechance = 0;		 // 전투 발생 랜덤 값
int playerhp = 50;			 // 플레이어 체력 = 50
int playeratk = 5;			 // 플레이어 공격력 = 5
int monhp = 20;				 // 몬스터 체력 = 20
int monatk = 10;			 // 몬스터 공격력 = 10
int monattresult;			 // 플레이어체력 - 몬스터공격력 값
int playerattresult;		 // 몬스터체력 - 플레이어공격력 값
int playerhp_after;			 // 전투 루프 이후 플레이어 체력값


void walkloop();									// 걷기 루프
void mountain(int battlechance);					// 산에서 전투, 회복 발생 함수
void getheal(int playerhp);							// 힐 메커니즘 함수
int monatt(int playerhp, int monatk);				// 몬스터턴 공격 함수
int playeratt(int monhp, int playeratk);			// 플레이어턴 공격 함수
void combat(int playerhp, int monhp);				// 전투 메커니즘 함수
int loopplayerhp(int playerhp);						// 루프 후 플레이어 체력 변화값 저장 함수




int main()
{
	srand(time(NULL));


	while (true)
	{
		printf("\n'1'을 누르면 길을 걷습니다.\n'2'를 누르면 게임을 그만둡니다.\n\n");
		scanf_s("%d", &userinput);

		if (userinput == 1)															// 1번 선택시
		{
			printf("\n[system] 1을 입력하셨습니다. 당신은 모험을 떠납니다...\n\n");
			walkloop();
			loopplayerhp(monattresult);

		}
		else if (userinput == 2)													// 2번 선택시
		{
			printf("\n[system] 2를 입력하셨습니다. 게임을 종료합니다.\n\n");
			break;
		}
		else																		// 그 이외 입력시
		{
			printf("\n[system] 잘못된 입력입니다. 다시 입력해주세요.\n\n");
			continue;
		}
	}
	return 0;
}


void walkloop()																				// 걷기 시스템
{
	while (loopcount == 8);
	{
		loopplayerhp(monattresult);
		Sleep(1000);
		printf("\n<walk : %d> [현재 당신의 체력 : %d / %d]\n\n", loopcount, playerhp, 50);		//현재 루프 및 체력 출력
		proceedchance = (rand() % 101) + 1;													//걷기 확률
		battlechance = (rand() % 101) + 1;													//전투 확률
		Sleep(1000);


		if (1 <= proceedchance && proceedchance <= 20 && loopcount < 7)						// 강 확률 20% 및 루프 조건
		{
			printf("[system] 당신은 강에 도착했습니다. (%d 확률)\n", proceedchance);
			Sleep(1500);
			printf("[system] 당신은 맑은 물을 마실 수 있었습니다. 당신은 기분이 좋아졌습니다.\n");
			loopcount++;																	// 루프 증가
		}
		else if (21 <= proceedchance && proceedchance <= 50 && loopcount < 7)				// 길 확률 30% 및 루프 조건
		{
			printf("[system] 당신은 길에 도착했습니다. (%d 확률)\n", proceedchance);
			Sleep(1500);
			printf("[system] 당신은 도둑을 만나 지갑을 잃어버렸습니다. 당신은 기분이 나빠졌습니다.\n");
			loopcount++;																	// 루프 증가
		}
		else if (51 <= proceedchance && proceedchance <= 100 && loopcount < 7)				// 산 확률 50% 및 루프 조건
		{
			printf("[system] 당신은 산에 도착했습니다. (%d 확률)\n", proceedchance);	
			mountain(battlechance);
			loopcount++;																	// 루프 증가
			loopplayerhp(monattresult);														
			Sleep(1500);
		}
		else if (loopcount == 7)															// 7번째 루프시 출력문
		{
			printf("[system] 당신은 목적지에 도착했습니다. 당신의 여정은 여기서 끝납니다.\n");
			exit(1);																		// 강제종료 명령
		}
	}
	return;
}


void mountain(int battlechance)																// 산에서의 전투 또는 회복 분기
{
	if (1 <= battlechance && battlechance <= 40)											// 전투 확률 40%
	{
		printf("[system] !!!당신은 몬스터와 만났습니다!!! (%d 확률)\n", battlechance);
		Sleep(2000);
		combat(playerhp, monhp);
		loopplayerhp(monattresult);
	}
	else if (41 <= battlechance && battlechance <= 100)										// 회복 확률 60%
	{
		printf("[system] 당신은 회복의 샘을 찾았습니다. (%d %확률)\n", battlechance);
		Sleep(2000);
		getheal(playerhp);
	}
	return;
}


void getheal(int playerhp)																	// 회복 시스템
{
	if (playerhp <= 40)
	{
		playerhp += 10;
		printf("당신의 체력은 10만큼 회복되었습니다.\n");
		Sleep(1000);
	}
	else if (40 < playerhp && playerhp < 50)
	{
		printf("당신의 체력은 5만큼 회복되었습니다.\n");
		Sleep(1000);
	}
	else if (playerhp == 50)
	{
		printf("당신의 체력은 가득 차있습니다.\n");
		Sleep(1000);
	}
	return;
}


int monatt(int playerhp, int monatk)														// 몬스터 공격 결과값 저장 함수
{
	monattresult = playerhp - monatk;
	return monattresult;
}


int playeratt(int monhp, int playeratk)														// 플레이어 공격 결과값 저장 함수
{
	playerattresult = monhp - playeratk;
	return playerattresult;
}

int loopplayerhp(int monattresult)															// 플레이어 체력 결과값 저장 함수
{
	monattresult = playerhp_after;
	return playerhp_after;
}

void combat(int playerhp, int monhp)														// 전투 메커니즘
{

	while(true)
	{   
		monhp = playeratt(monhp, playeratk);
		printf("\n!!!당신은 몬스터를 공격했습니다!!! [가한 데미지 : %d, 남은 몬스터의 체력 : %d]\n", playeratk, playerattresult);
		Sleep(1000);

		if(playerattresult > 0)
		{
			playerhp = monatt(playerhp, monatk);
			printf("\n!!!몬스터가 당신을 공격합니다!!! [받은 데미지 : %d, 남은 당신의 체력 : %d]\n", monatk, monattresult);
			Sleep(1000);

/*			if(monattresult > 0)
			{
				continue;
			}
			else */if(monattresult <= 0)
			{
				printf("\n당신은 죽었습니다...GAME OVER...\n");
				Sleep(1000);
				exit(1);
			}
		}
		else if(playerattresult <= 0)
		{
			printf("\n당신은 몬스터를 쓰려뜨렸습니다! [당신의 현재 체력 : %d]\n", playerhp);
			Sleep(1000);
			loopplayerhp(monattresult);															// 쓸모가 있는지 없는지 의문
			break;
		}
	}
}








//int loopcount = 1;
//int userinput = 0;
//int proceedchance = 0;
//int battlechance = 0;
//
//const int player_max_hp = 50;
//const int monster_max_hp = 20;
//const int playeratt = 5;
//const int monsteratt = 10;
//int player_cur_hp;
//int monster_cur_hp;
//int result1 = 0;
//int result2 = 0;

//int main()
//{
//	srand(time(NULL));
//	int playerattresult(int monster_cur_hp, int playeratt);
//	int monsterattresult(int player_cur_hp, int monsteratt);
//
//	int result1 = playerattresult(monster_cur_hp, playeratt);
//	int result2 = monsterattresult(player_cur_hp, monsteratt);
//
//
//
//	while (1)	// 버튼 선택 루프
//	{
//		printf("\n'1'을 누르면 길을 걷습니다.\n'2'를 누르면 게임을 그만둡니다.\n\n");
//		scanf_s("%d", &userinput);
//
//
//
//		if (userinput == 1)		// 1번 선택시
//		{
//			printf("\n[system] 1을 입력하셨습니다. 당신은 모험을 떠납니다...\n\n");
//
//
//			while (loopcount == 8);
//			{
//				Sleep(1000);
//				printf("\n<Walk : %d> [현재 당신의 체력 : %d / %d]\n\n", loopcount, player_cur_hp, player_max_hp);		//현재 루프 및 체력 출력
//				proceedchance = (rand() % 101) + 1;																//걷기 확률
//				battlechance = (rand() % 101) + 1;																//전투 확률
//				Sleep(1000);
//
//
//				if (1 <= proceedchance && proceedchance <= 20 && loopcount < 7)
//				{
//					printf("[system] 당신은 강에 도착했습니다. (%d 확률)\n", proceedchance);
//					Sleep(1500);
//					printf("[system] 당신은 맑은 물을 마실 수 있었습니다. 당신은 기분이 좋아졌습니다.\n");
//					loopcount++;
//					continue;
//				}
//				else if (21 <= proceedchance && proceedchance <= 50 && loopcount < 7)
//				{
//					printf("[system] 당신은 길에 도착했습니다. (%d 확률)\n", proceedchance);
//					Sleep(1500);
//					printf("[system] 당신은 도둑을 만나 지갑을 잃어버렸습니다. 당신은 기분이 나빠졌습니다.\n");
//					loopcount++;
//					continue;
//				}
//				else if (51 <= proceedchance && proceedchance <= 100 && loopcount < 7)
//				{
//					printf("[system] 당신은 산에 도착했습니다. (%d 확률)\n", proceedchance);
//					Sleep(1500);
//
//
//					if (1 <= battlechance && battlechance <= 40)
//					{
//						printf("[system] !!!당신은 몬스터와 만났습니다!!! (%d 확률)\n", battlechance);
//						Sleep(1500);
//
//						playerattresult(monster_cur_hp, playeratt);
//						monsterattresult(player_cur_hp, monsteratt);
//
//						while(1)
//						{
//							playerattresult(monster_cur_hp, playeratt);
//							if (result1 > 0)
//							{
//								printf("[system] !!!당신은 몬스터를 쓰러뜨렸습니다!!!");
//							
//								break;
//							}
//							else if (result1 <= 0)
//							{
//								printf("[system] !!!당신은 몬스터에게 공격을 가합니다!!! [남은 몬스터의 체력 : %d / %d]", result1, monster_max_hp);
//								Sleep(1000);
//								continue;
//							}
//						}
//						while(1)
//						{
//							monsterattresult(player_cur_hp, monsteratt);
//							if (result2 > 0)
//							{
//								printf("[system] 당신은 죽었습니다....");
//								break;
//							}
//							else if (result2 <= 0)
//							{
//								printf("[system] !!!몬스터가 당신을 공격합니다!!! [현재 당신의 체력 : %d / %d]", result2, player_max_hp);
//								Sleep(1000);
//								continue;
//							}
//						}
//
//
//					}
//					else if (41 <= battlechance && battlechance <= 100)
//					{
//						printf("[system] 당신은 회복의 샘을 찾았습니다. (%d %확률)\n", battlechance);
//						Sleep(1500);
//
//
//
//					}
//					loopcount++;
//					continue;
//				}
//				else if (loopcount == 7)	// 7번째 루프 출력문
//				{
//					printf("[system] 당신은 목적지에 도착했습니다. 당신의 여정은 여기서 끝납니다.\n");
//					break;					
//				}
//			}
//		}
//		else if (userinput == 2)	// 2번 선택시
//		{
//			printf("\n[system] 2를 입력하셨습니다. 게임을 종료합니다.\n\n");
//			break;
//		}
//		else		// 그 이외 입력시
//		{
//			printf("\n[system] 잘못된 입력입니다. 다시 입력해주세요.\n\n");
//			continue;
//		}
//		}
//		return 0;
//	}



//int playerattresult(int monster_cur_hp, int playeratt)
//{	
//	monster_cur_hp -= playeratt;
//	return result1;
//}
//
//int monsterattresult(int player_cur_hp, int monsteratt)
//{	
//	player_cur_hp -= monsteratt;
//	return result2;
//}

