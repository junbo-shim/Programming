#include<iostream>
#include<stdlib.h>
#include<windows.h>
#include<time.h>


//
//void Swap_And_Draw();
//void Win();
//void Lose();
//void Compare_Card();
//
//
//char* ptr_cards[13];
//char cards[13] = { '2','3','4','5','6','7','8','9','J','Q','K','A' };
//
//
//char* ptr_pattern[4];
//char pattern[4] = { '♣','♡','◇','♠' };
//
//
//char user_card_number1 = 0;
//char user_card_number2 = 0;
//char com_card_number1 = 0;
//char com_card_number2 = 0;
//
//
//char user_card_pattern1 = 0;
//char user_card_pattern2 = 0;
//char com_card_pattern1 = 0;
//char com_card_pattern2 = 0;




int main()
{
	//Swap_And_Draw();
	//Compare_Card();


	// 숫자 배열
	char* ptr_cards[13];
	char cards[13] = { '2','3','4','5','6','7','8','9','J','Q','K','A' };
	// 숫자 배열 끝
	


	// 패턴 배열
	char* ptr_pattern[4];
	char pattern[4] = { '♣','♡','◇','♠' };
	// 패턴 배열 끝




	// 유저 카드 숫자와 무늬 변수 초기화
	char user_card_number1 = 0;
	char user_card_number2 = 0;
	char com_card_number1 = 0;
	char com_card_number2 = 0;
	// 유저 카드 숫자와 무늬 변수 초기화



	// 컴퓨터 카드 숫자와 무늬 변수 초기화
	char user_card_pattern1 = 0;
	char user_card_pattern2 = 0;
	char com_card_pattern1 = 0;
	char com_card_pattern2 = 0;
	// 컴퓨터 카드 숫자와 무늬 변수 초기화




	// 랜덤 값 출력
	srand(time(NULL));

	user_card_number1 = cards[rand() % 13];
	user_card_number2 = cards[rand() % 13];
	user_card_pattern1 = pattern[rand() % 4];
	user_card_pattern2 = pattern[rand() % 4];


	com_card_number1 = cards[rand() % 13];
	com_card_number2 = cards[rand() % 13];
	com_card_pattern1 = pattern[rand() % 4];
	com_card_pattern2 = pattern[rand() % 4];
	//랜덤 값 출력 끝




	printf("UN1 %c UN2 %c UP1 %c UP2 %c \n CN1 %c CN2 %c CP1 %c CP2 %c\n", cards[rand() % 13], user_card_number2, user_card_pattern1, user_card_pattern2, com_card_number1, com_card_number2, com_card_pattern1, com_card_pattern2);



	// 경우의 수
	//if ((&user_card_number1 - &user_card_number2) > (&com_card_number1 - &com_card_number2))
	//{
	//	printf("승리 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//}
	//else if ((&user_card_number1 - &user_card_number2) < (&com_card_number1 - &com_card_number2))
	//{
	//	printf("패배 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//}
	//else if ((&user_card_number1 - &user_card_number2) == (&com_card_number1 - &com_card_number2))
	//{
	//	if ((&user_card_pattern1 - &user_card_pattern2) > (&com_card_pattern1 - &com_card_pattern2))
	//	{
	//		printf("승리 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//	}
	//	else if ((&user_card_pattern1 - &user_card_pattern2) < (&com_card_pattern1 - &com_card_pattern2))
	//	{
	//		printf("패배 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//	}
	//}
	//else if ((&user_card_number1 - &user_card_number2) > (&com_card_number1 - &com_card_number2))
	//{
	//	printf("승리 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//}
	//else if ((&user_card_number1 - &user_card_number2) < (&com_card_number1 - &com_card_number2))
	//{
	//	printf("패배 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//}
	//else if ((&user_card_number1 - &user_card_number2) == (&com_card_number1 - &com_card_number2))
	//{
	//	if ((&user_card_pattern1 - &user_card_pattern2) > (&com_card_pattern1 - &com_card_pattern2))
	//	{
	//		printf("승리 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//	}
	//	else if ((&user_card_pattern1 - &user_card_pattern2) < (&com_card_pattern1 - &com_card_pattern2))
	//	{
	//		printf("패배 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
	//	}
	//}
	// 경우의 수 끝



	return 0;

}


//
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
//void Compare_Card()
//{
//	if(( & user_card_number1 - &user_card_number2) > (&com_card_number1 - &com_card_number2))
//	{
//		Win();
//	}
//	else if((&user_card_number1 - &user_card_number2) < (&com_card_number1 - &com_card_number2))
//	{
//		Lose();
//	}
//	else if((&user_card_number1 - &user_card_number2) == (&com_card_number1 - &com_card_number2))
//	{
//		if((&user_card_pattern1 - &user_card_pattern2) > (&com_card_pattern1 - &com_card_pattern2))
//		{
//			Win();
//		}
//		else if((&user_card_pattern1 - &user_card_pattern2) < (&com_card_pattern1 - &com_card_pattern2))
//		{
//			Lose();
//		}
//	}
//	else if((&user_card_number1 - &user_card_number2) > (&com_card_number1 - &com_card_number2))
//	{
//		Win();
//	}
//	else if((&user_card_number1 - &user_card_number2) < (&com_card_number1 - &com_card_number2))
//	{
//		Lose();
//	}
//	else if ((&user_card_number1 - &user_card_number2) == (&com_card_number1 - &com_card_number2))
//	{
//		if ((&user_card_pattern1 - &user_card_pattern2) > (&com_card_pattern1 - &com_card_pattern2))
//		{
//			Win();
//		}
//		else if ((&user_card_pattern1 - &user_card_pattern2) < (&com_card_pattern1 - &com_card_pattern2))
//		{
//			Lose();
//		}
//	}
//}


//void Win()
//{
//	printf("승리 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
//}
//
//void Lose()
//{
//	printf("패배 \n당신의 패 : %c %c, %c %c \n컴퓨터의 패 : %c %c, %c %c", user_card_pattern1, user_card_pattern2, user_card_number1, user_card_number2, com_card_pattern1, com_card_pattern2, com_card_number1, com_card_number2);
//}
