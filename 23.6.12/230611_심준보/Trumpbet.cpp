#include<iostream>
#include<stdlib.h>
#include<conio.h>
#include<windows.h>
#include<time.h>


//// 유저 포인트, 베팅 포인트 변수 선언 ////
int user_point = 2000;
int user_bet = 0;
//// 유저 포인트, 베팅 포인트 변수 선언 끝 ////

//// 카드 풀 설정 ////
int cards[13] = { 2,3,4,5,6,7,8,9,10,11,12,13,14};
char pattern[4] = { 'C','H','D','S'};
//// 카드 풀 설정 끝 ////


int main()
{



	while (true)
	{


		//// 랜덤함수 및 유저, 컴퓨터 숫자 문양 변수 선언 ////
		srand(time(NULL));
		int user_card_number1 = cards[rand() % 13];
		char user_card_pattern1 = pattern[rand() % 4];


		int com_card_number1 = cards[rand() % 13];
		int com_card_number2 = cards[rand() % 13];
		char com_card_pattern1 = pattern[rand() % 4];
		char com_card_pattern2 = pattern[rand() % 4];
		//// 랜덤함수 및 유저, 컴퓨터 숫자 문양 변수 선언 끝 ////



		//// 출력 부분 ////
		printf("컴퓨터의 패 : ");
		printf("\n\n┌────────┐┌────────┐");
		printf("\n│ %c%2d    ││ %c%2d    │", com_card_pattern1, com_card_number1, com_card_pattern2, com_card_number2);
		printf("\n│        ││        │");
		printf("\n│        ││        │");
		printf("\n│        ││        │");
		printf("\n│        ││        │");
		printf("\n└────────┘└────────┘");
		printf("\n\n==========================================");
		printf("\n당신의 패 : ");
		printf("\n\n┌────────┐");
		printf("\n│ ??     │");
		printf("\n│        │");
		printf("\n│        │");
		printf("\n│        │");
		printf("\n│        │");
		printf("\n└────────┘");
		printf("\n\n보유 포인트 : %d (베팅 가능 범위는 0부터 보유 포인트까지입니다.)", user_point);
		printf("\n베팅 포인트 : ");
		// 출력 부분 끝 ////


		//// 유저 입력부분 및 베팅과 포인트 설정 ////
		user_bet = _getch();
		scanf_s("%d", &user_bet);

		while (true)
		{
			if (user_bet > user_point)
			{
				printf("베팅 포인트가 보유 포인트보다 많습니다. 다시 베팅하세요.\n베팅 포인트 : ");
				user_bet = _getch();
				scanf_s("%d", &user_bet);
			}
			else if (user_bet <= user_point)
			{
				break;
			}
		}

		user_point -= user_bet;
		//// 유저 입력부분 및 베팅과 포인트 설정 끝 ////



		//// 예측 성공 실패 판정 ////
		if ((com_card_number1) < (user_card_number1) && (user_card_number1) < (com_card_number2) && (user_bet != 0))		//// 컴1<유저<컴2 의 경우
		{
			printf("당신의 카드는 %c%d\n", user_card_pattern1, user_card_number1);
			printf("예측성공! 당신의 카드가 중간에 있습니다\n\n");

			user_point += user_bet * 2;
		}
		else if ((com_card_number2) < (user_card_number1) && (user_card_number1) < (com_card_number1) && (user_bet != 0))	//// 컴2<유저<컴1 의 경우
		{
			printf("당신의 카드는 %c%d\n", user_card_pattern1, user_card_number1);
			printf("예측성공! 당신의 카드가 중간에 있습니다\n\n");

			user_point += user_bet * 2;
		}
		else if(user_bet == 0)
		{
			printf("다이했습니다.");
			printf("당신의 카드는 %c%d\n", user_card_pattern1, user_card_number1);

			user_point = user_point;
		}
		else
		{
			printf("당신의 카드는 %c%d\n", user_card_pattern1, user_card_number1);
			printf("예측 실패...당신의 카드가 중간에 없습니다\n\n");

			user_point = user_point;
		}
		//// 예측 성공 실패 판정 끝 ////


		//// 승리 및 패배 판정 ////
		if (user_point >= 10000)
		{
			printf("★당신은 승리하였습니다★\n\n");
			break;
		}
		else if (user_point <= 0)
		{
			printf("...당신은 패배하였습니다...\n\n");
			break;
		}
		else
		{
			printf("계속 하려면 엔터를 누르세요\n\n");
			_getch();
			system("cls");
			continue;
		}
		//// 승리 및 패배 판정 끝 ////
	}
	return 0;
}




//void Shuffle_And_Draw()
//{
//
//
//
//
//}
//
//void Bet()
//{
//
//
//
//}
//
//void Result_Check()
//{
//	if ((&컴퓨터1 < &나) && (&나 < &컴퓨터2))
//	{
//		user_pont += user_bet * 2;
//		printf("예측성공! 당신의 카드가 중간에 있습니다");
//	}
//	else
//	{
//		user_point = user_point;
//		printf("예측 실패...당신의 카드가 중간에 없습니다");
//	}
//}
//
//void Game_check()
//{
//	while (true)
//	{
//		if(user_point >= 200000)
//		{
//			printf("★당신은 승리하였습니다★");
//			break;
//		}
//		else if(user_point <= 0)
//		{
//			printf("당신은 패배하였습니다");
//			break;
//		}
//		else
//		{
//			printf("");
//			continue;
//		}
//	}
//}






//void Swap_And_Draw()
//{
//	srand(time(NULL));
//
//	user_card_number1 = cards[rand() % 13];
//	user_card_number2 = cards[rand() % 13];
//	user_card_pattern1 = pattern[rand() % 4];
//	user_card_pattern2 = pattern[rand() % 4];
//
//
//	com_card_number1 = cards[rand() % 13];
//	com_card_number2 = cards[rand() % 13];
//	com_card_pattern1 = pattern[rand() % 4];
//	com_card_pattern2 = pattern[rand() % 4];
//}
//
//
//
//
//
//void Card_Pool()
//{
//	char* ptr_cards[13];
//	char cards[13] = { '2','3','4','5','6','7','8','9','J','Q','K','A' };
//
//	char* ptr_pattern[4];
//	char pattern[4] = { 'C','H','D','S' };
//
//
//	srand(time(NULL));
//
//	char user_card_number1 = cards[rand() % 13];
//	char com_card_number1 = cards[rand() % 13];
//	char com_card_number2 = cards[rand() % 13];
//
//	char user_card_pattern1 = pattern[rand() % 4];
//	char com_card_pattern1 = pattern[rand() % 4];
//	char com_card_pattern2 = pattern[rand() % 4];
//
//
//}
//
//void Draw()
////{
////printf("컴퓨터의 패 : ");
////printf("\n\n┌────────┐┌────────┐");
////printf("\n│        ││        │");
////printf("\n│        ││        │");
////printf("\n│        ││        │");
////printf("\n│        ││        │");
////printf("\n│        ││        │");
////printf("\n└────────┘└────────┘");
////
//// 	printf("컴퓨터의 패 : ");
//printf("\n\n┌────────┐┌────────┐");
//printf("\n│        ││        │");
//printf("\n│        ││        │");
//printf("\n│        ││        │");
//printf("\n│        ││        │");
//printf("\n│        ││        │");
//printf("\n└────────┘└────────┘");
//printf("\n\n==========================================");
//printf("\n\n당신의 패 : ");
//printf("\n\n┌────────┐");
//printf("\n│ ??     │");
//printf("\n│        │");
//printf("\n│        │");
//printf("\n│        │");
//printf("\n│        │");
//printf("\n└────────┘");
//printf("\n\n\n당신의 점수 : %d", user_point);
//printf("\n배팅할 점수 : ");
//user_bet = _getch();
//scanf_s("%d", user_bet);
////			
////
//
//}
//
//
//	
//}
//
//int numbers[13] = { 0, };				// 배열의 선언과 초기화 (1~13 뽑는 배열)
//char char_num[13] = { 0, };				// AJQK 때문에 문자로 출력해야 하므로 문자열을 하나 만든다 (int 말고 char)
//
//for (int i = 0; i < 13; i++)
//{
//	numbers[i] = i + 1;
//
//	if (numbers[i] == 1)
//	{
//		char_num[i] = 'A';				// 정수 배열의 값이 1일 때, 문자열은 A
//	}
//	else if (numbers[i] == 10)
//	{
//		char_num[i] = 'W';				// 정수 배열의 값이 10일 때, 문자열은 W -> 출력용 if에서 뽑아야하는 값
//	}
//	else if (numbers[i] == 11)
//	{
//		char_num[i] = 'J';				// 정수 배열의 값이 11일 때, 문자열은 J
//	}
//	else if (numbers[i] == 12)
//	{
//		char_num[i] = 'Q';				// 정수 배열의 값이 12일 때, 문자열은 Q
//	}
//	else if (numbers[i] == 13)
//	{
//		char_num[i] = 'K';				// 정수 배열의 값이 13일 때, 문자열은 K
//	}
//	else
//	{
//		char_num[i] = '1' + i;
//		//10 , 1 2 3 4 5 6 7 8 9
//		//1 2 3 4 5 5 
//	}
//}
//char patterns[4] = { 'S','H','D','C' };							// 스페이드, 하트, 다이아, 클로버 -> 문자열